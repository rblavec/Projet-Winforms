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

        private BindingList<Tache> _listTachprod;
        private BindingList<Tache> _listTach;
        #endregion

        #region Constructeur

        public FormGestionTachesProduct()
        {
            InitializeComponent();
            btAjouTache.Click += BtAjouTache_Click;
            _listTachprod = new BindingList<Tache>();
            dgvTacheProd.CellClick += DgvTacheProd_CellClick;
        }

        private void DgvTacheProd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbDescription.Text = ((Tache)dgvTacheProd.CurrentRow.DataBoundItem).Description;
        }

        #endregion
        private void BtAjouTache_Click(object sender, EventArgs e)
        {
            using (FormSaisieTacheProd formSaisieTacheProd = new FormSaisieTacheProd())
            {
                DialogResult dialog = formSaisieTacheProd.ShowDialog();
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            cbPers.DataSource = DALTache.GetPers().Select(a => a.Login).ToList();
            cbLogiciel.DataSource = DALLogiciel.nomlogiciel();
           // cbVersion.DataSource = DALLogiciel.GetVers((string)cbLogiciel.SelectedValue);
            cbVersion.DataSource = DALLogiciel.listVersion((string)cbLogiciel.SelectedValue).Select(a=>a.NumeroVersion).ToList();

            //foreach (var t in _listTach.Where(t => t.Annexe == false))
            //    _listTachprod.Add(t);

            //dgvTacheProd.DataSource = _listTachprod;
            

            _listTach = DALTache.GetTache();
            dgvTacheProd.DataSource = _listTach;
            dgvTacheProd.Columns["Annexe"].Visible = false;
            dgvTacheProd.Columns["Login"].Visible = false;
            dgvTacheProd.Columns["NumeroVersion"].Visible = false;
            dgvTacheProd.Columns["CodeLogicielVersion"].Visible = false;


            //dgvTacheProd.CurrentRow.DataBoundItem


            //.Where(a=>a.NumeroVersion == (float)cbVersion.SelectedValue).ToList();

            //foreach (var t in _listTach.Where(t => t.Annexe == true))
            //    _listTachprod.Add(t);

            //dgvTacheProd.DataSource = _listTachprod;
            tbDescription.Text = ((Tache)dgvTacheProd.CurrentRow.DataBoundItem).Description;

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
