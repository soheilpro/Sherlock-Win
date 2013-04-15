using System;

namespace Sherlock {
    partial class frmMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFolderAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFolderRename = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFolderDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemCopyStripped = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemCopyPart = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuToolsRegisterShellExtensions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuToolsRepairDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tlbMain = new System.Windows.Forms.ToolStrip();
            this.tbbOpen = new System.Windows.Forms.ToolStripButton();
            this.tbbSave = new System.Windows.Forms.ToolStripButton();
            this.tbbSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbbFolderAdd = new System.Windows.Forms.ToolStripButton();
            this.tbbFolderRename = new System.Windows.Forms.ToolStripButton();
            this.tbbFolderDelete = new System.Windows.Forms.ToolStripButton();
            this.tbbSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbbItemAdd = new System.Windows.Forms.ToolStripButton();
            this.tbbItemEdit = new System.Windows.Forms.ToolStripButton();
            this.tbbItemDelete = new System.Windows.Forms.ToolStripButton();
            this.tbbSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tbbItemCopy = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbbItemOpen = new System.Windows.Forms.ToolStripButton();
            this.staMain = new System.Windows.Forms.StatusStrip();
            this.stpFolder = new System.Windows.Forms.ToolStripStatusLabel();
            this.splMain = new System.Windows.Forms.SplitContainer();
            this.tvwFolders = new System.Windows.Forms.TreeView();
            this.cmsFolder = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsFolderAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsFolderRename = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsFolderDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.ilsMain = new System.Windows.Forms.ImageList(this.components);
            this.lvwItems = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsItem = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsItemSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsItemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsItemCopyStripped = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsItemCopyPart = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsItemSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain.SuspendLayout();
            this.tlbMain.SuspendLayout();
            this.staMain.SuspendLayout();
            this.splMain.Panel1.SuspendLayout();
            this.splMain.Panel2.SuspendLayout();
            this.splMain.SuspendLayout();
            this.cmsFolder.SuspendLayout();
            this.cmsItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuFolder,
            this.mnuItem,
            this.mnuTools,
            this.mnuHelp});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(682, 24);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "Menu";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileNew,
            this.mnuFileOpen,
            this.mnuFileSeparator1,
            this.mnuFileSave,
            this.mnuFileSaveAs,
            this.mnuFileSeparator2,
            this.mnuFileChangePassword,
            this.mnuFileSeparator3,
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuFileNew
            // 
            this.mnuFileNew.Name = "mnuFileNew";
            this.mnuFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuFileNew.Size = new System.Drawing.Size(168, 22);
            this.mnuFileNew.Text = "&New";
            this.mnuFileNew.Click += new System.EventHandler(this.mnuFileNew_Click);
            // 
            // mnuFileOpen
            // 
            this.mnuFileOpen.Image = global::Sherlock.Properties.Resources.Open;
            this.mnuFileOpen.Name = "mnuFileOpen";
            this.mnuFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuFileOpen.Size = new System.Drawing.Size(168, 22);
            this.mnuFileOpen.Text = "&Open";
            this.mnuFileOpen.Click += new System.EventHandler(this.mnuFileOpen_Click);
            // 
            // mnuFileSeparator1
            // 
            this.mnuFileSeparator1.Name = "mnuFileSeparator1";
            this.mnuFileSeparator1.Size = new System.Drawing.Size(165, 6);
            // 
            // mnuFileSave
            // 
            this.mnuFileSave.Image = global::Sherlock.Properties.Resources.Save;
            this.mnuFileSave.Name = "mnuFileSave";
            this.mnuFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuFileSave.Size = new System.Drawing.Size(168, 22);
            this.mnuFileSave.Text = "&Save";
            this.mnuFileSave.Click += new System.EventHandler(this.mnuFileSave_Click);
            // 
            // mnuFileSaveAs
            // 
            this.mnuFileSaveAs.Name = "mnuFileSaveAs";
            this.mnuFileSaveAs.Size = new System.Drawing.Size(168, 22);
            this.mnuFileSaveAs.Text = "Save &As";
            this.mnuFileSaveAs.Click += new System.EventHandler(this.mnuFileSaveAs_Click);
            // 
            // mnuFileSeparator2
            // 
            this.mnuFileSeparator2.Name = "mnuFileSeparator2";
            this.mnuFileSeparator2.Size = new System.Drawing.Size(165, 6);
            // 
            // mnuFileChangePassword
            // 
            this.mnuFileChangePassword.Name = "mnuFileChangePassword";
            this.mnuFileChangePassword.Size = new System.Drawing.Size(168, 22);
            this.mnuFileChangePassword.Text = "Change Password";
            this.mnuFileChangePassword.Click += new System.EventHandler(this.mnuFileChangePassword_Click);
            // 
            // mnuFileSeparator3
            // 
            this.mnuFileSeparator3.Name = "mnuFileSeparator3";
            this.mnuFileSeparator3.Size = new System.Drawing.Size(165, 6);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(168, 22);
            this.mnuFileExit.Text = "E&xit";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // mnuFolder
            // 
            this.mnuFolder.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFolderAdd,
            this.mnuFolderRename,
            this.mnuFolderDelete});
            this.mnuFolder.Name = "mnuFolder";
            this.mnuFolder.Size = new System.Drawing.Size(67, 20);
            this.mnuFolder.Text = "Folder";
            // 
            // mnuFolderAdd
            // 
            this.mnuFolderAdd.Image = global::Sherlock.Properties.Resources.FolderAdd;
            this.mnuFolderAdd.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.mnuFolderAdd.Name = "mnuFolderAdd";
            this.mnuFolderAdd.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.mnuFolderAdd.Size = new System.Drawing.Size(170, 22);
            this.mnuFolderAdd.Text = "&Add";
            this.mnuFolderAdd.Click += new System.EventHandler(this.mnuFolderAdd_Click);
            // 
            // mnuFolderRename
            // 
            this.mnuFolderRename.Image = global::Sherlock.Properties.Resources.FolderRename;
            this.mnuFolderRename.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.mnuFolderRename.Name = "mnuFolderRename";
            this.mnuFolderRename.ShortcutKeyDisplayString = "F2";
            this.mnuFolderRename.Size = new System.Drawing.Size(170, 22);
            this.mnuFolderRename.Text = "&Rename";
            this.mnuFolderRename.Click += new System.EventHandler(this.mnuFolderRename_Click);
            // 
            // mnuFolderDelete
            // 
            this.mnuFolderDelete.Image = global::Sherlock.Properties.Resources.FolderDelete;
            this.mnuFolderDelete.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.mnuFolderDelete.Name = "mnuFolderDelete";
            this.mnuFolderDelete.ShortcutKeyDisplayString = "Del";
            this.mnuFolderDelete.Size = new System.Drawing.Size(170, 22);
            this.mnuFolderDelete.Text = "&Delete";
            this.mnuFolderDelete.Click += new System.EventHandler(this.mnuFolderDelete_Click);
            // 
            // mnuItem
            // 
            this.mnuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemAdd,
            this.mnuItemEdit,
            this.mnuItemDelete,
            this.menuItemSeparator1,
            this.mnuItemCopy,
            this.mnuItemCopyStripped,
            this.mnuItemCopyPart,
            this.menuItemSeparator2,
            this.mnuItemOpen});
            this.mnuItem.Name = "mnuItem";
            this.mnuItem.Size = new System.Drawing.Size(43, 20);
            this.mnuItem.Text = "&Item";
            // 
            // mnuItemAdd
            // 
            this.mnuItemAdd.Image = global::Sherlock.Properties.Resources.ItemAdd;
            this.mnuItemAdd.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.mnuItemAdd.Name = "mnuItemAdd";
            this.mnuItemAdd.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.mnuItemAdd.Size = new System.Drawing.Size(149, 22);
            this.mnuItemAdd.Text = "&Add";
            this.mnuItemAdd.Click += new System.EventHandler(this.mnuItemAdd_Click);
            // 
            // mnuItemEdit
            // 
            this.mnuItemEdit.Image = global::Sherlock.Properties.Resources.ItemEdit;
            this.mnuItemEdit.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.mnuItemEdit.Name = "mnuItemEdit";
            this.mnuItemEdit.ShortcutKeyDisplayString = "Enter";
            this.mnuItemEdit.Size = new System.Drawing.Size(149, 22);
            this.mnuItemEdit.Text = "&Edit";
            this.mnuItemEdit.Click += new System.EventHandler(this.mnuItemEdit_Click);
            // 
            // mnuItemDelete
            // 
            this.mnuItemDelete.Image = global::Sherlock.Properties.Resources.ItemDelete;
            this.mnuItemDelete.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.mnuItemDelete.Name = "mnuItemDelete";
            this.mnuItemDelete.ShortcutKeyDisplayString = "Del";
            this.mnuItemDelete.Size = new System.Drawing.Size(149, 22);
            this.mnuItemDelete.Text = "&Delete";
            this.mnuItemDelete.Click += new System.EventHandler(this.mnuItemDelete_Click);
            // 
            // menuItemSeparator1
            // 
            this.menuItemSeparator1.Name = "menuItemSeparator1";
            this.menuItemSeparator1.Size = new System.Drawing.Size(146, 6);
            // 
            // mnuItemCopy
            // 
            this.mnuItemCopy.Image = global::Sherlock.Properties.Resources.Copy;
            this.mnuItemCopy.Name = "mnuItemCopy";
            this.mnuItemCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mnuItemCopy.Size = new System.Drawing.Size(149, 22);
            this.mnuItemCopy.Text = "&Copy";
            this.mnuItemCopy.Click += new System.EventHandler(this.mnuItemCopy_Click);
            // 
            // mnuItemCopyStripped
            // 
            this.mnuItemCopyStripped.Name = "mnuItemCopyStripped";
            this.mnuItemCopyStripped.Size = new System.Drawing.Size(149, 22);
            this.mnuItemCopyStripped.Text = "Copy Stripped";
            this.mnuItemCopyStripped.Click += new System.EventHandler(this.mnuItemCopyStripped_Click);
            // 
            // mnuItemCopyPart
            // 
            this.mnuItemCopyPart.Name = "mnuItemCopyPart";
            this.mnuItemCopyPart.Size = new System.Drawing.Size(149, 22);
            this.mnuItemCopyPart.Text = "Copy Part";
            // 
            // menuItemSeparator2
            // 
            this.menuItemSeparator2.Name = "menuItemSeparator2";
            this.menuItemSeparator2.Size = new System.Drawing.Size(146, 6);
            // 
            // mnuItemOpen
            // 
            this.mnuItemOpen.Image = global::Sherlock.Properties.Resources.Link;
            this.mnuItemOpen.Name = "mnuItemOpen";
            this.mnuItemOpen.Size = new System.Drawing.Size(149, 22);
            this.mnuItemOpen.Text = "Open";
            this.mnuItemOpen.Click += new System.EventHandler(this.mnuItemOpen_Click);
            // 
            // mnuTools
            // 
            this.mnuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuToolsRegisterShellExtensions,
            this.mnuToolsRepairDatabase});
            this.mnuTools.Name = "mnuTools";
            this.mnuTools.Size = new System.Drawing.Size(48, 20);
            this.mnuTools.Text = "&Tools";
            // 
            // mnuToolsRegisterShellExtensions
            // 
            this.mnuToolsRegisterShellExtensions.Name = "mnuToolsRegisterShellExtensions";
            this.mnuToolsRegisterShellExtensions.Size = new System.Drawing.Size(202, 22);
            this.mnuToolsRegisterShellExtensions.Text = "Register Shell Extensions";
            this.mnuToolsRegisterShellExtensions.Click += new System.EventHandler(this.mnuToolsRegisterShellExtensions_Click);
            // 
            // mnuToolsRepairDatabase
            // 
            this.mnuToolsRepairDatabase.Name = "mnuToolsRepairDatabase";
            this.mnuToolsRepairDatabase.Size = new System.Drawing.Size(202, 22);
            this.mnuToolsRepairDatabase.Text = "Repair Database";
            this.mnuToolsRepairDatabase.Click += new System.EventHandler(this.mnuToolsRepairDatabase_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelpAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuHelp.Text = "&Help";
            // 
            // mnuHelpAbout
            // 
            this.mnuHelpAbout.Name = "mnuHelpAbout";
            this.mnuHelpAbout.Size = new System.Drawing.Size(107, 22);
            this.mnuHelpAbout.Text = "&About";
            this.mnuHelpAbout.Click += new System.EventHandler(this.mnuHelpAbout_Click);
            // 
            // tlbMain
            // 
            this.tlbMain.AutoSize = false;
            this.tlbMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbbOpen,
            this.tbbSave,
            this.tbbSeparator1,
            this.tbbFolderAdd,
            this.tbbFolderRename,
            this.tbbFolderDelete,
            this.tbbSeparator2,
            this.tbbItemAdd,
            this.tbbItemEdit,
            this.tbbItemDelete,
            this.tbbSeparator3,
            this.tbbItemCopy,
            this.toolStripSeparator1,
            this.tbbItemOpen});
            this.tlbMain.Location = new System.Drawing.Point(0, 24);
            this.tlbMain.Name = "tlbMain";
            this.tlbMain.Size = new System.Drawing.Size(682, 40);
            this.tlbMain.TabIndex = 1;
            this.tlbMain.Text = "Standard";
            // 
            // tbbOpen
            // 
            this.tbbOpen.AutoSize = false;
            this.tbbOpen.Image = global::Sherlock.Properties.Resources.Open;
            this.tbbOpen.Name = "tbbOpen";
            this.tbbOpen.Size = new System.Drawing.Size(40, 36);
            this.tbbOpen.Text = "Open";
            this.tbbOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbbOpen.Click += new System.EventHandler(this.mnuFileOpen_Click);
            // 
            // tbbSave
            // 
            this.tbbSave.AutoSize = false;
            this.tbbSave.Image = global::Sherlock.Properties.Resources.Save;
            this.tbbSave.Name = "tbbSave";
            this.tbbSave.Size = new System.Drawing.Size(40, 36);
            this.tbbSave.Text = "Save";
            this.tbbSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbbSave.Click += new System.EventHandler(this.mnuFileSave_Click);
            // 
            // tbbSeparator1
            // 
            this.tbbSeparator1.Name = "tbbSeparator1";
            this.tbbSeparator1.Size = new System.Drawing.Size(6, 40);
            // 
            // tbbFolderAdd
            // 
            this.tbbFolderAdd.AutoSize = false;
            this.tbbFolderAdd.Image = global::Sherlock.Properties.Resources.FolderAdd;
            this.tbbFolderAdd.Name = "tbbFolderAdd";
            this.tbbFolderAdd.Size = new System.Drawing.Size(40, 36);
            this.tbbFolderAdd.Text = "Add";
            this.tbbFolderAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbbFolderAdd.Click += new System.EventHandler(this.mnuFolderAdd_Click);
            // 
            // tbbFolderRename
            // 
            this.tbbFolderRename.Image = global::Sherlock.Properties.Resources.FolderRename;
            this.tbbFolderRename.Name = "tbbFolderRename";
            this.tbbFolderRename.Size = new System.Drawing.Size(54, 37);
            this.tbbFolderRename.Text = "Rename";
            this.tbbFolderRename.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbbFolderRename.Click += new System.EventHandler(this.mnuFolderRename_Click);
            // 
            // tbbFolderDelete
            // 
            this.tbbFolderDelete.Image = global::Sherlock.Properties.Resources.FolderDelete;
            this.tbbFolderDelete.Name = "tbbFolderDelete";
            this.tbbFolderDelete.Size = new System.Drawing.Size(44, 37);
            this.tbbFolderDelete.Text = "Delete";
            this.tbbFolderDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbbFolderDelete.Click += new System.EventHandler(this.mnuFolderDelete_Click);
            // 
            // tbbSeparator2
            // 
            this.tbbSeparator2.Name = "tbbSeparator2";
            this.tbbSeparator2.Size = new System.Drawing.Size(6, 40);
            // 
            // tbbItemAdd
            // 
            this.tbbItemAdd.AutoSize = false;
            this.tbbItemAdd.Image = global::Sherlock.Properties.Resources.ItemAdd;
            this.tbbItemAdd.Name = "tbbItemAdd";
            this.tbbItemAdd.Size = new System.Drawing.Size(40, 36);
            this.tbbItemAdd.Text = "Add";
            this.tbbItemAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbbItemAdd.Click += new System.EventHandler(this.mnuItemAdd_Click);
            // 
            // tbbItemEdit
            // 
            this.tbbItemEdit.AutoSize = false;
            this.tbbItemEdit.Image = global::Sherlock.Properties.Resources.ItemEdit;
            this.tbbItemEdit.Name = "tbbItemEdit";
            this.tbbItemEdit.Size = new System.Drawing.Size(40, 36);
            this.tbbItemEdit.Text = "Edit";
            this.tbbItemEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbbItemEdit.Click += new System.EventHandler(this.mnuItemEdit_Click);
            // 
            // tbbItemDelete
            // 
            this.tbbItemDelete.Image = global::Sherlock.Properties.Resources.ItemDelete;
            this.tbbItemDelete.Name = "tbbItemDelete";
            this.tbbItemDelete.Size = new System.Drawing.Size(44, 37);
            this.tbbItemDelete.Text = "Delete";
            this.tbbItemDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbbItemDelete.Click += new System.EventHandler(this.mnuItemDelete_Click);
            // 
            // tbbSeparator3
            // 
            this.tbbSeparator3.Name = "tbbSeparator3";
            this.tbbSeparator3.Size = new System.Drawing.Size(6, 40);
            // 
            // tbbItemCopy
            // 
            this.tbbItemCopy.AutoSize = false;
            this.tbbItemCopy.Image = global::Sherlock.Properties.Resources.Copy;
            this.tbbItemCopy.Name = "tbbItemCopy";
            this.tbbItemCopy.Size = new System.Drawing.Size(40, 36);
            this.tbbItemCopy.Text = "Copy";
            this.tbbItemCopy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbbItemCopy.Click += new System.EventHandler(this.mnuItemCopy_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 40);
            // 
            // tbbItemOpen
            // 
            this.tbbItemOpen.Image = global::Sherlock.Properties.Resources.Link;
            this.tbbItemOpen.Name = "tbbItemOpen";
            this.tbbItemOpen.Size = new System.Drawing.Size(40, 37);
            this.tbbItemOpen.Text = "Open";
            this.tbbItemOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbbItemOpen.Click += new System.EventHandler(this.mnuItemOpen_Click);
            // 
            // staMain
            // 
            this.staMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stpFolder});
            this.staMain.Location = new System.Drawing.Point(0, 436);
            this.staMain.Name = "staMain";
            this.staMain.Size = new System.Drawing.Size(682, 22);
            this.staMain.TabIndex = 2;
            this.staMain.Text = "statusStrip1";
            // 
            // stpFolder
            // 
            this.stpFolder.Name = "stpFolder";
            this.stpFolder.Size = new System.Drawing.Size(0, 17);
            // 
            // splMain
            // 
            this.splMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splMain.Location = new System.Drawing.Point(2, 68);
            this.splMain.Name = "splMain";
            // 
            // splMain.Panel1
            // 
            this.splMain.Panel1.Controls.Add(this.tvwFolders);
            // 
            // splMain.Panel2
            // 
            this.splMain.Panel2.Controls.Add(this.lvwItems);
            this.splMain.Size = new System.Drawing.Size(678, 363);
            this.splMain.SplitterDistance = 207;
            this.splMain.SplitterWidth = 3;
            this.splMain.TabIndex = 3;
            // 
            // tvwFolders
            // 
            this.tvwFolders.AllowDrop = true;
            this.tvwFolders.ContextMenuStrip = this.cmsFolder;
            this.tvwFolders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvwFolders.HideSelection = false;
            this.tvwFolders.ImageIndex = 0;
            this.tvwFolders.ImageList = this.ilsMain;
            this.tvwFolders.LabelEdit = true;
            this.tvwFolders.Location = new System.Drawing.Point(0, 0);
            this.tvwFolders.Name = "tvwFolders";
            this.tvwFolders.SelectedImageIndex = 1;
            this.tvwFolders.Size = new System.Drawing.Size(207, 363);
            this.tvwFolders.TabIndex = 0;
            this.tvwFolders.BeforeLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.tvwCategories_BeforeLabelEdit);
            this.tvwFolders.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.tvwCategories_AfterLabelEdit);
            this.tvwFolders.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.tvwCategories_ItemDrag);
            this.tvwFolders.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwCategories_AfterSelect);
            this.tvwFolders.DragDrop += new System.Windows.Forms.DragEventHandler(this.tvwCategories_DragDrop);
            this.tvwFolders.DragOver += new System.Windows.Forms.DragEventHandler(this.tvwCategories_DragOver);
            this.tvwFolders.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tvwCategories_KeyDown);
            // 
            // cmsFolder
            // 
            this.cmsFolder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsFolderAdd,
            this.cmsFolderRename,
            this.cmsFolderDelete});
            this.cmsFolder.Name = "cmsFolder";
            this.cmsFolder.Size = new System.Drawing.Size(171, 70);
            // 
            // cmsFolderAdd
            // 
            this.cmsFolderAdd.Image = global::Sherlock.Properties.Resources.FolderAdd;
            this.cmsFolderAdd.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.cmsFolderAdd.Name = "cmsFolderAdd";
            this.cmsFolderAdd.ShortcutKeyDisplayString = "Ctrl+Shift+A";
            this.cmsFolderAdd.Size = new System.Drawing.Size(170, 22);
            this.cmsFolderAdd.Text = "Add";
            this.cmsFolderAdd.Click += new System.EventHandler(this.mnuFolderAdd_Click);
            // 
            // cmsFolderRename
            // 
            this.cmsFolderRename.Image = global::Sherlock.Properties.Resources.FolderRename;
            this.cmsFolderRename.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.cmsFolderRename.Name = "cmsFolderRename";
            this.cmsFolderRename.ShortcutKeyDisplayString = "F2";
            this.cmsFolderRename.Size = new System.Drawing.Size(170, 22);
            this.cmsFolderRename.Text = "Rename";
            this.cmsFolderRename.Click += new System.EventHandler(this.mnuFolderRename_Click);
            // 
            // cmsFolderDelete
            // 
            this.cmsFolderDelete.Image = global::Sherlock.Properties.Resources.FolderDelete;
            this.cmsFolderDelete.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.cmsFolderDelete.Name = "cmsFolderDelete";
            this.cmsFolderDelete.ShortcutKeyDisplayString = "Del";
            this.cmsFolderDelete.Size = new System.Drawing.Size(170, 22);
            this.cmsFolderDelete.Text = "Delete";
            this.cmsFolderDelete.Click += new System.EventHandler(this.mnuFolderDelete_Click);
            // 
            // ilsMain
            // 
            this.ilsMain.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilsMain.ImageStream")));
            this.ilsMain.TransparentColor = System.Drawing.Color.Empty;
            this.ilsMain.Images.SetKeyName(0, "");
            this.ilsMain.Images.SetKeyName(1, "");
            this.ilsMain.Images.SetKeyName(2, "");
            // 
            // lvwItems
            // 
            this.lvwItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chValue});
            this.lvwItems.ContextMenuStrip = this.cmsItem;
            this.lvwItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwItems.FullRowSelect = true;
            this.lvwItems.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwItems.LabelEdit = true;
            this.lvwItems.Location = new System.Drawing.Point(0, 0);
            this.lvwItems.MultiSelect = false;
            this.lvwItems.Name = "lvwItems";
            this.lvwItems.Size = new System.Drawing.Size(468, 363);
            this.lvwItems.SmallImageList = this.ilsMain;
            this.lvwItems.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvwItems.TabIndex = 0;
            this.lvwItems.UseCompatibleStateImageBehavior = false;
            this.lvwItems.View = System.Windows.Forms.View.Details;
            this.lvwItems.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.lvwItems_AfterLabelEdit);
            this.lvwItems.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lvwItems_ItemDrag);
            this.lvwItems.SelectedIndexChanged += new System.EventHandler(this.lvwItems_SelectedIndexChanged);
            this.lvwItems.DoubleClick += new System.EventHandler(this.mnuItemEdit_Click);
            this.lvwItems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvwItems_KeyDown);
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 169;
            // 
            // chValue
            // 
            this.chValue.Text = "Value";
            this.chValue.Width = 229;
            // 
            // cmsItem
            // 
            this.cmsItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsItemAdd,
            this.cmsItemEdit,
            this.cmsItemDelete,
            this.cmsItemSeparator1,
            this.cmsItemCopy,
            this.cmsItemCopyStripped,
            this.cmsItemCopyPart,
            this.cmsItemSeparator2,
            this.cmsItemOpen});
            this.cmsItem.Name = "cmsItem";
            this.cmsItem.Size = new System.Drawing.Size(143, 170);
            // 
            // cmsItemAdd
            // 
            this.cmsItemAdd.Image = global::Sherlock.Properties.Resources.ItemAdd;
            this.cmsItemAdd.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.cmsItemAdd.Name = "cmsItemAdd";
            this.cmsItemAdd.ShortcutKeyDisplayString = "Ctrl+A";
            this.cmsItemAdd.Size = new System.Drawing.Size(142, 22);
            this.cmsItemAdd.Text = "&Add";
            this.cmsItemAdd.Click += new System.EventHandler(this.mnuItemAdd_Click);
            // 
            // cmsItemEdit
            // 
            this.cmsItemEdit.Image = global::Sherlock.Properties.Resources.ItemEdit;
            this.cmsItemEdit.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.cmsItemEdit.Name = "cmsItemEdit";
            this.cmsItemEdit.ShortcutKeyDisplayString = "Enter";
            this.cmsItemEdit.Size = new System.Drawing.Size(142, 22);
            this.cmsItemEdit.Text = "&Edit";
            this.cmsItemEdit.Click += new System.EventHandler(this.mnuItemEdit_Click);
            // 
            // cmsItemDelete
            // 
            this.cmsItemDelete.Image = global::Sherlock.Properties.Resources.ItemDelete;
            this.cmsItemDelete.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.cmsItemDelete.Name = "cmsItemDelete";
            this.cmsItemDelete.ShortcutKeyDisplayString = "Del";
            this.cmsItemDelete.Size = new System.Drawing.Size(142, 22);
            this.cmsItemDelete.Text = "&Delete";
            this.cmsItemDelete.Click += new System.EventHandler(this.mnuItemDelete_Click);
            // 
            // cmsItemSeparator1
            // 
            this.cmsItemSeparator1.Name = "cmsItemSeparator1";
            this.cmsItemSeparator1.Size = new System.Drawing.Size(139, 6);
            // 
            // cmsItemCopy
            // 
            this.cmsItemCopy.Image = global::Sherlock.Properties.Resources.Copy;
            this.cmsItemCopy.Name = "cmsItemCopy";
            this.cmsItemCopy.ShortcutKeyDisplayString = "Ctrl+C";
            this.cmsItemCopy.Size = new System.Drawing.Size(142, 22);
            this.cmsItemCopy.Text = "&Copy";
            this.cmsItemCopy.Click += new System.EventHandler(this.mnuItemCopy_Click);
            // 
            // cmsItemCopyStripped
            // 
            this.cmsItemCopyStripped.Name = "cmsItemCopyStripped";
            this.cmsItemCopyStripped.Size = new System.Drawing.Size(142, 22);
            this.cmsItemCopyStripped.Text = "Copy Stripped";
            this.cmsItemCopyStripped.Click += new System.EventHandler(this.mnuItemCopyStripped_Click);
            // 
            // cmsItemCopyPart
            // 
            this.cmsItemCopyPart.Name = "cmsItemCopyPart";
            this.cmsItemCopyPart.Size = new System.Drawing.Size(142, 22);
            this.cmsItemCopyPart.Text = "Copy Part";
            // 
            // cmsItemSeparator2
            // 
            this.cmsItemSeparator2.Name = "cmsItemSeparator2";
            this.cmsItemSeparator2.Size = new System.Drawing.Size(139, 6);
            // 
            // cmsItemOpen
            // 
            this.cmsItemOpen.Image = global::Sherlock.Properties.Resources.Link;
            this.cmsItemOpen.Name = "cmsItemOpen";
            this.cmsItemOpen.Size = new System.Drawing.Size(142, 22);
            this.cmsItemOpen.Text = "&Open";
            this.cmsItemOpen.Click += new System.EventHandler(this.mnuItemOpen_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 458);
            this.Controls.Add(this.splMain);
            this.Controls.Add(this.staMain);
            this.Controls.Add(this.tlbMain);
            this.Controls.Add(this.mnuMain);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMain;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sherlock";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.tlbMain.ResumeLayout(false);
            this.tlbMain.PerformLayout();
            this.staMain.ResumeLayout(false);
            this.staMain.PerformLayout();
            this.splMain.Panel1.ResumeLayout(false);
            this.splMain.Panel2.ResumeLayout(false);
            this.splMain.ResumeLayout(false);
            this.cmsFolder.ResumeLayout(false);
            this.cmsItem.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileNew;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpen;
        private System.Windows.Forms.ToolStripSeparator mnuFileSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSave;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSaveAs;
        private System.Windows.Forms.ToolStripSeparator mnuFileSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuHelpAbout;
        private System.Windows.Forms.ToolStrip tlbMain;
        private System.Windows.Forms.ToolStripButton tbbOpen;
        private System.Windows.Forms.ToolStripButton tbbSave;
        private System.Windows.Forms.ToolStripSeparator tbbSeparator1;
        private System.Windows.Forms.ToolStripButton tbbItemCopy;
        private System.Windows.Forms.ToolStripButton tbbFolderAdd;
        private System.Windows.Forms.StatusStrip staMain;
        private System.Windows.Forms.SplitContainer splMain;
        private System.Windows.Forms.TreeView tvwFolders;
        private System.Windows.Forms.ListView lvwItems;
        private System.Windows.Forms.ToolStripButton tbbFolderDelete;
        private System.Windows.Forms.ToolStripButton tbbFolderRename;
        private System.Windows.Forms.ToolStripMenuItem mnuFolder;
        private System.Windows.Forms.ToolStripMenuItem mnuFolderAdd;
        private System.Windows.Forms.ToolStripMenuItem mnuFolderRename;
        private System.Windows.Forms.ToolStripMenuItem mnuFolderDelete;
        private System.Windows.Forms.ToolStripMenuItem mnuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuItemAdd;
        private System.Windows.Forms.ToolStripMenuItem mnuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuItemDelete;
        private System.Windows.Forms.ToolStripButton tbbItemAdd;
        private System.Windows.Forms.ToolStripButton tbbItemEdit;
        private System.Windows.Forms.ToolStripButton tbbItemDelete;
        private System.Windows.Forms.ImageList ilsMain;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chValue;
        private System.Windows.Forms.ToolStripSeparator menuItemSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuItemCopy;
        private System.Windows.Forms.ToolStripSeparator tbbSeparator2;
        private System.Windows.Forms.ToolStripSeparator tbbSeparator3;
        private System.Windows.Forms.ToolStripStatusLabel stpFolder;
        private System.Windows.Forms.ToolStripMenuItem mnuFileChangePassword;
        private System.Windows.Forms.ToolStripSeparator mnuFileSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mnuItemCopyStripped;
        private System.Windows.Forms.ContextMenuStrip cmsItem;
        private System.Windows.Forms.ToolStripMenuItem cmsItemAdd;
        private System.Windows.Forms.ToolStripMenuItem cmsItemEdit;
        private System.Windows.Forms.ToolStripMenuItem cmsItemDelete;
        private System.Windows.Forms.ToolStripSeparator cmsItemSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cmsItemCopy;
        private System.Windows.Forms.ToolStripMenuItem cmsItemCopyStripped;
        private System.Windows.Forms.ToolStripMenuItem mnuItemOpen;
        private System.Windows.Forms.ToolStripButton tbbItemOpen;
        private System.Windows.Forms.ToolStripMenuItem cmsItemOpen;
        private System.Windows.Forms.ContextMenuStrip cmsFolder;
        private System.Windows.Forms.ToolStripMenuItem cmsFolderAdd;
        private System.Windows.Forms.ToolStripMenuItem cmsFolderRename;
        private System.Windows.Forms.ToolStripMenuItem cmsFolderDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator menuItemSeparator2;
        private System.Windows.Forms.ToolStripSeparator cmsItemSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuTools;
        private System.Windows.Forms.ToolStripMenuItem mnuToolsRegisterShellExtensions;
        private System.Windows.Forms.ToolStripMenuItem mnuToolsRepairDatabase;
        private System.Windows.Forms.ToolStripMenuItem cmsItemCopyPart;
        private System.Windows.Forms.ToolStripMenuItem mnuItemCopyPart;
    }
}

