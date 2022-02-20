
namespace DocumentManagementSystem
{
    partial class DocumentManagementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentManagementForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView = new System.Windows.Forms.TreeView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.search = new System.Windows.Forms.Button();
            this.searchKey = new System.Windows.Forms.TextBox();
            this.editFiles = new System.Windows.Forms.Button();
            this.location = new System.Windows.Forms.LinkLabel();
            this.LocationLable = new System.Windows.Forms.Label();
            this.fileGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.search);
            this.splitContainer1.Panel2.Controls.Add(this.searchKey);
            this.splitContainer1.Panel2.Controls.Add(this.editFiles);
            this.splitContainer1.Panel2.Controls.Add(this.location);
            this.splitContainer1.Panel2.Controls.Add(this.LocationLable);
            this.splitContainer1.Panel2.Controls.Add(this.fileGrid);
            this.splitContainer1.Size = new System.Drawing.Size(1200, 600);
            this.splitContainer1.SplitterDistance = 342;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeView
            // 
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.ImageKey = "Folder.png";
            this.treeView.ImageList = this.imageList;
            this.treeView.Location = new System.Drawing.Point(0, 0);
            this.treeView.Name = "treeView";
            this.treeView.SelectedImageIndex = 0;
            this.treeView.Size = new System.Drawing.Size(342, 600);
            this.treeView.TabIndex = 0;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "Drive.png");
            this.imageList.Images.SetKeyName(1, "ThisPC.png");
            this.imageList.Images.SetKeyName(2, "folder.png");
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(740, 48);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(100, 30);
            this.search.TabIndex = 4;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.Search);
            // 
            // searchKey
            // 
            this.searchKey.Location = new System.Drawing.Point(535, 50);
            this.searchKey.Name = "searchKey";
            this.searchKey.Size = new System.Drawing.Size(200, 26);
            this.searchKey.TabIndex = 3;
            // 
            // editFiles
            // 
            this.editFiles.Location = new System.Drawing.Point(0, 50);
            this.editFiles.Name = "editFiles";
            this.editFiles.Size = new System.Drawing.Size(100, 30);
            this.editFiles.TabIndex = 2;
            this.editFiles.Text = "Edit Files";
            this.editFiles.UseVisualStyleBackColor = true;
            this.editFiles.Click += new System.EventHandler(this.EditFiles);
            // 
            // location
            // 
            this.location.AutoSize = true;
            this.location.Location = new System.Drawing.Point(70, 20);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(0, 20);
            this.location.TabIndex = 1;
            this.location.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OpenLocation);
            // 
            // LocationLable
            // 
            this.LocationLable.AutoSize = true;
            this.LocationLable.Location = new System.Drawing.Point(0, 20);
            this.LocationLable.Name = "LocationLable";
            this.LocationLable.Size = new System.Drawing.Size(74, 20);
            this.LocationLable.TabIndex = 0;
            this.LocationLable.Text = "Location:";
            // 
            // fileGrid
            // 
            this.fileGrid.AllowUserToOrderColumns = true;
            this.fileGrid.AllowUserToResizeRows = false;
            this.fileGrid.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.fileGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.fileGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.fileGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fileGrid.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SortGrid);
            this.fileGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fileGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fileGrid.Location = new System.Drawing.Point(0, 86);
            this.fileGrid.Margin = new System.Windows.Forms.Padding(200, 3, 3, 3);
            this.fileGrid.Name = "fileGrid";
            this.fileGrid.ReadOnly = true;
            this.fileGrid.RowHeadersVisible = false;
            this.fileGrid.RowHeadersWidth = 62;
            this.fileGrid.RowTemplate.Height = 28;
            this.fileGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.fileGrid.Size = new System.Drawing.Size(854, 514);
            this.fileGrid.TabIndex = 0;
            // 
            // DocumentManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.splitContainer1);
            this.Name = "DocumentManagementForm";
            this.Text = "File Explorer";
            this.Load += new System.EventHandler(this.Form_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.DataGridView fileGrid;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Label LocationLable;
        private System.Windows.Forms.LinkLabel location;
        private System.Windows.Forms.Button editFiles;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox searchKey;
    }
}

