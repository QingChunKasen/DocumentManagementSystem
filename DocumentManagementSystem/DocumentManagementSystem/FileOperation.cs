namespace DocumentManagementSystem
{
    using Domain;
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;
    using Utilities;
    public partial class FileOperation : Form
    {
        private static readonly Logger logger = new Logger(typeof(FileOperation));
        private readonly List<ItemModel> selectedFiles;
        private FileOperationType operationType = FileOperationType.None;
        public FileOperation(List<ItemModel> selectedFiles)
        {
            this.selectedFiles = selectedFiles;
            InitializeComponent();
        }

        private void SubmitChange(object sender, EventArgs e)
        {
            try
            {
                logger.Info($"Begin to submit file change, the specified value is {this.specifiedMessage.Text}.");
                if (this.Validation())
                {
                    var changedFiles = new List<FileChangeModel>();
                    foreach (var file in this.selectedFiles)
                    {
                        changedFiles.Add(new FileChangeModel
                        {
                            Name = file.Name,
                            Path = file.Path,
                            operationType = this.operationType,
                            Input1 = this.specifiedMessage.Text,
                            Input2 = this.input2.Text
                        });
                    }
                    using (FileChangePreviewForm previewForm = new FileChangePreviewForm(changedFiles))
                    {
                        previewForm.ShowDialog();
                    }
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                logger.Error($"An error occurred when submitting file changes, the specified value is {this.specifiedMessage.Text}, reason: {ex}.");
            }
        }

        private bool Validation()
        {
            switch (this.operationType)
            {
                case FileOperationType.ExtentionChange:
                case FileOperationType.AddPrefix:
                case FileOperationType.AddSubfix:
                case FileOperationType.RemoveMatchingBeginning:
                case FileOperationType.RemoveMatchingEnd:
                case FileOperationType.RemoveSpecifiedCharacters:
                    return InputValidation();
                case FileOperationType.Removecharactersbeginning:
                case FileOperationType.RemoveCharactersEnd:
                    return IsInt();
                case FileOperationType.ReplaceWith:
                    return ReplaceWithValidation();
                case FileOperationType.RemoveDoubleSpaces:
                case FileOperationType.ConvertToLowercase:
                case FileOperationType.ConvertToUpercase:
                case FileOperationType.AppendFolderName:
                case FileOperationType.AppendDate:
                default:
                    break;
            }
            return true;
        }

        private bool InputValidation()
        {
            if(string.IsNullOrEmpty(this.specifiedMessage.Text))
            {
                MessageBox.Show("Please input your value!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool IsInt()
        {
            if (!Regex.IsMatch(this.specifiedMessage.Text, @"^[+-]?\d*$"))
            {
                MessageBox.Show("Please input a number!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool ReplaceWithValidation()
        {
            if (string.IsNullOrEmpty(this.specifiedMessage.Text))
            {
                MessageBox.Show("Please input required value!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void ExtentionChange(object sender, EventArgs e)
        {
            this.operationType = FileOperationType.ExtentionChange;
            this.Input1Group.Visible = true;
            this.HideReplaceGroup();
        }

        private void AddPrefix(object sender, EventArgs e)
        {
            this.operationType = FileOperationType.AddPrefix;
            this.Input1Group.Visible = true;
            this.HideReplaceGroup();
        }

        private void AddSubfix(object sender, EventArgs e)
        {
            this.operationType = FileOperationType.AddSubfix;
            this.Input1Group.Visible = true;
            this.HideReplaceGroup();
        }

        private void Removecharactersbeginning(object sender, EventArgs e)
        {
            this.operationType = FileOperationType.Removecharactersbeginning;
            this.Input1Group.Visible = true;
            this.HideReplaceGroup();
        }

        private void RemoveCharactersEnd(object sender, EventArgs e)
        {
            this.operationType = FileOperationType.RemoveCharactersEnd;
            this.Input1Group.Visible = true;
            this.HideReplaceGroup();
        }

        private void RemoveMatchingBeginning(object sender, EventArgs e)
        {
            this.operationType = FileOperationType.RemoveMatchingBeginning;
            this.Input1Group.Visible = true;
            this.HideReplaceGroup();
        }

        private void RemoveMatchingEnd(object sender, EventArgs e)
        {
            this.operationType = FileOperationType.RemoveMatchingEnd;
            this.Input1Group.Visible = true;
            this.HideReplaceGroup();
        }

        private void RemoveDoubleSpaces(object sender, EventArgs e)
        {
            this.operationType = FileOperationType.RemoveDoubleSpaces;
            this.Input1Group.Visible = false;
            this.HideReplaceGroup();
        }

        private void RemoveSpecifiedCharacters(object sender, EventArgs e)
        {
            this.operationType = FileOperationType.RemoveSpecifiedCharacters;
            this.Input1Group.Visible = true;
            this.HideReplaceGroup();
        }

        private void ReplaceWith(object sender, EventArgs e)
        {
            this.operationType = FileOperationType.ReplaceWith;
            this.Input1Group.Visible = true;
            this.replaceWithGroup.Visible = true;
        }

        private void ConvertToLowercase(object sender, EventArgs e)
        {
            this.operationType = FileOperationType.ConvertToLowercase;
            this.Input1Group.Visible = false;
            this.HideReplaceGroup();
        }

        private void ConvertToUpercase(object sender, EventArgs e)
        {
            this.operationType = FileOperationType.ConvertToUpercase;
            this.Input1Group.Visible = false;
            this.HideReplaceGroup();
        }

        private void AppendFolderName(object sender, EventArgs e)
        {
            this.operationType = FileOperationType.AppendFolderName;
            this.Input1Group.Visible = false;
            this.HideReplaceGroup();
        }

        private void AppendDate(object sender, EventArgs e)
        {
            this.operationType = FileOperationType.AppendDate;
            this.Input1Group.Visible = false;
            this.HideReplaceGroup();
        }

        private void HideReplaceGroup()
        {
            this.replaceWithGroup.Visible = false;
            this.input2.Text = String.Empty;
        }
    }
}
