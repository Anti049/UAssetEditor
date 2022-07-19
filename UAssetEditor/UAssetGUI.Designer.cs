namespace UAssetEditor
{
    partial class UAssetGUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFileExport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileExportJSON = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileExportXML = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileExportCSV = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileExportPlaintext = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileImport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileImportJSON = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileImportXML = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileImportCSV = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileImportPlaintext = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuEditFind = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditReplace = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditFindAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditReplaceAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.menuEditDuplicateAsset = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.menuEditExportSub = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditImportSub = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator();
            this.menuEditPreferences = new System.Windows.Forms.ToolStripMenuItem();
            this.menuView = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewExpandAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewCollapseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewExpandSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewCollapseSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFunctions = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFunctionsPackageFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFunctionsExtractPak = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControlAssets = new System.Windows.Forms.TabControl();
            this.contextMenuStripAssets = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextTabsOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.contextTabsShowExplorer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStripAssets.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuEdit,
            this.menuView,
            this.menuFunctions,
            this.menuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1166, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileOpen,
            this.menuFileSave,
            this.menuFileSaveAs,
            this.toolStripMenuItem1,
            this.menuFileExport,
            this.menuFileImport,
            this.toolStripMenuItem7,
            this.menuFileExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "&File";
            // 
            // menuFileOpen
            // 
            this.menuFileOpen.Name = "menuFileOpen";
            this.menuFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuFileOpen.Size = new System.Drawing.Size(186, 22);
            this.menuFileOpen.Text = "Open";
            this.menuFileOpen.Click += new System.EventHandler(this.menuFileOpen_Click);
            // 
            // menuFileSave
            // 
            this.menuFileSave.Name = "menuFileSave";
            this.menuFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuFileSave.Size = new System.Drawing.Size(186, 22);
            this.menuFileSave.Text = "Save";
            this.menuFileSave.Click += new System.EventHandler(this.menuFileSave_Click);
            // 
            // menuFileSaveAs
            // 
            this.menuFileSaveAs.Name = "menuFileSaveAs";
            this.menuFileSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.menuFileSaveAs.Size = new System.Drawing.Size(186, 22);
            this.menuFileSaveAs.Text = "Save As";
            this.menuFileSaveAs.Click += new System.EventHandler(this.menuFileSaveAs_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(183, 6);
            // 
            // menuFileExport
            // 
            this.menuFileExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileExportJSON,
            this.menuFileExportXML,
            this.menuFileExportCSV,
            this.menuFileExportPlaintext});
            this.menuFileExport.Name = "menuFileExport";
            this.menuFileExport.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.menuFileExport.Size = new System.Drawing.Size(186, 22);
            this.menuFileExport.Text = "Export";
            // 
            // menuFileExportJSON
            // 
            this.menuFileExportJSON.Name = "menuFileExportJSON";
            this.menuFileExportJSON.Size = new System.Drawing.Size(120, 22);
            this.menuFileExportJSON.Text = "JSON";
            this.menuFileExportJSON.Click += new System.EventHandler(this.menuFileExport_Click);
            // 
            // menuFileExportXML
            // 
            this.menuFileExportXML.Name = "menuFileExportXML";
            this.menuFileExportXML.Size = new System.Drawing.Size(120, 22);
            this.menuFileExportXML.Text = "XML";
            this.menuFileExportXML.Click += new System.EventHandler(this.menuFileExport_Click);
            // 
            // menuFileExportCSV
            // 
            this.menuFileExportCSV.Name = "menuFileExportCSV";
            this.menuFileExportCSV.Size = new System.Drawing.Size(120, 22);
            this.menuFileExportCSV.Text = "CSV";
            // 
            // menuFileExportPlaintext
            // 
            this.menuFileExportPlaintext.Name = "menuFileExportPlaintext";
            this.menuFileExportPlaintext.Size = new System.Drawing.Size(120, 22);
            this.menuFileExportPlaintext.Text = "Plaintext";
            this.menuFileExportPlaintext.Click += new System.EventHandler(this.menuFileExport_Click);
            // 
            // menuFileImport
            // 
            this.menuFileImport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileImportJSON,
            this.menuFileImportXML,
            this.menuFileImportCSV,
            this.menuFileImportPlaintext});
            this.menuFileImport.Name = "menuFileImport";
            this.menuFileImport.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.menuFileImport.Size = new System.Drawing.Size(186, 22);
            this.menuFileImport.Text = "Import";
            this.menuFileImport.Click += new System.EventHandler(this.menuFileImport_Click);
            // 
            // menuFileImportJSON
            // 
            this.menuFileImportJSON.Name = "menuFileImportJSON";
            this.menuFileImportJSON.Size = new System.Drawing.Size(120, 22);
            this.menuFileImportJSON.Text = "JSON";
            this.menuFileImportJSON.Click += new System.EventHandler(this.menuFileImport_Click);
            // 
            // menuFileImportXML
            // 
            this.menuFileImportXML.Name = "menuFileImportXML";
            this.menuFileImportXML.Size = new System.Drawing.Size(120, 22);
            this.menuFileImportXML.Text = "XML";
            this.menuFileImportXML.Click += new System.EventHandler(this.menuFileImport_Click);
            // 
            // menuFileImportCSV
            // 
            this.menuFileImportCSV.Name = "menuFileImportCSV";
            this.menuFileImportCSV.Size = new System.Drawing.Size(120, 22);
            this.menuFileImportCSV.Text = "CSV";
            this.menuFileImportCSV.Click += new System.EventHandler(this.menuFileImport_Click);
            // 
            // menuFileImportPlaintext
            // 
            this.menuFileImportPlaintext.Name = "menuFileImportPlaintext";
            this.menuFileImportPlaintext.Size = new System.Drawing.Size(120, 22);
            this.menuFileImportPlaintext.Text = "Plaintext";
            this.menuFileImportPlaintext.Click += new System.EventHandler(this.menuFileImport_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(183, 6);
            // 
            // menuFileExit
            // 
            this.menuFileExit.Name = "menuFileExit";
            this.menuFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.menuFileExit.Size = new System.Drawing.Size(186, 22);
            this.menuFileExit.Text = "Exit";
            this.menuFileExit.Click += new System.EventHandler(this.menuFileExit_Click);
            // 
            // menuEdit
            // 
            this.menuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEditUndo,
            this.menuEditRedo,
            this.toolStripSeparator1,
            this.menuEditCopy,
            this.menuEditPaste,
            this.toolStripMenuItem2,
            this.menuEditFind,
            this.menuEditReplace,
            this.menuEditFindAll,
            this.menuEditReplaceAll,
            this.toolStripMenuItem5,
            this.menuEditDuplicateAsset,
            this.toolStripMenuItem6,
            this.menuEditExportSub,
            this.menuEditImportSub,
            this.toolStripMenuItem9,
            this.menuEditPreferences});
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.Size = new System.Drawing.Size(39, 20);
            this.menuEdit.Text = "&Edit";
            // 
            // menuEditUndo
            // 
            this.menuEditUndo.Name = "menuEditUndo";
            this.menuEditUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.menuEditUndo.Size = new System.Drawing.Size(207, 22);
            this.menuEditUndo.Text = "Undo";
            this.menuEditUndo.Click += new System.EventHandler(this.menuEditUndo_Click);
            // 
            // menuEditRedo
            // 
            this.menuEditRedo.Name = "menuEditRedo";
            this.menuEditRedo.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Z)));
            this.menuEditRedo.Size = new System.Drawing.Size(207, 22);
            this.menuEditRedo.Text = "Redo";
            this.menuEditRedo.Click += new System.EventHandler(this.menuEditRedo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(204, 6);
            // 
            // menuEditCopy
            // 
            this.menuEditCopy.Name = "menuEditCopy";
            this.menuEditCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.menuEditCopy.Size = new System.Drawing.Size(207, 22);
            this.menuEditCopy.Text = "Copy";
            this.menuEditCopy.Click += new System.EventHandler(this.menuEditCopy_Click);
            // 
            // menuEditPaste
            // 
            this.menuEditPaste.Name = "menuEditPaste";
            this.menuEditPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.menuEditPaste.Size = new System.Drawing.Size(207, 22);
            this.menuEditPaste.Text = "Paste";
            this.menuEditPaste.Click += new System.EventHandler(this.menuEditPaste_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(204, 6);
            // 
            // menuEditFind
            // 
            this.menuEditFind.Name = "menuEditFind";
            this.menuEditFind.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.menuEditFind.Size = new System.Drawing.Size(207, 22);
            this.menuEditFind.Text = "Find";
            this.menuEditFind.Click += new System.EventHandler(this.menuEditFind_Click);
            // 
            // menuEditReplace
            // 
            this.menuEditReplace.Name = "menuEditReplace";
            this.menuEditReplace.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.menuEditReplace.Size = new System.Drawing.Size(207, 22);
            this.menuEditReplace.Text = "Replace";
            this.menuEditReplace.Click += new System.EventHandler(this.menuEditReplace_Click);
            // 
            // menuEditFindAll
            // 
            this.menuEditFindAll.Name = "menuEditFindAll";
            this.menuEditFindAll.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F)));
            this.menuEditFindAll.Size = new System.Drawing.Size(207, 22);
            this.menuEditFindAll.Text = "Find All";
            this.menuEditFindAll.Click += new System.EventHandler(this.menuEditFindAll_Click);
            // 
            // menuEditReplaceAll
            // 
            this.menuEditReplaceAll.Name = "menuEditReplaceAll";
            this.menuEditReplaceAll.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.H)));
            this.menuEditReplaceAll.Size = new System.Drawing.Size(207, 22);
            this.menuEditReplaceAll.Text = "Replace All";
            this.menuEditReplaceAll.Click += new System.EventHandler(this.menuEditReplaceAll_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(204, 6);
            // 
            // menuEditDuplicateAsset
            // 
            this.menuEditDuplicateAsset.Name = "menuEditDuplicateAsset";
            this.menuEditDuplicateAsset.Size = new System.Drawing.Size(207, 22);
            this.menuEditDuplicateAsset.Text = "Duplicate Asset";
            this.menuEditDuplicateAsset.Click += new System.EventHandler(this.menuEditDuplicateAsset_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(204, 6);
            // 
            // menuEditExportSub
            // 
            this.menuEditExportSub.Name = "menuEditExportSub";
            this.menuEditExportSub.Size = new System.Drawing.Size(207, 22);
            this.menuEditExportSub.Text = "Export Sub";
            this.menuEditExportSub.Click += new System.EventHandler(this.menuEditExportSub_Click);
            // 
            // menuEditImportSub
            // 
            this.menuEditImportSub.Name = "menuEditImportSub";
            this.menuEditImportSub.Size = new System.Drawing.Size(207, 22);
            this.menuEditImportSub.Text = "Import Sub";
            this.menuEditImportSub.Click += new System.EventHandler(this.menuEditImportSub_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(204, 6);
            // 
            // menuEditPreferences
            // 
            this.menuEditPreferences.Name = "menuEditPreferences";
            this.menuEditPreferences.Size = new System.Drawing.Size(207, 22);
            this.menuEditPreferences.Text = "Preferences";
            this.menuEditPreferences.Click += new System.EventHandler(this.menuEditPreferences_Click);
            // 
            // menuView
            // 
            this.menuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuViewExpandAll,
            this.menuViewCollapseAll,
            this.menuViewExpandSelected,
            this.menuViewCollapseSelected});
            this.menuView.Name = "menuView";
            this.menuView.Size = new System.Drawing.Size(44, 20);
            this.menuView.Text = "&View";
            // 
            // menuViewExpandAll
            // 
            this.menuViewExpandAll.Name = "menuViewExpandAll";
            this.menuViewExpandAll.Size = new System.Drawing.Size(166, 22);
            this.menuViewExpandAll.Text = "Expand All";
            this.menuViewExpandAll.Click += new System.EventHandler(this.menuViewExpandAll_Click);
            // 
            // menuViewCollapseAll
            // 
            this.menuViewCollapseAll.Name = "menuViewCollapseAll";
            this.menuViewCollapseAll.Size = new System.Drawing.Size(166, 22);
            this.menuViewCollapseAll.Text = "Collapse All";
            this.menuViewCollapseAll.Click += new System.EventHandler(this.menuViewCollapseAll_Click);
            // 
            // menuViewExpandSelected
            // 
            this.menuViewExpandSelected.Name = "menuViewExpandSelected";
            this.menuViewExpandSelected.Size = new System.Drawing.Size(166, 22);
            this.menuViewExpandSelected.Text = "Expand Selected";
            this.menuViewExpandSelected.Click += new System.EventHandler(this.menuViewExpandSelected_Click);
            // 
            // menuViewCollapseSelected
            // 
            this.menuViewCollapseSelected.Name = "menuViewCollapseSelected";
            this.menuViewCollapseSelected.Size = new System.Drawing.Size(166, 22);
            this.menuViewCollapseSelected.Text = "Collapse Selected";
            this.menuViewCollapseSelected.Click += new System.EventHandler(this.menuViewCollapseSelected_Click);
            // 
            // menuFunctions
            // 
            this.menuFunctions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFunctionsPackageFolder,
            this.toolStripMenuItem8,
            this.menuFunctionsExtractPak});
            this.menuFunctions.Name = "menuFunctions";
            this.menuFunctions.Size = new System.Drawing.Size(71, 20);
            this.menuFunctions.Text = "&Functions";
            // 
            // menuFunctionsPackageFolder
            // 
            this.menuFunctionsPackageFolder.Name = "menuFunctionsPackageFolder";
            this.menuFunctionsPackageFolder.Size = new System.Drawing.Size(154, 22);
            this.menuFunctionsPackageFolder.Text = "Package Folder";
            this.menuFunctionsPackageFolder.Click += new System.EventHandler(this.menuFunctionsPackageFolder_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(151, 6);
            // 
            // menuFunctionsExtractPak
            // 
            this.menuFunctionsExtractPak.Name = "menuFunctionsExtractPak";
            this.menuFunctionsExtractPak.Size = new System.Drawing.Size(154, 22);
            this.menuFunctionsExtractPak.Text = "Extract Pak";
            this.menuFunctionsExtractPak.Click += new System.EventHandler(this.menuFunctionsExtractPak_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHelpAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(44, 20);
            this.menuHelp.Text = "&Help";
            // 
            // menuHelpAbout
            // 
            this.menuHelpAbout.Name = "menuHelpAbout";
            this.menuHelpAbout.Size = new System.Drawing.Size(107, 22);
            this.menuHelpAbout.Text = "About";
            this.menuHelpAbout.Click += new System.EventHandler(this.menuHelpAbout_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 677);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(1166, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // tabControlAssets
            // 
            this.tabControlAssets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAssets.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControlAssets.Location = new System.Drawing.Point(0, 24);
            this.tabControlAssets.Name = "tabControlAssets";
            this.tabControlAssets.Padding = new System.Drawing.Point(20, 10);
            this.tabControlAssets.SelectedIndex = 0;
            this.tabControlAssets.Size = new System.Drawing.Size(1166, 653);
            this.tabControlAssets.TabIndex = 2;
            this.tabControlAssets.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControlAssets_MouseClick);
            // 
            // contextMenuStripAssets
            // 
            this.contextMenuStripAssets.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextTabsOpen,
            this.contextTabsShowExplorer});
            this.contextMenuStripAssets.Name = "contextMenuStrip1";
            this.contextMenuStripAssets.Size = new System.Drawing.Size(184, 70);
            // 
            // contextTabsOpen
            // 
            this.contextTabsOpen.Name = "contextTabsOpen";
            this.contextTabsOpen.Size = new System.Drawing.Size(183, 22);
            this.contextTabsOpen.Text = "Open";
            // 
            // contextTabsShowExplorer
            // 
            this.contextTabsShowExplorer.Name = "contextTabsShowExplorer";
            this.contextTabsShowExplorer.Size = new System.Drawing.Size(183, 22);
            this.contextTabsShowExplorer.Text = "Show in File Explorer";
            this.contextTabsShowExplorer.Click += new System.EventHandler(this.contextTabsShowExplorer_Click);
            // 
            // UAssetGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 699);
            this.Controls.Add(this.tabControlAssets);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UAssetGUI";
            this.Text = "UAssetGUI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStripAssets.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuFile;
        private ToolStripMenuItem menuFileOpen;
        private ToolStripMenuItem menuFileSave;
        private ToolStripMenuItem menuFileSaveAs;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem menuFileExport;
        private ToolStripMenuItem menuEdit;
        private ToolStripMenuItem menuEditUndo;
        private ToolStripMenuItem menuEditCopy;
        private ToolStripMenuItem menuEditPaste;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem menuEditFind;
        private ToolStripMenuItem menuEditReplace;
        private ToolStripMenuItem menuView;
        private ToolStripMenuItem menuFunctions;
        private ToolStripMenuItem menuHelp;
        private StatusStrip statusStrip1;
        private ToolStripProgressBar toolStripProgressBar1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripMenuItem menuFileImport;
        private ToolStripSeparator toolStripMenuItem7;
        private ToolStripMenuItem menuFileExit;
        private ToolStripMenuItem menuEditRedo;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripMenuItem5;
        private ToolStripMenuItem menuEditDuplicateAsset;
        private ToolStripSeparator toolStripMenuItem6;
        private ToolStripMenuItem menuEditExportSub;
        private ToolStripMenuItem menuEditImportSub;
        private ToolStripSeparator toolStripMenuItem9;
        private ToolStripMenuItem menuEditPreferences;
        private ToolStripMenuItem menuViewExpandAll;
        private ToolStripMenuItem menuViewCollapseAll;
        private ToolStripMenuItem menuViewExpandSelected;
        private ToolStripMenuItem menuViewCollapseSelected;
        private ToolStripMenuItem menuFunctionsPackageFolder;
        private ToolStripSeparator toolStripMenuItem8;
        private ToolStripMenuItem menuFunctionsExtractPak;
        private ToolStripMenuItem menuHelpAbout;
        private ToolStripMenuItem menuEditFindAll;
        private ToolStripMenuItem menuEditReplaceAll;
        private ToolStripMenuItem menuFileExportJSON;
        private ToolStripMenuItem menuFileExportXML;
        private ToolStripMenuItem menuFileExportPlaintext;
        private ToolStripMenuItem menuFileImportJSON;
        private ToolStripMenuItem menuFileImportXML;
        private ToolStripMenuItem menuFileImportCSV;
        private ToolStripMenuItem menuFileExportCSV;
        private ToolStripMenuItem menuFileImportPlaintext;
        private TabControl tabControlAssets;
        private ContextMenuStrip contextMenuStripAssets;
        private ToolStripMenuItem contextTabsOpen;
        private ToolStripMenuItem contextTabsShowExplorer;
    }
}