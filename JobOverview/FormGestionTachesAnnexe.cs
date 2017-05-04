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
    public partial class FormGestionTachesAnnexe : Form
    {
        public FormGestionTachesAnnexe()
        {
            InitializeComponent();

            cbox_listePersonne.DataSource = DALTache.GetPers().Select(a => a.Login).ToList();
        }
    }
}
