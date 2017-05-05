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
        }

        private void CbPers_SelectedValueChanged(object sender, EventArgs e)
        {
            dgvTacheProd.DataSource = _listTachprod.Where(c => c.Login == (cbPers.Text) && c.CodeLogicieModule == ((string)cbLogiciel.SelectedItem)).ToList();
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
            cbLogiciel.DataSource = DALLogiciel.Codelogiciel();
            // cbVersion.DataSource = DALLogiciel.GetVers((string)cbLogiciel.SelectedValue);
            cbVersion.DataSource = DALLogiciel.listVersion((string)cbLogiciel.SelectedValue).Select(a => a.NumeroVersion).ToList();

            //foreach (var t in _listTach.Where(t => t.Annexe == false))
            //    _listTachprod.Add(t);

            //dgvTacheProd.DataSource = _listTachprod;



            foreach (var a in DALTache.GetTache())
            {
                _listTachprod.Add(a);
            }


            //dgvTacheProd.DataSource = _listTachprod;
            //dgvTacheProd.DataSource = ((((_listTachprod.Where((c=>c.Login == cbPers.Text))).Where(d => d.CodeLogicieModule == cbLogiciel.Text)).Where( g =>g.NumeroVersion.ToString() == cbVersion.Text)));
            //dgvTacheProd.DataSource = ((_listTachprod.Where(m => m.Login == cbPers.SelectedValue.ToString())).Where(n => n.CodeLogicieModule == cbLogiciel.SelectedValue)).ToList();
            //.Where(g => g.NumeroVersion == (float)cbVersion.SelectedValue).ToList();
            //dgvTacheProd.Columns["Login"].Visible = false;
            //dgvTacheProd.Columns["NumeroVersion"].Visible = false;
            dgvTacheProd.DataSource = _listTachprod.Where(c => c.Login == (cbPers.Text) && c.CodeLogicieModule == ((string)cbLogiciel.SelectedItem)).ToList();
            //&& c.NumeroVersion == ((float)cbVersion.SelectedItem)

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
