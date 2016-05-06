using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsumingWS_GUI;
using Controller;
using DataLayer;

namespace ConsumingWS_GUI
{
    public partial class Form1 : Form
    {

        //private static ControllerSoapClient client = new ControllerSoapClient();

        public Form1()
        {
            InitializeComponent();

            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.SelectionChanged += new EventHandler((s, e) =>
            {

            });
            dataGridView3.MultiSelect = false;

        }


        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(DataLayer.Dal.GetContent("UTS - kurser.txt")); 
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "TXT | *.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //textBoxFile_Name = ofd.FileName.ToString;
                textBoxFile_Name.Text = ofd.SafeFileName;
                textBoxFull_File_Name.Text = ofd.FileName;
                string fileName = textBoxFile_Name.Text;
                Controller.Controller controller = new Controller.Controller();
                Console.WriteLine(ofd.SafeFileName);
                labelDataResult.Text = controller.GetContent(ofd.SafeFileName);


            }
        }

        private void buttonFindFile_Click(object sender, EventArgs e)
        {
            Controller.Controller Controller = new Controller.Controller();
            labelDataResult.Text = Controller.GetContent(textBoxSearchForFile.Text);
            //Controller.Controller Controller = new Controller.Controller();
            //labelDataResult.Text = Controller.Controller.GetHelloo();


            //ServiceReference2.WebServiceSoapClient ws = new ServiceReference2.WebServiceSoapClient();
            //string fileName = textBoxFileName.Text;
            //labelFiletoText.Text = ws.GetContent(fileName);
        }

        private void textBoxFull_File_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSearchForFile_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void buttonGetAllCobraCusotmers_Click(object sender, EventArgs e)
        {
            Controller.Controller Controller = new Controller.Controller();

            DataTable dt = new DataTable();
            dataGridView1.DataSource = dt;
            dataGridView1.ClearSelection();
            dt.Columns.Add("Name");
            dt.Columns.Add("Pnr");
            dt.Columns.Add("Email");
            dt.Columns.Add("Phone");
            dt.Columns.Add("Address");


            foreach (DataLayer.WebReff.Customer c in Controller.GetCustomers())
            {
                DataRow row = dt.NewRow();
                row["Name"] = c.name;
                row["Pnr"] = c.pnr;
                row["Email"] = c.email;
                row["Phone"] = c.phone;
                row["Address"] = c.address;
                dt.Rows.Add(row);
            }

        }

        /*private void btnGetCronusEmployees_Click(object sender, EventArgs e)
        {

            CronusController controller = new CronusController();

            DataTable dt = new DataTable();
            dataGridView2.DataSource = dt;
            dataGridView2.ClearSelection();


            dt.Columns.Add("No_");
            dt.Columns.Add("First Name");
            dt.Columns.Add("Last Name");
            dt.Columns.Add("Job Title");
            dt.Columns.Add("Address");

            //List<string> cronusList = new List<string>();

            string[][] cronusList = controller.GetCronusEmployees();

            foreach (string[] row in cronusList)
            {
                dt.Rows.Add(row);
            }
        }*/

        /*private void buttonGetMetadata_Click(object sender, EventArgs e)
        {
            CronusController controller = new CronusController();

            DataTable dt = new DataTable();
            dataGridView2.DataSource = dt;
            dataGridView2.ClearSelection();

            // NAMN?
            dt.Columns.Add("No_");
            dt.Columns.Add("First Name");
            dt.Columns.Add("Last Name");
            dt.Columns.Add("Job Title");
            dt.Columns.Add("Address");

            //List<string> cronusList = new List<string>();

            string[][] cronusList = controller.GetCronusMetadata();

            foreach (string[] row in cronusList)
            {
                dt.Rows.Add(row);
            }

        }*/

        private void comboBoxCronus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonGetSelected_Click(object sender, EventArgs e)
        {

            CronusController controller = new CronusController();
            if (String.IsNullOrEmpty(comboBoxCronus.Text))
            {
                labelMessage.Text = "Choose please!";
            }
            else
            {
                DataTable dt = new DataTable();
                dataGridView2.DataSource = dt;
                string parameter = comboBoxCronus.Text;
                // string[][] cronusList = controller.GetCronus(parameter);
                string[][] cronusList = null;

                if (parameter.Equals("Metadata/Employee"))
                {

                    dataGridView2.ClearSelection();
                    dt.Columns.Add("No_");
                    dt.Columns.Add("First Name");
                    dt.Columns.Add("Last Name");
                    dt.Columns.Add("Job Title");
                    dt.Columns.Add("Is NUllable");
                    dt.Columns.Add("Data Type");
                    parameter = "metadata/employee";
                    cronusList = controller.GetCronus(parameter);
                    foreach (string[] row in cronusList)
                    {
                        dt.Rows.Add(row);
                    }
                }
                if (parameter.Equals("Relatives"))
                {

                    dataGridView2.ClearSelection();
                    dt.Columns.Add("Employee No");
                    dt.Columns.Add("First Name");
                    dt.Columns.Add("Last Name");
                    dt.Columns.Add("Relative Code");
                    dt.Columns.Add("Relative First Name");
                    dt.Columns.Add("Relative Last Name");
                    parameter = "relatives";
                    cronusList = controller.GetCronus(parameter);
                    foreach (string[] row in cronusList)
                    {
                        dt.Rows.Add(row);
                    }

                }
                if (parameter.Equals("Sick employees (2004)"))
                {
                    parameter = "sickEmployees";
                    dataGridView2.ClearSelection();
                    dt.Columns.Add("Employee No");
                    dt.Columns.Add("First Name");
                    dt.Columns.Add("Last Name");
                    dt.Columns.Add("Desciption");
                    cronusList = controller.GetCronus(parameter);
                    foreach (string[] row in cronusList)
                    {
                        dt.Rows.Add(row);
                    }
                }
                if (parameter.Equals("Sick employees (first name)"))
                {
                    parameter = "sickEmployeesFirstName";
                    dataGridView2.ClearSelection();
                    dt.Columns.Add("First Name");
                    cronusList = controller.GetCronus(parameter);
                    foreach (string[] row in cronusList)
                    {
                        dt.Rows.Add(row);
                    }
                }
                if (parameter.Equals("All keys"))
                {
                    parameter = "allKeys";
                    dataGridView2.ClearSelection();
                    dt.Columns.Add("Table Name");
                    dt.Columns.Add("Column Name");
                    cronusList = controller.GetCronus(parameter);
                    foreach (string[] row in cronusList)
                    {
                        dt.Rows.Add(row);
                    }
                }
                if (parameter.Equals("All indexes"))
                {
                    parameter = "allIndexes";
                    dataGridView2.ClearSelection();
                    dt.Columns.Add("Object Id");
                    dt.Columns.Add("Index Id");
                    cronusList = controller.GetCronus(parameter);
                    foreach (string[] row in cronusList)
                    {
                        dt.Rows.Add(row);
                    }
                }
                if (parameter.Equals("All table constraints"))
                {
                    parameter = "allTableConstraints";
                    dataGridView2.ClearSelection();
                    dt.Columns.Add("Constraint Name");
                    cronusList = controller.GetCronus(parameter);
                    foreach (string[] row in cronusList)
                    {
                        dt.Rows.Add(row);
                    }
                }
                if (parameter.Equals("All tables"))
                {
                    parameter = "allTables";
                    dataGridView2.ClearSelection();
                    dt.Columns.Add("Table Name");
                    cronusList = controller.GetCronus(parameter);
                    foreach (string[] row in cronusList)
                    {
                        dt.Rows.Add(row);
                    }
                }
                if (parameter.Equals("All tables 2"))
                {
                    parameter = "allTables2";
                    dataGridView2.ClearSelection();
                    dt.Columns.Add("Table Name");
                    cronusList = controller.GetCronus(parameter);
                    foreach (string[] row in cronusList)
                    {
                        dt.Rows.Add(row);
                    }
                }
                if (parameter.Equals("All columns (employee)"))
                {
                    parameter = "allColumnsEmployees";
                    dataGridView2.ClearSelection();
                    dt.Columns.Add("Column Name");
                    cronusList = controller.GetCronus(parameter);
                    foreach (string[] row in cronusList)
                    {
                        dt.Rows.Add(row);
                    }
                }
                if (parameter.Equals("All columns (employee) 2"))
                {
                    parameter = "allColumnsEmployees2";
                    dataGridView2.ClearSelection();
                    dt.Columns.Add("Column Name");
                    cronusList = controller.GetCronus(parameter);
                    foreach (string[] row in cronusList)
                    {
                        dt.Rows.Add(row);
                    }
                }
                else
                {
                    //labelMessage.Text = "Choose please!";
                    parameter = "wrong";
                }
                /*string[][] cronusList = controller.GetCronus(parameter);
                foreach (string[] row in cronusList)
                {
                    dt.Rows.Add(row);
                }*/

            }
        }

        private void buttonCreateEmployee_Click(object sender, EventArgs e)
        {
            CronusController controller = new CronusController();
            try
            {
                string NO_ = textBoxNo_.Text;
            string FN = textBoxFirstName.Text;
            string LN = textBoxLastName.Text;
            string JT = textBoxJobTitle.Text;

            


                controller.CreateEmployee(NO_, FN, LN, JT);

                textBoxNo_.Text = "";
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxJobTitle.Text = "";
                buttonAllEmployees.PerformClick();

            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void buttonAllEmployees_Click(object sender, EventArgs e)
        {
            CronusController controller = new CronusController();
            DataTable dt = new DataTable();
            dataGridView3.DataSource = dt;
            string[][] cronusList = controller.GetAllEmployees();

            dataGridView3.ClearSelection();
            dt.Columns.Add("No_");
            dt.Columns.Add("First Name");
            dt.Columns.Add("Last Name");
            dt.Columns.Add("Job Title");
            
            cronusList = controller.GetAllEmployees();
            foreach (string[] row in cronusList)
            {
                dt.Rows.Add(row);
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            CronusController controller = new CronusController();
            if (dataGridView3.RowCount > 0)
            {
                DataGridViewRow row = dataGridView3.SelectedRows[0];

                string NO_ = row.Cells["No_"].Value.ToString();
                string FN = row.Cells["First Name"].Value.ToString();
                string LN = row.Cells["Last Name"].Value.ToString();
                string JT = row.Cells["Job Title"].Value.ToString();


                controller.UpdateEmployee(NO_, FN, LN, JT);
                dataGridView3.ClearSelection();
                buttonAllEmployees.PerformClick();

              
            }
            else
            {
                Console.WriteLine("Kunde inte uppdatera employee");
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            CronusController controller = new CronusController();
            if (dataGridView3.RowCount > 0)
            {
                DataGridViewRow row = dataGridView3.SelectedRows[0];

                string NO_ = row.Cells["No_"].Value.ToString();

                controller.DeleteEmployee(NO_);
                dataGridView3.ClearSelection();
                buttonAllEmployees.PerformClick();

            }
            else
            {
                Console.WriteLine("Kunde inte ta bort employee");
            }

        }
    }
}
