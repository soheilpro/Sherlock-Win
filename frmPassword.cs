using System;
using System.IO;
using System.Windows.Forms;

namespace Sherlock
{
    public partial class frmPassword : Form
    {
        private string _filename;

        public string Filename
        {
            get
            {
                return _filename;
            }
            set
            {
                _filename = value;
            }
        }

        public string Password
        {
            get
            {
                return txtPassword.Text;
            }
            set
            {
                txtPassword.Text = value;
            }
        }

        public frmPassword()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            Text = string.Format("{0} - Sherlock", Path.GetFileName(_filename));
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter your password.", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPassword.Focus();
                return;
            }

            DialogResult = DialogResult.OK;
        }
    }
}
