namespace DocumentManagementSystem
{
    using System;
    using System.Diagnostics;
    using System.Linq;
    using System.Windows.Forms;
    using Utilities;
    public partial class DocumentManagementForm : Form
    {
        private static readonly ITreeService TreeService = IocContainerCache.Container.Resolve<ITreeService>();
        private static readonly IGridService GridService = IocContainerCache.Container.Resolve<IGridService>();
        private static readonly Logger logger = new Logger(typeof(DocumentManagementForm));
        private SortOrder sortOrder = SortOrder.None;
        private static DocumentManagementForm form;

        public static DocumentManagementForm GetInstance()
        {
            if (form == null)
            {
                form = new DocumentManagementForm();
            }
            return form;
        }

        public DocumentManagementForm()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Form_Load(object sender, EventArgs e)
        {

            try
            {
                logger.Info("Begin to load form.");
                TreeService.InitTree(treeView.Nodes);
                GridService.InitGrid(this.fileGrid);
            }
            catch (Exception ex)
            {
                logger.Info($"An error occurred when loading form, reason: {ex}");
            }
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            logger.Info("Begin111 to load tree.");
            try
            {
                this.searchKey.Text = string.Empty;
                this.sortOrder = SortOrder.None;
                TreeService.LoadChildren(this.treeView.SelectedNode);
                var fullPath = this.treeView.SelectedNode.FullPath;
                logger.Info($"Begin to load tree under {fullPath}.");
                if (this.treeView.SelectedNode.FullPath != Constants.ThisPC)
                {
                    fullPath = this.treeView.SelectedNode.FullPath.Substring(8);
                    this.location.Text = fullPath.Replace(@"\\", @"\");
                }
                GridService.GridShow(this.fileGrid, fullPath);
                this.fileGrid.Columns[0].HeaderText = string.Empty;
                this.fileGrid.Columns[0].Width = 30;
            }
            catch (Exception ex)
            {
                logger.Info($"An error occurred when loading tree, reason: {ex}");
            }
        }

        public void GridRefresh()
        {
            this.searchKey.Text = string.Empty;
            this.sortOrder = SortOrder.None;
            GridService.GridShow(this.fileGrid, this.location.Text);
            this.fileGrid.Columns[0].HeaderText = string.Empty;
            this.fileGrid.Columns[0].Width = 30;
        }

        private void EditFiles(object sender, EventArgs e)
        {
            try
            {
                var selectedFiles = GridService.GetSelectedFiles(this.fileGrid);
                if (selectedFiles.Any())
                {
                    using (FileOperation fileForm = new FileOperation(GridService.GetSelectedFiles(this.fileGrid)))
                    {
                        fileForm.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Please select at least one file!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                logger.Error($"An error occurred when editting files, reason: {ex}");
            }
        }

        private void OpenLocation(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                logger.Info($"Open folder: {location.Text}.");
                Process.Start(location.Text);
            }
            catch (Exception ex)
            {
                logger.Info($"Open folder {location.Text} failed, reason: {ex}.");
            }
        }

        private void Search(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.searchKey.Text))
            {
                this.fileGrid.DataSource = GridService.GridSearch(this.location.Text, this.searchKey.Text);
            }
        }

        private void SortGrid(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (this.sortOrder != SortOrder.Ascending)
            {
                this.sortOrder = SortOrder.Ascending;
            }
            else
            {
                this.sortOrder = SortOrder.Descending;
            }
            this.fileGrid.DataSource = GridService.Sort(this.location.Text, this.searchKey.Text, e.ColumnIndex, this.sortOrder);
        }
    }
}
