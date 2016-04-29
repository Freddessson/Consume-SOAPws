namespace Consuming
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
            this.buttonFindFile = new System.Windows.Forms.Button();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.textBoxFile_Name = new System.Windows.Forms.TextBox();
            this.textBoxTotalFileName = new System.Windows.Forms.TextBox();
            this.labelFiletoText = new System.Windows.Forms.Label();
            this.labelSearchForFile = new System.Windows.Forms.Label();
            this.tabControlCobraCustomer = new System.Windows.Forms.TabControl();
            this.FileToText = new System.Windows.Forms.TabPage();
            this.CobraCustomer = new System.Windows.Forms.TabPage();
            this.buttonGetAllCobraCustomers = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControlCobraCustomer.SuspendLayout();
            this.FileToText.SuspendLayout();
            this.CobraCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFindFile
            // 
            this.buttonFindFile.Location = new System.Drawing.Point(235, 129);
            this.buttonFindFile.Name = "buttonFindFile";
            this.buttonFindFile.Size = new System.Drawing.Size(75, 23);
            this.buttonFindFile.TabIndex = 1;
            this.buttonFindFile.Text = "Find File";
            this.buttonFindFile.UseVisualStyleBackColor = true;
            this.buttonFindFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(22, 132);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(172, 20);
            this.textBoxFileName.TabIndex = 2;
            this.textBoxFileName.TextChanged += new System.EventHandler(this.textBoxFileName_TextChanged);
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(22, 27);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenFile.TabIndex = 3;
            this.buttonOpenFile.Text = "Open File";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // textBoxFile_Name
            // 
            this.textBoxFile_Name.Location = new System.Drawing.Point(134, 30);
            this.textBoxFile_Name.Name = "textBoxFile_Name";
            this.textBoxFile_Name.Size = new System.Drawing.Size(176, 20);
            this.textBoxFile_Name.TabIndex = 4;
            this.textBoxFile_Name.TextChanged += new System.EventHandler(this.textBoxFile_Name_TextChanged);
            // 
            // textBoxTotalFileName
            // 
            this.textBoxTotalFileName.Location = new System.Drawing.Point(22, 64);
            this.textBoxTotalFileName.Name = "textBoxTotalFileName";
            this.textBoxTotalFileName.Size = new System.Drawing.Size(288, 20);
            this.textBoxTotalFileName.TabIndex = 5;
            this.textBoxTotalFileName.TextChanged += new System.EventHandler(this.textBoxTotalFileName_TextChanged);
            // 
            // labelFiletoText
            // 
            this.labelFiletoText.AutoSize = true;
            this.labelFiletoText.Location = new System.Drawing.Point(538, 27);
            this.labelFiletoText.Name = "labelFiletoText";
            this.labelFiletoText.Size = new System.Drawing.Size(0, 13);
            this.labelFiletoText.TabIndex = 6;
            // 
            // labelSearchForFile
            // 
            this.labelSearchForFile.AutoSize = true;
            this.labelSearchForFile.Location = new System.Drawing.Point(22, 113);
            this.labelSearchForFile.Name = "labelSearchForFile";
            this.labelSearchForFile.Size = new System.Drawing.Size(72, 13);
            this.labelSearchForFile.TabIndex = 7;
            this.labelSearchForFile.Text = "Search for file";
            // 
            // tabControlCobraCustomer
            // 
            this.tabControlCobraCustomer.Controls.Add(this.FileToText);
            this.tabControlCobraCustomer.Controls.Add(this.CobraCustomer);
            this.tabControlCobraCustomer.Location = new System.Drawing.Point(2, 3);
            this.tabControlCobraCustomer.Name = "tabControlCobraCustomer";
            this.tabControlCobraCustomer.SelectedIndex = 0;
            this.tabControlCobraCustomer.Size = new System.Drawing.Size(1096, 803);
            this.tabControlCobraCustomer.TabIndex = 8;
            // 
            // FileToText
            // 
            this.FileToText.Controls.Add(this.textBoxFileName);
            this.FileToText.Controls.Add(this.labelFiletoText);
            this.FileToText.Controls.Add(this.labelSearchForFile);
            this.FileToText.Controls.Add(this.buttonFindFile);
            this.FileToText.Controls.Add(this.buttonOpenFile);
            this.FileToText.Controls.Add(this.textBoxTotalFileName);
            this.FileToText.Controls.Add(this.textBoxFile_Name);
            this.FileToText.Location = new System.Drawing.Point(4, 22);
            this.FileToText.Name = "FileToText";
            this.FileToText.Padding = new System.Windows.Forms.Padding(3);
            this.FileToText.Size = new System.Drawing.Size(1088, 777);
            this.FileToText.TabIndex = 0;
            this.FileToText.Text = "File To Text";
            this.FileToText.UseVisualStyleBackColor = true;
            this.FileToText.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // CobraCustomer
            // 
            this.CobraCustomer.Controls.Add(this.dataGridView1);
            this.CobraCustomer.Controls.Add(this.buttonGetAllCobraCustomers);
            this.CobraCustomer.Location = new System.Drawing.Point(4, 22);
            this.CobraCustomer.Name = "CobraCustomer";
            this.CobraCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.CobraCustomer.Size = new System.Drawing.Size(1088, 777);
            this.CobraCustomer.TabIndex = 1;
            this.CobraCustomer.Text = "tabPage2";
            this.CobraCustomer.UseVisualStyleBackColor = true;
            this.CobraCustomer.Click += new System.EventHandler(this.CobraCustomer_Click);
            // 
            // buttonGetAllCobraCustomers
            // 
            this.buttonGetAllCobraCustomers.Location = new System.Drawing.Point(29, 39);
            this.buttonGetAllCobraCustomers.Name = "buttonGetAllCobraCustomers";
            this.buttonGetAllCobraCustomers.Size = new System.Drawing.Size(163, 23);
            this.buttonGetAllCobraCustomers.TabIndex = 0;
            this.buttonGetAllCobraCustomers.Text = "Get All Cobra Customers";
            this.buttonGetAllCobraCustomers.UseVisualStyleBackColor = true;
            this.buttonGetAllCobraCustomers.Click += new System.EventHandler(this.buttonGetAllCobraCustomers_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(145, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(652, 395);
            this.dataGridView1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 809);
            this.Controls.Add(this.tabControlCobraCustomer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControlCobraCustomer.ResumeLayout(false);
            this.FileToText.ResumeLayout(false);
            this.FileToText.PerformLayout();
            this.CobraCustomer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonFindFile;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.TextBox textBoxFile_Name;
        private System.Windows.Forms.TextBox textBoxTotalFileName;
        private System.Windows.Forms.Label labelFiletoText;
        private System.Windows.Forms.Label labelSearchForFile;
        private System.Windows.Forms.TabControl tabControlCobraCustomer;
        private System.Windows.Forms.TabPage FileToText;
        private System.Windows.Forms.TabPage CobraCustomer;
        private System.Windows.Forms.Button buttonGetAllCobraCustomers;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

