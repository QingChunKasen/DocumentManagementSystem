
namespace DocumentManagementSystem
{
    partial class FileOperation
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
            this.groupOperations = new System.Windows.Forms.GroupBox();
            this.radioButton14 = new System.Windows.Forms.RadioButton();
            this.radioButton13 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.Input1Group = new System.Windows.Forms.GroupBox();
            this.specifiedMessage = new System.Windows.Forms.TextBox();
            this.submitChange = new System.Windows.Forms.Button();
            this.replaceWithGroup = new System.Windows.Forms.GroupBox();
            this.input2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupOperations.SuspendLayout();
            this.Input1Group.SuspendLayout();
            this.replaceWithGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupOperations
            // 
            this.groupOperations.Controls.Add(this.radioButton14);
            this.groupOperations.Controls.Add(this.radioButton13);
            this.groupOperations.Controls.Add(this.radioButton12);
            this.groupOperations.Controls.Add(this.radioButton11);
            this.groupOperations.Controls.Add(this.radioButton10);
            this.groupOperations.Controls.Add(this.radioButton9);
            this.groupOperations.Controls.Add(this.radioButton8);
            this.groupOperations.Controls.Add(this.radioButton7);
            this.groupOperations.Controls.Add(this.radioButton6);
            this.groupOperations.Controls.Add(this.radioButton5);
            this.groupOperations.Controls.Add(this.radioButton4);
            this.groupOperations.Controls.Add(this.radioButton3);
            this.groupOperations.Controls.Add(this.radioButton2);
            this.groupOperations.Controls.Add(this.radioButton1);
            this.groupOperations.Location = new System.Drawing.Point(20, 20);
            this.groupOperations.Name = "groupOperations";
            this.groupOperations.Size = new System.Drawing.Size(450, 500);
            this.groupOperations.TabIndex = 0;
            this.groupOperations.TabStop = false;
            this.groupOperations.Text = "Please select the action you want:";
            // 
            // radioButton14
            // 
            this.radioButton14.AutoSize = true;
            this.radioButton14.Location = new System.Drawing.Point(20, 426);
            this.radioButton14.Name = "radioButton14";
            this.radioButton14.Size = new System.Drawing.Size(293, 24);
            this.radioButton14.TabIndex = 13;
            this.radioButton14.TabStop = true;
            this.radioButton14.Text = "Append today\'s date to the file name";
            this.radioButton14.UseVisualStyleBackColor = true;
            this.radioButton14.CheckedChanged += new System.EventHandler(this.AppendDate);
            // 
            // radioButton13
            // 
            this.radioButton13.AutoSize = true;
            this.radioButton13.Location = new System.Drawing.Point(20, 395);
            this.radioButton13.Name = "radioButton13";
            this.radioButton13.Size = new System.Drawing.Size(318, 24);
            this.radioButton13.TabIndex = 12;
            this.radioButton13.TabStop = true;
            this.radioButton13.Text = "Append the folder name to the file name";
            this.radioButton13.UseVisualStyleBackColor = true;
            this.radioButton13.CheckedChanged += new System.EventHandler(this.AppendFolderName);
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.Location = new System.Drawing.Point(20, 364);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(272, 24);
            this.radioButton12.TabIndex = 11;
            this.radioButton12.TabStop = true;
            this.radioButton12.Text = "Convert the file name to upercase";
            this.radioButton12.UseVisualStyleBackColor = true;
            this.radioButton12.CheckedChanged += new System.EventHandler(this.ConvertToUpercase);
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Location = new System.Drawing.Point(20, 333);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(277, 24);
            this.radioButton11.TabIndex = 10;
            this.radioButton11.TabStop = true;
            this.radioButton11.Text = "Convert the file name to lowercase";
            this.radioButton11.UseVisualStyleBackColor = true;
            this.radioButton11.CheckedChanged += new System.EventHandler(this.ConvertToLowercase);
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(20, 302);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(306, 24);
            this.radioButton10.TabIndex = 9;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "Replace specified text in file name with";
            this.radioButton10.UseVisualStyleBackColor = true;
            this.radioButton10.CheckedChanged += new System.EventHandler(this.ReplaceWith);
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(20, 271);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(239, 24);
            this.radioButton9.TabIndex = 8;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "Remove specified characters";
            this.radioButton9.UseVisualStyleBackColor = true;
            this.radioButton9.CheckedChanged += new System.EventHandler(this.RemoveSpecifiedCharacters);
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(20, 240);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(201, 24);
            this.radioButton8.TabIndex = 7;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Remove double-spaces";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.RemoveDoubleSpaces);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(20, 210);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(358, 24);
            this.radioButton7.TabIndex = 6;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Remove matching string from end of file name";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.RemoveMatchingEnd);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(20, 180);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(400, 24);
            this.radioButton6.TabIndex = 5;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Remove matching string from beginning of file name";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.RemoveMatchingBeginning);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(20, 150);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(338, 24);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Remove n characters from end of file name";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.RemoveCharactersEnd);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(20, 120);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(380, 24);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Remove n characters from beginning of file name";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.Removecharactersbeginning);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(20, 90);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(104, 24);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Add suffix";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.AddSubfix);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(20, 60);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(105, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Add prefix";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.AddPrefix);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(20, 30);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(186, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Change file extension";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.ExtentionChange);
            // 
            // Input1Group
            // 
            this.Input1Group.Controls.Add(this.specifiedMessage);
            this.Input1Group.Controls.Add(this.label1);
            this.Input1Group.Location = new System.Drawing.Point(480, 20);
            this.Input1Group.Name = "Input1Group";
            this.Input1Group.Size = new System.Drawing.Size(260, 100);
            this.Input1Group.TabIndex = 1;
            this.Input1Group.TabStop = false;
            this.Input1Group.Text = "Specify your value";
            // 
            // specifiedMessage
            // 
            this.specifiedMessage.Location = new System.Drawing.Point(20, 30);
            this.specifiedMessage.Name = "specifiedMessage";
            this.specifiedMessage.Size = new System.Drawing.Size(230, 26);
            this.specifiedMessage.TabIndex = 0;
            // 
            // submitChange
            // 
            this.submitChange.Location = new System.Drawing.Point(665, 497);
            this.submitChange.Name = "submitChange";
            this.submitChange.Size = new System.Drawing.Size(100, 30);
            this.submitChange.TabIndex = 2;
            this.submitChange.Text = "Submit";
            this.submitChange.UseVisualStyleBackColor = true;
            this.submitChange.Click += new System.EventHandler(this.SubmitChange);
            // 
            // replaceWithGroup
            // 
            this.replaceWithGroup.Controls.Add(this.input2);
            this.replaceWithGroup.Location = new System.Drawing.Point(480, 140);
            this.replaceWithGroup.Name = "replaceWithGroup";
            this.replaceWithGroup.Size = new System.Drawing.Size(260, 100);
            this.replaceWithGroup.TabIndex = 3;
            this.replaceWithGroup.TabStop = false;
            this.replaceWithGroup.Text = "Replace your value with";
            // 
            // input2
            // 
            this.input2.Location = new System.Drawing.Point(20, 30);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(230, 26);
            this.input2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(5, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "*";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(480, 260);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Notes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 30);
            this.label2.MaximumSize = new System.Drawing.Size(230, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = "If the modified file name is invalid, we skip this step.";
            // 
            // FileOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.replaceWithGroup);
            this.Controls.Add(this.submitChange);
            this.Controls.Add(this.Input1Group);
            this.Controls.Add(this.groupOperations);
            this.Name = "FileOperation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit File";
            this.groupOperations.ResumeLayout(false);
            this.groupOperations.PerformLayout();
            this.Input1Group.ResumeLayout(false);
            this.Input1Group.PerformLayout();
            this.replaceWithGroup.ResumeLayout(false);
            this.replaceWithGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupOperations;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton14;
        private System.Windows.Forms.RadioButton radioButton13;
        private System.Windows.Forms.RadioButton radioButton12;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.GroupBox Input1Group;
        private System.Windows.Forms.TextBox specifiedMessage;
        private System.Windows.Forms.Button submitChange;
        private System.Windows.Forms.GroupBox replaceWithGroup;
        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
    }
}