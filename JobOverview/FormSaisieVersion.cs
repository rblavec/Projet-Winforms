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
                VersionSaisie.NumeroVersion = Convert.ToInt64(txt_NumeroVersion.Text);
                VersionSaisie.MillesimeVersion = Convert.ToInt16(txt_millesime.Text);
                VersionSaisie.DateOuvertureVersion = Convert.ToDateTime(txt_DateOuverture.Text);
                VersionSaisie.DateSortiePrevueVersion = Convert.ToDateTime(txt_DateSortiePrevue.Text);
            }

            base.OnClosing(e);
        }

    }
}
