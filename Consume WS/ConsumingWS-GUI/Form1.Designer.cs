namespace ConsumingWS_GUI
{
    partial class Form1
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
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.textBoxFile_Name = new System.Windows.Forms.TextBox();
            this.textBoxFull_File_Name = new System.Windows.Forms.TextBox();
            this.labelSearchForFile = new System.Windows.Forms.Label();
            this.textBoxSearchForFile = new System.Windows.Forms.TextBox();
            this.buttonFindFile = new System.Windows.Forms.Button();
            this.labelDataResult = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(33, 19);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenFile.TabIndex = 0;
            this.buttonOpenFile.Text = "Open File";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // textBoxFile_Name
            // 
            this.textBoxFile_Name.Location = new System.Drawing.Point(148, 21);
            this.textBoxFile_Name.Name = "textBoxFile_Name";
            this.textBoxFile_Name.Size = new System.Drawing.Size(157, 20);
            this.textBoxFile_Name.TabIndex = 1;
            // 
            // textBoxFull_File_Name
            // 
            this.textBoxFull_File_Name.Location = new System.Drawing.Point(33, 60);
            this.textBoxFull_File_Name.Name = "textBoxFull_File_Name";
            this.textBoxFull_File_Name.Size = new System.Drawing.Size(272, 20);
            this.textBoxFull_File_Name.TabIndex = 2;
            this.textBoxFull_File_Name.TextChanged += new System.EventHandler(this.textBoxFull_File_Name_TextChanged);
            // 
            // labelSearchForFile
            // 
            this.labelSearchForFile.AutoSize = true;
            this.labelSearchForFile.Location = new System.Drawing.Point(33, 137);
            this.labelSearchForFile.Name = "labelSearchForFile";
            this.labelSearchForFile.Size = new System.Drawing.Size(72, 13);
            this.labelSearchForFile.TabIndex = 3;
            this.labelSearchForFile.Text = "Search for file";
            // 
            // textBoxSearchForFile
            // 
            this.textBoxSearchForFile.Location = new System.Drawing.Point(36, 165);
            this.textBoxSearchForFile.Name = "textBoxSearchForFile";
            this.textBoxSearchForFile.Size = new System.Drawing.Size(165, 20);
            this.textBoxSearchForFile.TabIndex = 4;
            this.textBoxSearchForFile.TextChanged += new System.EventHandler(this.textBoxSearchForFile_TextChanged);
            // 
            // buttonFindFile
            // 
            this.buttonFindFile.Location = new System.Drawing.Point(219, 161);
            this.buttonFindFile.Name = "buttonFindFile";
            this.buttonFindFile.Size = new System.Drawing.Size(86, 23);
            this.buttonFindFile.TabIndex = 5;
            this.buttonFindFile.Text = "Find File";
            this.buttonFindFile.UseVisualStyleBackColor = true;
            this.buttonFindFile.Click += new System.EventHandler(this.buttonFindFile_Click);
            // 
            // labelDataResult
            // 
            this.labelDataResult.AutoSize = true;
            this.labelDataResult.Location = new System.Drawing.Point(371, 19);
            this.labelDataResult.Name = "labelDataResult";
            this.labelDataResult.Size = new System.Drawing.Size(35, 13);
            this.labelDataResult.TabIndex = 6;
            this.labelDataResult.Text = "label1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(738, 476);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonFindFile);
            this.tabPage1.Controls.Add(this.labelDataResult);
            this.tabPage1.Controls.Add(this.buttonOpenFile);
            this.tabPage1.Controls.Add(this.textBoxFile_Name);
            this.tabPage1.Controls.Add(this.textBoxSearchForFile);
            this.tabPage1.Controls.Add(this.textBoxFull_File_Name);
            this.tabPage1.Controls.Add(this.labelSearchForFile);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(730, 450);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 482);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.TextBox textBoxFile_Name;
        private System.Windows.Forms.TextBox textBoxFull_File_Name;
        private System.Windows.Forms.Label labelSearchForFile;
        private System.Windows.Forms.TextBox textBoxSearchForFile;
        private System.Windows.Forms.Button buttonFindFile;
        private System.Windows.Forms.Label labelDataResult;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

