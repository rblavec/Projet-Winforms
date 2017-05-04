using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobOverview
{
    public partial class FormGestionVersionLogiciel : Form
    {
        private BindingList<Version> _Version;

        private List<Version> _VersionAjouté;

        private List<Version> _VersionSupprimé;



        public FormGestionVersionLogiciel()
        {
            InitializeComponent();

            _VersionAjouté = new List<Version>();
            _VersionSupprimé = new List<Version>();
            _Version = new BindingList<Version>();

            // On affiche dans la ComboBox la liste des logiciels obtenues grâce à une requête SQL dans la classe DALLogiciel. 
            cbox_logiciels.DataSource = DALLogiciel.nomlogiciel();

            // On affiche dans la DataGridView la liste des versions et on selectionne seulement les versions correspondants au 
            // nom de logiciel selectionné en paramètre
            dgv_ModulesVersions.DataSource = DALLogiciel.listVersion((string)cbox_logiciels.SelectedValue);

            // On fais en sorte que lorsque le logiciel sélectionné dans la combobox change, les DataGridView également pour correspondre à la requête du client
            // (Nom du logiciel)
            cbox_logiciels.SelectedIndexChanged += Cbox_logiciels_SelectedIndexChanged;

            // On affiche dans la DataGridView la liste des modules et on selectionne seulement les modules correspondants au 
            // nom de logiciel selectionné en paramètre
            dgv_modules.DataSource = DALLogiciel.listModule((string)cbox_logiciels.SelectedValue);

            // On créé un bouton afin d'afficher une fenêtre modale qui nous permettra de rentrer les paramètres nécéssaires à la création d'une nouvelle
            // Version.
            btn_AjoutVersion.Click += Btn_AjoutVersion_Click;

            btn_suppVersion.Click += Btn_suppVersion_Click;

        }



        // On créé la méthode qui sera appellée lors du click sur le bouton de suppression de version.
        private void Btn_suppVersion_Click(object sender, EventArgs e)
        {

            // On supprime de la liste la version selectionnée.
            _VersionSupprimé.Remove((Version)dgv_ModulesVersions.CurrentRow.DataBoundItem);
            DALLogiciel.SupprimerVersion((Version)dgv_ModulesVersions.CurrentRow.DataBoundItem);
            _Version.Remove((Version)dgv_ModulesVersions.CurrentRow.DataBoundItem);


            // On rafraichi la liste.
            _Version = DALLogiciel.listVersion((string)cbox_logiciels.SelectedValue);
            dgv_ModulesVersions.DataSource = _Version;
        }


        // On créé la méthode qui sera appellée lors du click sur le bouton d'ajout de version.
        private void Btn_AjoutVersion_Click(object sender, EventArgs e)
        {

            // On affiche la fenêtre modale dans laquelle on va créer une nouvelle Version.
            using (var FormVersion = new FormSaisieVersion())
            {
                DialogResult dr = FormVersion.ShowDialog();

                // On créé une condition afin que la nouvelle version ne soit ajoutée que lors du click sur le bouton OK.
                if (dr == DialogResult.OK)
                {
                    _VersionAjouté.Add(FormVersion.VersionSaisie);
                    _Version.Add(FormVersion.VersionSaisie);
                    DALLogiciel.AjoutVersion(FormVersion.VersionSaisie);

                    // On rafraichi la liste.
                    _Version = DALLogiciel.listVersion((string)cbox_logiciels.SelectedValue);
                    dgv_ModulesVersions.DataSource = _Version;


                }

            }

        }

        // On créé une méthode qui va nous permettre d'actualiser les DatagridView en fonction du nom de logiciel selectionné par l'utilisateur.
        private void Cbox_logiciels_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_ModulesVersions.DataSource = DALLogiciel.listVersion((string)cbox_logiciels.SelectedValue);
            dgv_modules.DataSource = DALLogiciel.listModule((string)cbox_logiciels.SelectedValue);
        }


        protected override void OnLoad(EventArgs e)
        {

            dgv_modules.DataSource = null;
            dgv_ModulesVersions.DataSource = null;
            base.OnLoad(e);
        }
    }
}
