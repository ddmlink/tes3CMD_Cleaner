namespace tes3CMD_Cleaner
{
    partial class Form1
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
            checkedListBox1 = new CheckedListBox();
            btnRemove = new Button();
            btnClean = new Button();
            chkGMST = new CheckBox();
            chkCellParams = new CheckBox();
            chkDups = new CheckBox();
            chkInstances = new CheckBox();
            chkJunk = new CheckBox();
            btnBrowse = new Button();
            SuspendLayout();
            // 
            // checkedListBox1
            // 
            checkedListBox1.AllowDrop = true;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.HorizontalScrollbar = true;
            checkedListBox1.Location = new Point(12, 12);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(594, 238);
            checkedListBox1.TabIndex = 0;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(12, 256);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(110, 23);
            btnRemove.TabIndex = 1;
            btnRemove.Text = "Remove Selected";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnClean
            // 
            btnClean.Location = new Point(12, 335);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(110, 23);
            btnClean.TabIndex = 8;
            btnClean.Text = "Clean All In List";
            btnClean.UseVisualStyleBackColor = true;
            btnClean.Click += btnClean_Click;
            // 
            // chkGMST
            // 
            chkGMST.AutoSize = true;
            chkGMST.Location = new Point(107, 285);
            chkGMST.Name = "chkGMST";
            chkGMST.Size = new Size(94, 19);
            chkGMST.TabIndex = 3;
            chkGMST.Text = "Clean GMSTs";
            chkGMST.UseVisualStyleBackColor = true;
            // 
            // chkCellParams
            // 
            chkCellParams.AutoSize = true;
            chkCellParams.Location = new Point(223, 285);
            chkCellParams.Name = "chkCellParams";
            chkCellParams.Size = new Size(141, 19);
            chkCellParams.TabIndex = 4;
            chkCellParams.Text = "Clean Cell Subrecords";
            chkCellParams.UseVisualStyleBackColor = true;
            // 
            // chkDups
            // 
            chkDups.AutoSize = true;
            chkDups.Location = new Point(370, 285);
            chkDups.Name = "chkDups";
            chkDups.Size = new Size(189, 19);
            chkDups.TabIndex = 5;
            chkDups.Text = "Clean Other Complete Records";
            chkDups.UseVisualStyleBackColor = true;
            // 
            // chkInstances
            // 
            chkInstances.AutoSize = true;
            chkInstances.Location = new Point(131, 310);
            chkInstances.Name = "chkInstances";
            chkInstances.Size = new Size(205, 19);
            chkInstances.TabIndex = 6;
            chkInstances.Text = "Clean Object Instances From Cells";
            chkInstances.UseVisualStyleBackColor = true;
            // 
            // chkJunk
            // 
            chkJunk.AutoSize = true;
            chkJunk.Location = new Point(342, 310);
            chkJunk.Name = "chkJunk";
            chkJunk.Size = new Size(111, 19);
            chkJunk.TabIndex = 7;
            chkJunk.Text = "Clean Junk Cells";
            chkJunk.UseVisualStyleBackColor = true;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(531, 256);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(75, 23);
            btnBrowse.TabIndex = 2;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 368);
            Controls.Add(btnBrowse);
            Controls.Add(chkJunk);
            Controls.Add(chkInstances);
            Controls.Add(chkDups);
            Controls.Add(chkCellParams);
            Controls.Add(chkGMST);
            Controls.Add(btnClean);
            Controls.Add(btnRemove);
            Controls.Add(checkedListBox1);
            Name = "Form1";
            Text = "tes3CMD Cleaner";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox checkedListBox1;
        private Button btnRemove;
        private Button btnClean;
        private CheckBox chkGMST;
        private CheckBox chkCellParams;
        private CheckBox chkDups;
        private CheckBox chkInstances;
        private CheckBox chkJunk;
        private Button btnBrowse;
    }
}