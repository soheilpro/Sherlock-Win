using System;
using System.Windows.Forms;
using Sherlock.Database;

namespace Sherlock
{
    public partial class frmAddEditItem : Form
    {
        private Item _item;

        public Item Item
        {
            get
            {
                return _item;
            }
            set
            {
                _item = value;
            }
        }

        public frmAddEditItem()
        {
            InitializeComponent();

            ToggleCommands();
        }

        public DialogResult ShowAdd()
        {
            ShowDialog();

            if (DialogResult == DialogResult.OK)
            {
                _item = new Item();
                _item.Name = txtName.Text.Trim();
                _item.Value = txtValue.Text.Trim();

                if (chkIsSecret.Checked)
                {
                    _item.Type = ItemType.Secret;
                }
                else
                {
                    if (RegexHelper.UrlRegex.IsMatch(_item.Value))
                        _item.Type = ItemType.Url;

                    else if (RegexHelper.EMailRegex.IsMatch(_item.Value))
                        _item.Type = ItemType.EMail;

                    else
                        _item.Type = ItemType.Text;
                }
            }

            return DialogResult;
        }

        public DialogResult ShowEdit()
        {
            txtName.Text = _item.Name;
            txtValue.Text = _item.Value;
            chkIsSecret.Checked = (_item.Type == ItemType.Secret);

            ShowDialog();

            if (DialogResult == DialogResult.OK)
            {
                _item.Name = txtName.Text.Trim();
                _item.Value = txtValue.Text.Trim();

                if (chkIsSecret.Checked)
                {
                    _item.Type = ItemType.Secret;
                }
                else
                {
                    if (RegexHelper.UrlRegex.IsMatch(_item.Value))
                        _item.Type = ItemType.Url;

                    else if (RegexHelper.EMailRegex.IsMatch(_item.Value))
                        _item.Type = ItemType.EMail;

                    else
                        _item.Type = ItemType.Text;
                }
            }

            return DialogResult;
        }

        private void ToggleCommands()
        {
            btnOK.Enabled = (txtName.Text.Trim().Length != 0 && txtValue.Text.Trim().Length != 0);
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            ToggleCommands();
        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {
            ToggleCommands();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter a name for this item.", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtName.Focus();
                return;
            }

            if (txtValue.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter a value for this item.", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtValue.Focus();
                return;
            }

            DialogResult = DialogResult.OK;
        }
    }
}
