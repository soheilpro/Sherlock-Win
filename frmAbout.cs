using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Sherlock
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
            lblVersion.Text = string.Format(lblVersion.Text, GetType().Assembly.GetName().Version);
        }

        private void lnlWebSite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(lnlWebSite.Text);
        }
    }
}
