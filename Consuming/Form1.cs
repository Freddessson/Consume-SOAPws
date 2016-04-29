using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace Consuming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ServiceReference1.WebServiceSoapClient ws = new ServiceReference1.WebServiceSoapClient();
            string fileName = textBoxFileName.Text;
            labelFiletoText.Text = ws.GetContent(fileName);

        }

        private void textBoxFileName_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "TXT | *.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //textBoxFile_Name = ofd.FileName.ToString;
                textBoxFile_Name.Text = ofd.SafeFileName;
                textBoxTotalFileName.Text = ofd.FileName;

                ServiceReference1.WebServiceSoapClient ws = new ServiceReference1.WebServiceSoapClient();
                string fileName = textBoxFile_Name.Text;
                labelFiletoText.Text = ws.GetContent(fileName);
            }
        }

        private void textBoxFile_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTotalFileName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void CobraCustomer_Click(object sender, EventArgs e)
        {

        }

        private void buttonGetAllCobraCustomers_Click(object sender, EventArgs e)
        {
            

            DataTable dt = new DataTable();
            dataGridView1.DataSource = dt;
            dataGridView1.ClearSelection();
            dt.Columns.Add("Name");
            dt.Columns.Add("Pnr");
            dt.Columns.Add("Email");
            dt.Columns.Add("Phone");
            dt.Columns.Add("Address");


            //ÄR det FUSK att låta Consuming ha tillgång till Cusotmer???
            foreach (Customer c in FindAllCustomers())
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

        private void labelCobraCustomerRS_Click(object sender, EventArgs e)
        {

        }
    }
}
