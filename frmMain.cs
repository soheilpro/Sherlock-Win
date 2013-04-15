using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;
using Sherlock.Database;

namespace Sherlock
{
    public partial class frmMain : Form
    {
        private Database.Database _database;
        private TreeNode _databaseNode;
        private bool _isDirty;

        public frmMain()
        {
            InitializeComponent();
            InitializeDataBase();
            InitializeContextMenus();
            InitializeTreeView();
        }

        public frmMain(params string[] args) : this()
        {
            if (args.Length == 1)
                OpenDataBase(args[0]);
        }

        private void InitializeDataBase()
        {
            _database = new Database.Database();
        }

        private void InitializeTreeView()
        {
            _databaseNode = new TreeNode();
            _databaseNode.Text = "My Data";
            _databaseNode.Tag = _database;

            tvwFolders.Nodes.Add(_databaseNode);
        }

        private void InitializeContextMenus()
        {
        }

        private bool SaveChangesAndContinue()
        {
            if (!_isDirty)
                return true;

            var result = MessageBox.Show("You have not saved your changes.\nSave them now?", Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            switch (result)
            {
                case DialogResult.Yes:
                    mnuFileSave.PerformClick();
                    return true;

                case DialogResult.No:
                    return true;

                case DialogResult.Cancel:
                    return false;
            }

            return true;
        }

        private void OpenDataBase(string filename)
        {
            string password = null;

            TryOpen:

            try
            {
                var database = Database.Database.Load(filename, password);

                LoadDataBase(database);
                Text = string.Format("{0} - Sherlock", Path.GetFileName(filename));
                _isDirty = false;

                return;
            }
            catch (InvalidPasswordException)
            {
                if (password != null)
                    MessageBox.Show("Invalid password.", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                var passwordForm = new frmPassword();
                passwordForm.Filename = filename;
                passwordForm.ShowDialog();

                if (passwordForm.DialogResult == DialogResult.OK)
                {
                    password = passwordForm.Password;
                    goto TryOpen;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDataBase(Database.Database database)
        {
            _database = database;
            _databaseNode.Tag = database;
            _databaseNode.Nodes.Clear();

            AddSubFolderNodes(database, _databaseNode);

            tvwFolders.SelectedNode = _databaseNode;
            OnSelectedFolderChanged();
            _databaseNode.Expand();
        }

        private void AddSubFolderNodes(Folder folder, TreeNode folderNode)
        {
            foreach (Folder subFolder in folder.Folders)
            {
                var subFolderNode = new TreeNode(subFolder.Name);
                subFolderNode.Tag = subFolder;
                folderNode.Nodes.Add(subFolderNode);

                AddSubFolderNodes(subFolder, subFolderNode);
            }

            tvwFolders.Sort();
        }

        private void AddListItem(Item item, bool selected)
        {
            var listItem = new ListViewItem();
            listItem.Tag = item;
            SetItem(listItem, item);
            lvwItems.Items.Add(listItem);

            if (selected)
            {
                lvwItems.SelectedItems.Clear();
                listItem.Selected = true;
            }
        }

        private void SetItem(ListViewItem listItem, Item item)
        {
            listItem.Text = item.Name;
            listItem.ImageIndex = 2;
            listItem.UseItemStyleForSubItems = false;

            if (listItem.SubItems.Count == 2)
                listItem.SubItems.RemoveAt(1);

            if (item.Type == ItemType.Secret)
                listItem.SubItems.Add(new String('*', item.Value.Length));

            else if (item.Type == ItemType.Url || item.Type == ItemType.EMail)
                listItem.SubItems.Add(item.Value, Color.Blue, lvwItems.BackColor, lvwItems.Font);

            else
                listItem.SubItems.Add(item.Value);
        }

        private void mnuFileNew_Click(object sender, EventArgs e)
        {
            if (!SaveChangesAndContinue())
                return;

            LoadDataBase(new Database.Database());
            _isDirty = false;
        }

        private void mnuFileOpen_Click(object sender, EventArgs e)
        {
            if (!SaveChangesAndContinue())
                return;

            var dialog = new OpenFileDialog();
            dialog.Filter = "Sherlock Database Files (*.sdb)|*.sdb|All Files (*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.Cancel)
                return;

            OpenDataBase(dialog.FileName);
        }

        private void mnuFileSave_Click(object sender, EventArgs e)
        {
            if (_database.Fileame == null)
            {
                mnuFileSaveAs.PerformClick();
                return;
            }

            try
            {
                _database.Save();
                _isDirty = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mnuFileSaveAs_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = "Sherlock Database Files (*.sdb)|*.sdb|All Files (*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.Cancel)
                return;

            try
            {
                _database.Save(dialog.FileName);
                _isDirty = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mnuFileChangePassword_Click(object sender, EventArgs e)
        {
            var passwordChangeForm = new frmChangePassword();
            passwordChangeForm.ShowDialog();

            if (passwordChangeForm.DialogResult == DialogResult.Cancel)
                return;

            _database.Password = passwordChangeForm.NewPassword;
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuItemCopy_Click(object sender, EventArgs e)
        {
            var item = (Item)lvwItems.SelectedItems[0].Tag;
            var text = item.Value;

            Clipboard.SetText(text);
        }

        private void mnuItemCopyStripped_Click(object sender, EventArgs e)
        {
            var item = (Item)lvwItems.SelectedItems[0].Tag;
            var text = item.Value;
            text = text.Replace(" ", string.Empty);
            text = text.Replace("-", string.Empty);

            Clipboard.SetText(text);
        }

        private void mnuItemOpen_Click(object sender, EventArgs e)
        {
            var item = (Item)lvwItems.SelectedItems[0].Tag;

            switch (item.Type)
            {
                case ItemType.Url:
                    Process.Start(item.Value);
                    break;

                case ItemType.EMail:
                    Process.Start(string.Format("mailto:{0}", item.Value));
                    break;
            }
        }

        private void mnuFolderAdd_Click(object sender, EventArgs e)
        {
            var folder = ((Folder)tvwFolders.SelectedNode.Tag).Folders.Add("New Folder");
            var folderNode = new TreeNode(folder.Name);
            folderNode.Tag = folder;

            tvwFolders.SelectedNode.Nodes.Add(folderNode);
            tvwFolders.SelectedNode.Expand();

            folderNode.EnsureVisible();
            tvwFolders.SelectedNode = folderNode;

            _isDirty = true;

            folderNode.BeginEdit();
        }

        private void mnuFolderRename_Click(object sender, EventArgs e)
        {
            tvwFolders.SelectedNode.BeginEdit();
        }

        private void mnuFolderDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to remove this folder and all of its contents?", "Folder Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                return;

            var folder = (Folder)tvwFolders.SelectedNode.Tag;

            folder.RemoveMe();
            tvwFolders.SelectedNode.Remove();

            _isDirty = true;
        }

        private void mnuItemAdd_Click(object sender, EventArgs e)
        {
            var addItemForm = new frmAddEditItem();
            addItemForm.ShowAdd();

            if (addItemForm.DialogResult == DialogResult.Cancel)
                return;

            ((Folder)tvwFolders.SelectedNode.Tag).Items.Add(addItemForm.Item);

            lvwItems.Select();
            AddListItem(addItemForm.Item, true);

            _isDirty = true;
        }

        private void mnuItemEdit_Click(object sender, EventArgs e)
        {
            var listItem = lvwItems.SelectedItems[0];
            var item = (Item)listItem.Tag;

            var editItemForm = new frmAddEditItem();
            editItemForm.Item = item;
            editItemForm.ShowEdit();

            if (editItemForm.DialogResult == DialogResult.Cancel)
                return;

            SetItem(listItem, item);

            OnSelectedItemChanged();

            _isDirty = true;
        }

        private void mnuItemDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to remove the selected item?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                return;

            var listItem = lvwItems.SelectedItems[0];
            ((Item)listItem.Tag).RemoveMe();
            lvwItems.Items.Remove(listItem);

            _isDirty = true;
        }

        private void mnuToolsRegisterShellExtensions_Click(object sender, EventArgs e)
        {
            using (var extensionKey = Registry.ClassesRoot.CreateSubKey(".sdb"))
            {
                extensionKey.SetValue(null, "Sherlock.Database");
            }

            using (var progIDKey = Registry.ClassesRoot.CreateSubKey("Sherlock.Database"))
            {
                progIDKey.SetValue(null, "Sherlock Database");

                using (var defaultIconKey = progIDKey.CreateSubKey("DefaultIcon"))
                    defaultIconKey.SetValue(null, Application.ExecutablePath);

                using (var openCommandKey = progIDKey.CreateSubKey("Shell\\Open\\Command"))
                    openCommandKey.SetValue(null, string.Format("{0} \"%1\"", Application.ExecutablePath));
            }

            MessageBox.Show("Shell extension registration completed successfully.", "Sherlock", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnuToolsRepairDatabase_Click(object sender, EventArgs e)
        {
            RepairFolder(_database);

            MessageBox.Show("Database repair completed successfully.", "Sherlock", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RepairFolder(Folder folder)
        {
            foreach (Item item in folder.Items)
            {
                if (item.Type == ItemType.Secret)
                    continue;

                if (RegexHelper.UrlRegex.IsMatch(item.Value))
                    item.Type = ItemType.Url;

                else if (RegexHelper.EMailRegex.IsMatch(item.Value))
                    item.Type = ItemType.EMail;

                else
                    item.Type = ItemType.Text;
            }

            foreach (Folder subFolder in folder.Folders)
                RepairFolder(subFolder);
        }

        private void mnuHelpAbout_Click(object sender, EventArgs e)
        {
            new frmAbout().ShowDialog();
        }

        private void tvwCategories_AfterSelect(object sender, TreeViewEventArgs e)
        {
            OnSelectedFolderChanged();
        }

        private void OnSelectedFolderChanged()
        {
            lvwItems.Items.Clear();

            var folder = (Folder)tvwFolders.SelectedNode.Tag;

            ToggleFolderCommands(folder);
            stpFolder.Text = tvwFolders.SelectedNode.FullPath;

            foreach (Item Item in folder.Items)
                AddListItem(Item, false);

            lvwItems.Sort();

            OnSelectedItemChanged();
        }

        private void ToggleFolderCommands(Folder folder)
        {
            var isRootNodeSelected = (folder == _database);

            mnuFolderRename.Enabled = !isRootNodeSelected;
            mnuFolderDelete.Enabled = !isRootNodeSelected;

            cmsFolderRename.Enabled = !isRootNodeSelected;
            cmsFolderDelete.Enabled = !isRootNodeSelected;

            tbbFolderRename.Enabled = !isRootNodeSelected;
            tbbFolderDelete.Enabled = !isRootNodeSelected;
        }

        private void tvwCategories_BeforeLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (e.Node == _databaseNode)
                e.CancelEdit = true;
        }

        private void tvwCategories_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (e.Label == null || e.Label.Trim().Length == 0)
            {
                e.CancelEdit = true;
                return;
            }

            ((Folder)e.Node.Tag).Name = e.Label;
            _isDirty = true;
        }

        private void tvwCategories_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:
                    if (mnuFolderRename.Enabled)
                        mnuFolderRename.PerformClick();
                    break;

                case Keys.Delete:
                    if (mnuFolderDelete.Enabled)
                        mnuFolderDelete.PerformClick();
                    break;
            }
        }

        private void tvwCategories_ItemDrag(object sender, ItemDragEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void tvwCategories_DragOver(object sender, DragEventArgs e)
        {
            var targetPoint = tvwFolders.PointToClient(new Point(e.X, e.Y));
            var targetNode = tvwFolders.GetNodeAt(targetPoint);

            if (e.Data.GetDataPresent(typeof(ListViewItem)))
            {
                var draggedListViewItem = (ListViewItem)e.Data.GetData(typeof(ListViewItem));

                if (((Item)draggedListViewItem.Tag).Parent == (targetNode.Tag))
                    e.Effect = DragDropEffects.None;
                else
                    e.Effect = DragDropEffects.Move;
            }
            else
            {
                var draggedNode = (TreeNode)e.Data.GetData(typeof(TreeNode));

                if (targetNode == draggedNode || targetNode == draggedNode.Parent || ContainsNode(draggedNode, targetNode))
                    e.Effect = DragDropEffects.None;
                else
                    e.Effect = DragDropEffects.Move;
            }
        }

        private void tvwCategories_DragDrop(object sender, DragEventArgs e)
        {
            var targetPoint = tvwFolders.PointToClient(new Point(e.X, e.Y));
            var targetNode = tvwFolders.GetNodeAt(targetPoint);

            if (e.Data.GetDataPresent(typeof(ListViewItem)))
            {
                var draggedListViewItem = (ListViewItem)e.Data.GetData(typeof(ListViewItem));

                var draggedItem = (Item)draggedListViewItem.Tag;
                draggedItem.RemoveMe();

                ((Folder)targetNode.Tag).Items.Add(draggedItem);
                lvwItems.Items.Remove(draggedListViewItem);

                _isDirty = true;
            }

            if (e.Data.GetDataPresent(typeof(TreeNode)))
            {
                var draggedNode = (TreeNode)e.Data.GetData(typeof(TreeNode));

                var selectedNodeDragged = draggedNode.IsSelected;

                var draggedFolder = (Folder)draggedNode.Tag;
                draggedFolder.RemoveMe();
                draggedNode.Remove();

                ((Folder)targetNode.Tag).Folders.Add(draggedFolder);
                targetNode.Nodes.Add(draggedNode);

                if (selectedNodeDragged)
                    tvwFolders.SelectedNode = draggedNode;

                _isDirty = true;
            }
        }

        private bool ContainsNode(TreeNode node1, TreeNode node2)
        {
            if (node2.Parent == null)
                return false;

            if (node2.Parent.Equals(node1))
                return true;

            return ContainsNode(node1, node2.Parent);
        }

        private void OnSelectedItemChanged()
        {
            Item item = null;

            if (lvwItems.SelectedItems.Count != 0)
                item = (Item)lvwItems.SelectedItems[0].Tag;

            ToggleItemCommands(item);
            PopulateItemCopyParts(item);
        }

        private void ToggleItemCommands(Item item)
        {
            var anyItemSelected = (item != null);
            var isOpenable = (item != null) && (item.Type == ItemType.Url || item.Type == ItemType.EMail);
            var isText = (item != null) && (item.Type == ItemType.Text);

            mnuItemEdit.Enabled = anyItemSelected;
            mnuItemDelete.Enabled = anyItemSelected;
            mnuItemCopy.Enabled = anyItemSelected;
            mnuItemCopyStripped.Enabled = anyItemSelected;
            mnuItemCopyPart.Enabled = anyItemSelected && isText;
            mnuItemOpen.Enabled = anyItemSelected && isOpenable;

            cmsItemEdit.Enabled = anyItemSelected;
            cmsItemDelete.Enabled = anyItemSelected;
            cmsItemCopy.Enabled = anyItemSelected;
            cmsItemCopyStripped.Enabled = anyItemSelected && isText;
            cmsItemCopyPart.Enabled = anyItemSelected && isText;
            cmsItemOpen.Enabled = anyItemSelected && isOpenable;

            tbbItemEdit.Enabled = anyItemSelected;
            tbbItemDelete.Enabled = anyItemSelected;
            tbbItemCopy.Enabled = anyItemSelected;
            tbbItemOpen.Enabled = anyItemSelected && isOpenable;
        }

        private void PopulateItemCopyParts(Item item)
        {
            mnuItemCopyPart.DropDownItems.Clear();
            cmsItemCopyPart.DropDownItems.Clear();

            if (item == null)
                return;

            if (item.Type != ItemType.Text)
                return;

            var parts = item.Value.Split(' ', '-', '/');

            foreach (var part in parts)
            {
                var menu1 = new ToolStripMenuItem();
                menu1.Text = part;
                menu1.Click += delegate(object sender2, EventArgs e2) { Clipboard.SetText(((ToolStripMenuItem)sender2).Text); };

                mnuItemCopyPart.DropDownItems.Add(menu1);

                var menu2 = new ToolStripMenuItem();
                menu2.Text = part;
                menu2.Click += delegate(object sender2, EventArgs e2) { Clipboard.SetText(((ToolStripMenuItem)sender2).Text); };

                cmsItemCopyPart.DropDownItems.Add(menu2);
            }
        }

        private void lvwItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            OnSelectedItemChanged();
        }

        private void lvwItems_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            if (e.Label == null || e.Label.Trim().Length == 0)
            {
                e.CancelEdit = true;
                return;
            }

            ((Item)lvwItems.Items[e.Item].Tag).Name = e.Label;
            _isDirty = true;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !SaveChangesAndContinue();
        }

        private void lvwItems_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:
                    if (lvwItems.SelectedItems.Count > 0)
                        lvwItems.SelectedItems[0].BeginEdit();
                    break;

                case Keys.Return:
                    if (mnuItemEdit.Enabled)
                        mnuItemEdit.PerformClick();
                    break;

                case Keys.Delete:
                    if (mnuItemDelete.Enabled)
                        mnuItemDelete.PerformClick();
                    break;
            }
        }

        private void lvwItems_ItemDrag(object sender, ItemDragEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                DoDragDrop(e.Item, DragDropEffects.Move);
        }
    }
}
