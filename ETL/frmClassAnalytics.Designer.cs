namespace ETL
{
    partial class frmClassAnalytics
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
            this.TxtBxSelectFolder = new System.Windows.Forms.TextBox();
            this.BtnSelectDirectory = new System.Windows.Forms.Button();
            this.BtnRunAnalysis = new System.Windows.Forms.Button();
            this.ListBox1 = new System.Windows.Forms.ListBox();
            this.Groupbox1 = new System.Windows.Forms.GroupBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.BtnPopFiles = new System.Windows.Forms.Button();
            this.Groupbox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtBxSelectFolder
            // 
            this.TxtBxSelectFolder.Location = new System.Drawing.Point(53, 76);
            this.TxtBxSelectFolder.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.TxtBxSelectFolder.Name = "TxtBxSelectFolder";
            this.TxtBxSelectFolder.Size = new System.Drawing.Size(865, 38);
            this.TxtBxSelectFolder.TabIndex = 1;
            // 
            // BtnSelectDirectory
            // 
            this.BtnSelectDirectory.Location = new System.Drawing.Point(1003, 45);
            this.BtnSelectDirectory.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.BtnSelectDirectory.Name = "BtnSelectDirectory";
            this.BtnSelectDirectory.Size = new System.Drawing.Size(333, 148);
            this.BtnSelectDirectory.TabIndex = 0;
            this.BtnSelectDirectory.Text = "Select Directory";
            this.BtnSelectDirectory.UseVisualStyleBackColor = true;
            this.BtnSelectDirectory.Click += new System.EventHandler(this.BtnSelectDirectory_Click);
            // 
            // BtnRunAnalysis
            // 
            this.BtnRunAnalysis.Location = new System.Drawing.Point(1086, 1008);
            this.BtnRunAnalysis.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.BtnRunAnalysis.Name = "BtnRunAnalysis";
            this.BtnRunAnalysis.Size = new System.Drawing.Size(323, 114);
            this.BtnRunAnalysis.TabIndex = 8;
            this.BtnRunAnalysis.Text = "Run Analysis";
            this.BtnRunAnalysis.UseVisualStyleBackColor = true;
            this.BtnRunAnalysis.Click += new System.EventHandler(this.BtnRunAnalysis_Click);
            // 
            // ListBox1
            // 
            this.ListBox1.FormattingEnabled = true;
            this.ListBox1.ItemHeight = 31;
            this.ListBox1.Location = new System.Drawing.Point(83, 527);
            this.ListBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ListBox1.Name = "ListBox1";
            this.ListBox1.Size = new System.Drawing.Size(1345, 438);
            this.ListBox1.TabIndex = 5;
            // 
            // Groupbox1
            // 
            this.Groupbox1.Controls.Add(this.TxtBxSelectFolder);
            this.Groupbox1.Controls.Add(this.BtnSelectDirectory);
            this.Groupbox1.Location = new System.Drawing.Point(83, 193);
            this.Groupbox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Groupbox1.Name = "Groupbox1";
            this.Groupbox1.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Groupbox1.Size = new System.Drawing.Size(1352, 238);
            this.Groupbox1.TabIndex = 7;
            this.Groupbox1.TabStop = false;
            this.Groupbox1.Text = "Select a Folder that has all of your files";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(397, 43);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(649, 98);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Class Analytics";
            // 
            // BtnPopFiles
            // 
            this.BtnPopFiles.Location = new System.Drawing.Point(136, 1018);
            this.BtnPopFiles.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.BtnPopFiles.Name = "BtnPopFiles";
            this.BtnPopFiles.Size = new System.Drawing.Size(323, 114);
            this.BtnPopFiles.TabIndex = 9;
            this.BtnPopFiles.Text = "Populate Files";
            this.BtnPopFiles.UseVisualStyleBackColor = true;
            this.BtnPopFiles.Click += new System.EventHandler(this.BtnPopFiles_Click);
            // 
            // frmClassAnalytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1515, 1197);
            this.Controls.Add(this.BtnPopFiles);
            this.Controls.Add(this.BtnRunAnalysis);
            this.Controls.Add(this.ListBox1);
            this.Controls.Add(this.Groupbox1);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "frmClassAnalytics";
            this.Text = "Class Analytics";
            this.Groupbox1.ResumeLayout(false);
            this.Groupbox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBxSelectFolder;
        private System.Windows.Forms.Button BtnSelectDirectory;
        private System.Windows.Forms.Button BtnRunAnalysis;
        private System.Windows.Forms.ListBox ListBox1;
        private System.Windows.Forms.GroupBox Groupbox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button BtnPopFiles;
    }
}

