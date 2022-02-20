
namespace DocumentManagementSystem
{
    partial class FileChangePreviewForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.changeFileGrid = new System.Windows.Forms.DataGridView();
            this.SubmitConfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.changeFileGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.changeFileGrid);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.SubmitConfirm);
            this.splitContainer1.Size = new System.Drawing.Size(778, 544);
            this.splitContainer1.SplitterDistance = 490;
            this.splitContainer1.TabIndex = 0;
            // 
            // changeFileGrid
            // 
            this.changeFileGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.changeFileGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.changeFileGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.changeFileGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.changeFileGrid.GridColor = System.Drawing.SystemColors.Control;
            this.changeFileGrid.Location = new System.Drawing.Point(0, 0);
            this.changeFileGrid.Name = "changeFileGrid";
            this.changeFileGrid.ReadOnly = true;
            this.changeFileGrid.RowHeadersVisible = false;
            this.changeFileGrid.RowHeadersWidth = 62;
            this.changeFileGrid.RowTemplate.Height = 28;
            this.changeFileGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.changeFileGrid.Size = new System.Drawing.Size(778, 490);
            this.changeFileGrid.TabIndex = 0;
            // 
            // button1
            // 
            this.SubmitConfirm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubmitConfirm.Location = new System.Drawing.Point(0, 0);
            this.SubmitConfirm.Name = "button1";
            this.SubmitConfirm.Size = new System.Drawing.Size(778, 50);
            this.SubmitConfirm.TabIndex = 0;
            this.SubmitConfirm.Text = "Submit";
            this.SubmitConfirm.UseVisualStyleBackColor = true;
            this.SubmitConfirm.Click += new System.EventHandler(this.SubmitConfirmed);
            // 
            // FileChangePreviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FileChangePreviewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit File Preview";
            this.Load += new System.EventHandler(this.FileChangePreviewForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.changeFileGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView changeFileGrid;
        private System.Windows.Forms.Button SubmitConfirm;
    }
}