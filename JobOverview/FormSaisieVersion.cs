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
    public partial class FormSaisieVersion : Form
    {
        public Version VersionSaisie { get; private set; }


        public FormSaisieVersion()
        {
            InitializeComponent();
        }


        protected override void OnClosing(CancelEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                VersionSaisie = new Version();
                VersionSaisie.NumeroVersion = Convert.ToInt64(txt_NumeroVersion);
                VersionSaisie.MillesimeVersion = Convert.ToInt16(txt_millesime);
                VersionSaisie.DateOuvertureVersion = Convert.ToDateTime(txt_DateOuverture);
                VersionSaisie.DateSortiePrevueVersion = Convert.ToDateTime(txt_DateSortiePrevue);
            }

            base.OnClosing(e);
        }

    }
}
