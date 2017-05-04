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
            cbox_logiciels.DataSource = DALLogiciel.nomlogiciel();
            dgv_ModulesVersions.DataSource = DALLogiciel.listVersion((string)cbox_logiciels.SelectedValue);
            cbox_logiciels.SelectedIndexChanged += Cbox_logiciels_SelectedIndexChanged;
            dgv_modules.DataSource = DALLogiciel.listModule((string)cbox_logiciels.SelectedValue);


            btn_AjoutVersion.Click += Btn_AjoutVersion_Click;
        }

        private void Btn_AjoutVersion_Click(object sender, EventArgs e)
        {
            using (var FormVersion = new FormSaisieVersion())
            {
                DialogResult dr = FormVersion.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    _VersionAjouté.Add(FormVersion.VersionSaisie);
                    _Version.Add(FormVersion.VersionSaisie);

                    // On rafraichi la liste.
                    _Version = DALLogiciel.listVersion((string)cbox_logiciels.SelectedValue);
                    dgv_ModulesVersions.DataSource = _Version;

                }

            }
        }

        private void Cbox_logiciels_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_ModulesVersions.DataSource = DALLogiciel.listVersion((string)cbox_logiciels.SelectedValue);
        }
    }
}
