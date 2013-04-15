using System;
using System.Windows.Forms;

namespace Sherlock
{
    public partial class frmChangePassword : Form
    {
        public string NewPassword
        {
            get
            {
                if (txtNewPassword.Text.Length != 0)
                    return txtNewPassword.Text;
                
                return null;
            }
            set
            {
                txtNewPassword.Text = value;
            }
        }

        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtCurrentPassword.Text == txtNewPassword.Text)
            {
                MessageBox.Show("Please enter a new password.", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNewPassword.Focus();
                return;
            }

            if (txtNewPassword.Text.Length != 0 && Database.Database.IsWeakPassword(txtNewPassword.Text))
            {
                MessageBox.Show("Please enter a strong password.", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNewPassword.Focus();
                return;
            }

            if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match.", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtConfirmPassword.Focus();
                return;
            }

            DialogResult = DialogResult.OK;
        }
    }
}
