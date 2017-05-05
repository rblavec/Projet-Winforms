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
    public partial class FormGestionTachesProduct : Form
    {

        #region variables privées

        public static List<TacheProd> _listTachprod = new List<TacheProd>();
        private List<TacheProd> _listTach;
        #endregion

        #region Constructeur

        public FormGestionTachesProduct()
        {
            InitializeComponent();
            btAjouTache.Click += BtAjouTache_Click;

            dgvTacheProd.CellClick += DgvTacheProd_CellClick;
            cbPers.SelectedValueChanged += CbPers_SelectedValueChanged;
            cbLogiciel.SelectedValueChanged += CbPers_SelectedValueChanged;
            cbVersion.SelectedValueChanged += CbPers_SelectedValueChanged;
            chk_termine.CheckedChanged += CbPers_SelectedValueChanged;
            
        }

        private void CbPers_SelectedValueChanged(object sender, EventArgs e)
        {
            // On filtre la DataGridView en fonction du nom du logiciel, du Login et de la version.
            // Nous appliquons également un filtre pour n'obtenir que les taches de productions.  
            // Ici, nous rafraichissons la DataGridView à chaque changement de valeur dans une des comboBox. 
            // On place une checkedBox afin de filtrer les taches de productions terminées, 
            // c'est à dire les taches dont les temps restant est estimé à 0 ou différent de 0.
            // La checkedBox est non cochée par défault.
            if (chk_termine.Checked)
            {
                dgvTacheProd.DataSource = _listTachprod.Where(c => c.Login == (cbPers.Text) && c.CodeLogicieModule == ((string)cbLogiciel.SelectedItem)
                           && c.NumeroVersion == ((float)cbVersion.SelectedItem) && c.Annexe == false && c.DureeRestanteEstimee == 0).ToList();
            }
            else
            {

                dgvTacheProd.DataSource = _listTachprod.Where(c => c.Login == (cbPers.Text) && c.CodeLogicieModule == ((string)cbLogiciel.SelectedItem)
            && c.NumeroVersion == ((float)cbVersion.SelectedItem) && c.Annexe == false && c.DureeRestanteEstimee != 0).ToList();
            }

        }

        private void DgvTacheProd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // On souhaite afficher la description de la tache selectionnée dans une textBox. 
            tbDescription.Text = ((Tache)dgvTacheProd.CurrentRow.DataBoundItem).Description;
        }

        #endregion
        private void BtAjouTache_Click(object sender, EventArgs e)
        {
            using (FormSaisieTacheProd formSaisieTacheProd = new FormSaisieTacheProd((string)cbPers.SelectedValue, (string)cbLogiciel.SelectedValue, (float)cbVersion.SelectedValue))
            {
                DialogResult dialog = formSaisieTacheProd.ShowDialog();
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            cbPers.DataSource = DALTache.GetPers().Select(a => a.Login).ToList();
            cbLogiciel.DataSource = DALLogiciel.Codelogiciel();

            cbVersion.DataSource = DALLogiciel.listVersion((string)cbLogiciel.SelectedValue).Select(a => a.NumeroVersion).ToList();


            foreach (var a in DALTache.GetTache())
            {
                _listTachprod.Add(a);
            }


            // On filtre la DataGridView en fonction du nom du logiciel, du Login et de la version.
            // Nous appliquons également un filtre pour n'obtenir que les taches de productions.  
            // On place une checkedBox afin de filtrer les taches de productions terminées,
            // c'est à dire les taches dont les temps restant est estimé à 0 ou différent de 0.
            // La checkedBox est non cochée par défault.             
            if (chk_termine.Checked)
            {
                dgvTacheProd.DataSource = _listTachprod.Where(c => c.Login == (cbPers.Text) && c.CodeLogicieModule == ((string)cbLogiciel.SelectedItem)
                           && c.NumeroVersion == ((float)cbVersion.SelectedItem) && c.Annexe == false && c.DureeRestanteEstimee == 0).ToList();
            }
            else
            {
                
                dgvTacheProd.DataSource = _listTachprod.Where(c => c.Login == (cbPers.Text) && c.CodeLogicieModule == ((string)cbLogiciel.SelectedItem)
            && c.NumeroVersion == ((float)cbVersion.SelectedItem) && c.Annexe == false && c.DureeRestanteEstimee != 0).ToList();
            }


            // On rend invisible les colonnes qui ne sont pas necessaire afin de rendre disponible un maximum 
            // d'informations utile en limitant la largeur de la DataGridView.
            dgvTacheProd.Columns["Numero"].Visible = false;
            dgvTacheProd.Columns["IdTache"].Visible = false;
            dgvTacheProd.Columns["Annexe"].Visible = false;
            dgvTacheProd.Columns["login"].Visible = false;
            dgvTacheProd.Columns["NumeroVersion"].Visible = false;
            dgvTacheProd.Columns["Description"].Visible = false;

            //dgvTacheProd.CurrentRow.DataBoundItem


            //.Where(a=>a.NumeroVersion == (float)cbVersion.SelectedValue).ToList();

            //foreach (var t in _listTach.Where(t => t.Annexe == true))
            //    _listTachprod.Add(t);

            //dgvTacheProd.DataSource = _listTachprod;
            //tbDescription.Text = ((Tache)dgvTacheProd.CurrentRow.DataBoundItem).Description;

            base.OnLoad(e);
        }





        //todo ajouter une tache de production

        //private void BtAjouTache_Click(object sender, EventArgs e)
        //{
        //    using (FormSaisieTacheProd formSaisieTacheProd = new FormSaisieTacheProd())
        //    {
        //        DialogResult dialog = formSaisieTacheProd.ShowDialog();
        //        if (dialog == DialogResult.OK)
        //        {
        //            //_list.Add(formSaisieTacheProd.TacheProdSaisie);
        //        }
        //        //DAL.AjouProd(formsaisieproduit.ProduitSaisi);
        //        //_produitsAjoutés.Add(formsaisieproduit.ProduitSaisi);
        //    }
        //}
    }
}
