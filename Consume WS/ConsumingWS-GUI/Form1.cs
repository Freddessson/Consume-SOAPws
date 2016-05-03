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

                labelDataResult.Text = Controller.Controller.GetHello();
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

        private void btnGetCronusEmployees_Click(object sender, EventArgs e)
        {

            CronusController controller = new CronusController();

            DataTable dt = new DataTable();
            dataGridView2.DataSource = dt;
            dataGridView2.ClearSelection();

            // NAMN?
            dt.Columns.Add("Name");
            dt.Columns.Add("Pnr");
            dt.Columns.Add("Email");
            dt.Columns.Add("Phone");
            dt.Columns.Add("Address");

            //List<string> cronusList = new List<string>();
            
            string[][] cronusList = controller.GetCronusEmployees();

            foreach(string[] row in cronusList)
            {
                dt.Rows.Add(row);
            }

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataLayer.ServiceReference123.WebServiceSoapClient client = new DataLayer.ServiceReference123.WebServiceSoapClient();
            labelDataResult.Text = client.HelloWorld();
        }
    }
}
