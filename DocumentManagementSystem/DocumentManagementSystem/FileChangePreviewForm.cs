namespace DocumentManagementSystem
{
    using Domain.Model;
    using Domain.Service.Interface;
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using Utilities;

    public partial class FileChangePreviewForm : Form
    {
        private static readonly Logger logger = new Logger(typeof(FileChangePreviewForm));
        private static readonly IFileManager fileManager = IocContainerCache.Container.Resolve<IFileManager>();
        private readonly List<FileChangeModel> changedFiles;
        public FileChangePreviewForm(List<FileChangeModel> changedFiles)
        {
            this.changedFiles = changedFiles;
            InitializeComponent();
        }

        private void FileChangePreviewForm_Load(object sender, EventArgs e)
        {
            this.changeFileGrid.DataSource = this.changedFiles;
            this.changeFileGrid.Columns[0].Width = 250;
            this.changeFileGrid.Columns[1].Visible = false; 
            this.changeFileGrid.Columns[2].Visible = false; 
            this.changeFileGrid.Columns[3].Visible = false;
            this.changeFileGrid.Columns[4].Visible = false;
            this.changeFileGrid.Columns[5].Width = 268;
        }

        private void SubmitConfirmed(object sender, EventArgs e)
        {
            try
            {
                logger.Info("Submit confirmed, begin to change file.");
                var files = new List<LocalFile>();
                foreach(var file in this.changedFiles)
                {
                    files.Add(new LocalFile
                    {
                        Name = file.Name,
                        Path = file.Path,
                        NewFileName = file.Changeto
                    });
                }
                fileManager.ChangeFileNames(files);
                var DMForm = DocumentManagementForm.GetInstance();
                DMForm.GridRefresh();
                this.Close();
            }
            catch (Exception ex)
            {
                logger.Info($"An error occurred when update files, reason: {ex}");
            }
        }
    }
}
