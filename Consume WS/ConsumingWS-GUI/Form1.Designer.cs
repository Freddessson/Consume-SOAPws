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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonGetAllCobraCustomers = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.labelMessage = new System.Windows.Forms.Label();
            this.buttonGetSelected = new System.Windows.Forms.Button();
            this.comboBoxCronus = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.buttonAllEmployees = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.labelJobTitle = new System.Windows.Forms.Label();
            this.textBoxJobTitle = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelNo_ = new System.Windows.Forms.Label();
            this.textBoxNo_ = new System.Windows.Forms.TextBox();
            this.buttonCreateEmployee = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
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
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
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
            this.tabPage1.Text = "Read File";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.buttonGetAllCobraCustomers);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(730, 450);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Get Cobra Customers";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(70, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 277);
            this.dataGridView1.TabIndex = 1;
            // 
            // buttonGetAllCobraCustomers
            // 
            this.buttonGetAllCobraCustomers.Location = new System.Drawing.Point(70, 52);
            this.buttonGetAllCobraCustomers.Name = "buttonGetAllCobraCustomers";
            this.buttonGetAllCobraCustomers.Size = new System.Drawing.Size(201, 23);
            this.buttonGetAllCobraCustomers.TabIndex = 0;
            this.buttonGetAllCobraCustomers.Text = "Get All Cobra Customers";
            this.buttonGetAllCobraCustomers.UseVisualStyleBackColor = true;
            this.buttonGetAllCobraCustomers.Click += new System.EventHandler(this.buttonGetAllCobraCusotmers_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.labelMessage);
            this.tabPage3.Controls.Add(this.buttonGetSelected);
            this.tabPage3.Controls.Add(this.comboBoxCronus);
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(730, 450);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Cronus DB";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(153, 52);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(0, 13);
            this.labelMessage.TabIndex = 5;
            // 
            // buttonGetSelected
            // 
            this.buttonGetSelected.Location = new System.Drawing.Point(156, 15);
            this.buttonGetSelected.Name = "buttonGetSelected";
            this.buttonGetSelected.Size = new System.Drawing.Size(75, 23);
            this.buttonGetSelected.TabIndex = 4;
            this.buttonGetSelected.Text = "Get selected";
            this.buttonGetSelected.UseVisualStyleBackColor = true;
            this.buttonGetSelected.Click += new System.EventHandler(this.buttonGetSelected_Click);
            // 
            // comboBoxCronus
            // 
            this.comboBoxCronus.FormattingEnabled = true;
            this.comboBoxCronus.Items.AddRange(new object[] {
            "Metadata/Employee",
            "Relatives",
            "Sick employees (2004)",
            "Sick employees (first name)",
            "All keys",
            "All indexes",
            "All table constraints",
            "All tables",
            "All tables 2",
            "All columns (employee)",
            "All columns (employee) 2"});
            this.comboBoxCronus.Location = new System.Drawing.Point(5, 15);
            this.comboBoxCronus.Name = "comboBoxCronus";
            this.comboBoxCronus.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCronus.TabIndex = 3;
            this.comboBoxCronus.SelectedIndexChanged += new System.EventHandler(this.comboBoxCronus_SelectedIndexChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView2.Location = new System.Drawing.Point(22, 131);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(662, 266);
            this.dataGridView2.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.buttonDelete);
            this.tabPage4.Controls.Add(this.buttonUpdate);
            this.tabPage4.Controls.Add(this.buttonAllEmployees);
            this.tabPage4.Controls.Add(this.dataGridView3);
            this.tabPage4.Controls.Add(this.labelJobTitle);
            this.tabPage4.Controls.Add(this.textBoxJobTitle);
            this.tabPage4.Controls.Add(this.textBoxLastName);
            this.tabPage4.Controls.Add(this.labelLastName);
            this.tabPage4.Controls.Add(this.labelFirstName);
            this.tabPage4.Controls.Add(this.textBoxFirstName);
            this.tabPage4.Controls.Add(this.labelNo_);
            this.tabPage4.Controls.Add(this.textBoxNo_);
            this.tabPage4.Controls.Add(this.buttonCreateEmployee);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(730, 450);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Cronus DB 2";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // buttonAllEmployees
            // 
            this.buttonAllEmployees.Location = new System.Drawing.Point(237, 279);
            this.buttonAllEmployees.Name = "buttonAllEmployees";
            this.buttonAllEmployees.Size = new System.Drawing.Size(93, 23);
            this.buttonAllEmployees.TabIndex = 10;
            this.buttonAllEmployees.Text = "All Employees";
            this.buttonAllEmployees.UseVisualStyleBackColor = true;
            this.buttonAllEmployees.Click += new System.EventHandler(this.buttonAllEmployees_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(237, 21);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(484, 251);
            this.dataGridView3.TabIndex = 9;
            // 
            // labelJobTitle
            // 
            this.labelJobTitle.AutoSize = true;
            this.labelJobTitle.Location = new System.Drawing.Point(27, 118);
            this.labelJobTitle.Name = "labelJobTitle";
            this.labelJobTitle.Size = new System.Drawing.Size(47, 13);
            this.labelJobTitle.TabIndex = 8;
            this.labelJobTitle.Text = "Job Title";
            // 
            // textBoxJobTitle
            // 
            this.textBoxJobTitle.Location = new System.Drawing.Point(106, 112);
            this.textBoxJobTitle.Name = "textBoxJobTitle";
            this.textBoxJobTitle.Size = new System.Drawing.Size(100, 20);
            this.textBoxJobTitle.TabIndex = 7;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(106, 85);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastName.TabIndex = 6;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(27, 91);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(58, 13);
            this.labelLastName.TabIndex = 5;
            this.labelLastName.Text = "Last Name";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(27, 64);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(57, 13);
            this.labelFirstName.TabIndex = 4;
            this.labelFirstName.Text = "First Name";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(106, 58);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirstName.TabIndex = 3;
            // 
            // labelNo_
            // 
            this.labelNo_.AutoSize = true;
            this.labelNo_.Location = new System.Drawing.Point(24, 34);
            this.labelNo_.Name = "labelNo_";
            this.labelNo_.Size = new System.Drawing.Size(27, 13);
            this.labelNo_.TabIndex = 2;
            this.labelNo_.Text = "No_";
            // 
            // textBoxNo_
            // 
            this.textBoxNo_.Location = new System.Drawing.Point(106, 31);
            this.textBoxNo_.Name = "textBoxNo_";
            this.textBoxNo_.Size = new System.Drawing.Size(100, 20);
            this.textBoxNo_.TabIndex = 1;
            // 
            // buttonCreateEmployee
            // 
            this.buttonCreateEmployee.Location = new System.Drawing.Point(106, 147);
            this.buttonCreateEmployee.Name = "buttonCreateEmployee";
            this.buttonCreateEmployee.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateEmployee.TabIndex = 0;
            this.buttonCreateEmployee.Text = "Create Employee";
            this.buttonCreateEmployee.UseVisualStyleBackColor = true;
            this.buttonCreateEmployee.Click += new System.EventHandler(this.buttonCreateEmployee_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(345, 279);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(120, 23);
            this.buttonUpdate.TabIndex = 11;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(471, 279);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(106, 23);
            this.buttonDelete.TabIndex = 12;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 478);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonGetAllCobraCustomers;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox comboBoxCronus;
        private System.Windows.Forms.Button buttonGetSelected;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label labelJobTitle;
        private System.Windows.Forms.TextBox textBoxJobTitle;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelNo_;
        private System.Windows.Forms.TextBox textBoxNo_;
        private System.Windows.Forms.Button buttonCreateEmployee;
        private System.Windows.Forms.Button buttonAllEmployees;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
    }
}

