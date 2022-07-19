using System.Text.RegularExpressions;

namespace UAssetEditor
{
    public partial class UAssetGUI : Form
    {
        bool isSaved = false;
        enum ImportExportType { JSON, XML, CSV, Plaintext };
        string fileDirectory = null;
        string fileFilter = "Unreal Game Files (*.uasset;*.pak;*.umap;*.ucas)|*.uasset;*.pak;*.umap;*.ucas";
        int contextTabIndex = -1;

        public UAssetGUI()
        {
            InitializeComponent();
            
            tabControlAssets.TabPages.Clear();

            string[] args = Environment.GetCommandLineArgs();

            fileDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Untitled.uasset";
            if (args.Count() > 1)
            {
                if (HasValidExtension(args[1]))
                {
                    fileDirectory = args[1];
                    LoadAssetFile();
                }
            }
        }

        private List<string> GetValidExtensions()
        {
            List<string> validExtensions = new List<string>();
            string parseFilter = fileFilter;
            while (parseFilter.Contains("("))
            {
                int start = parseFilter.IndexOf("(");
                int end = parseFilter.IndexOf(")");
                string filterGroup = parseFilter.Substring(start + 1, end - start + 1);
                string[] filters = filterGroup.Split(';');
                validExtensions.AddRange(filters);
                parseFilter = parseFilter.Substring(end + 1);
            }
            return validExtensions;
        }
        private bool HasValidExtension(string filename)
        {
            string fileExt = filename.Substring(filename.LastIndexOf("."));
            List<string> validExtensions = GetValidExtensions();
            foreach (string extension in validExtensions)
            {
                if (fileExt.Equals(extension.Substring(1)))
                {
                    return true;
                }
            }
            return false;
        }
        private void LoadAssetFile(bool newTab = false)
        {
            string assetFile = fileDirectory;
            string filename = assetFile.Substring(assetFile.LastIndexOf('\\') + 1);
            if (newTab)
            {
                tabControlAssets.TabPages.Add(new TabPage(filename));
            }
            else
            {
                tabControlAssets.TabPages[tabControlAssets.TabCount - 1].Text = filename;
            }
        }

        // Menu -> File
        private void menuFileOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = fileFilter;
            dialog.InitialDirectory = fileDirectory.Substring(0, fileDirectory.LastIndexOf('\\'));
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                fileDirectory = dialog.FileName;
                LoadAssetFile(true);
            }
        }
        private void menuFileSave_Click(object sender, EventArgs e)
        {
            File.Create(fileDirectory);
        }
        private void menuFileSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = fileFilter;
            dialog.InitialDirectory = fileDirectory.Substring(0, fileDirectory.LastIndexOf('\\'));
            dialog.FileName = fileDirectory.Substring(fileDirectory.LastIndexOf('\\') + 1);
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                fileDirectory = dialog.FileName;
            }
            menuFileSave_Click(sender, e);
        }
        private void menuFileExport_Click(object sender, EventArgs e)
        {
            ImportExportType exportType;
            Enum.TryParse(sender.ToString(), out exportType);
            switch (exportType)
            {
                case ImportExportType.JSON:
                    break;
                case ImportExportType.XML:
                    break;
                case ImportExportType.CSV:
                    break;
                case ImportExportType.Plaintext:
                    break;
                default:
                    // No type selected, manually select type
                    MessageBox.Show("Please select an export type");
                    break;
            }
        }
        private void menuFileImport_Click(object sender, EventArgs e)
        {
            ImportExportType importType;
            Enum.TryParse(sender.ToString(), out importType);
            switch (importType)
            {
                case ImportExportType.JSON:
                    break;
                case ImportExportType.XML:
                    break;
                case ImportExportType.CSV:
                    break;
                case ImportExportType.Plaintext:
                    break;
                default:
                    // No type selected, manually select type
                    MessageBox.Show("Please select an export type");
                    break;
            }
        }
        private void menuFileExit_Click(object sender, EventArgs e)
        {
            // Check if file is saved
            if (isSaved)
            {
                this.Close();
            }
            else
            {
                DialogResult result = MessageBox.Show("Do you want to save the file before exiting?", "Save", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    menuFileSave_Click(sender, e);
                    this.Close();
                }
                else if (result == DialogResult.No)
                {
                    this.Close();
                }
            }
        }
        // Menu -> Edit
        private void menuEditUndo_Click(object sender, EventArgs e)
        {

        }
        private void menuEditRedo_Click(object sender, EventArgs e)
        {

        }
        private void menuEditCut_Click(object sender, EventArgs e)
        {

        }
        private void menuEditCopy_Click(object sender, EventArgs e)
        {

        }
        private void menuEditPaste_Click(object sender, EventArgs e)
        {

        }
        private void menuEditFind_Click(object sender, EventArgs e)
        {

        }
        private void menuEditReplace_Click(object sender, EventArgs e)
        {

        }
        private void menuEditFindAll_Click(object sender, EventArgs e)
        {

        }
        private void menuEditReplaceAll_Click(object sender, EventArgs e)
        {

        }
        private void menuEditDuplicateAsset_Click(object sender, EventArgs e)
        {

        }
        private void menuEditImportSub_Click(object sender, EventArgs e)
        {

        }
        private void menuEditExportSub_Click(object sender, EventArgs e)
        {

        }
        private void menuEditPreferences_Click(object sender, EventArgs e)
        {

        }
        // Menu -> View
        private void menuViewExpandAll_Click(object sender, EventArgs e)
        {

        }
        private void menuViewCollapseAll_Click(object sender, EventArgs e)
        {

        }
        private void menuViewExpandSelected_Click(object sender, EventArgs e)
        {

        }
        private void menuViewCollapseSelected_Click(object sender, EventArgs e)
        {

        }
        // Menu -> Functions
        private void menuFunctionsPackageFolder_Click(object sender, EventArgs e)
        {

        }
        private void menuFunctionsExtractPak_Click(object sender, EventArgs e)
        {

        }
        // Menu -> Help
        private void menuHelpAbout_Click(object sender, EventArgs e)
        {

        }

        private void tabControlAssets_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                for (int i = 0; i < tabControlAssets.TabCount; ++i)
                {
                    if (tabControlAssets.GetTabRect(i).Contains(e.Location))
                    {
                        contextTabIndex = i;
                        TabPage selectedTab = tabControlAssets.TabPages[i];
                        this.Text = selectedTab.Text;
                        contextMenuStripAssets.Show(tabControlAssets, e.Location);
                    }
                }
            }
        }

        private void contextTabsShowExplorer_Click(object sender, EventArgs e)
        {
            string argument = "/select, \"" + fileDirectory + "\"";
            System.Diagnostics.Process.Start("explorer.exe", argument);
        }
    }
}