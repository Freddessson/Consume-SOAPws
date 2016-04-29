using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Consume_a_SOAP
{
    public partial class Form1 : Form
    {
        //ServiceReference.WebServiceSoapClient client = new ServiceReference.WebServiceSoapClient();


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //label1.Text = DAL.DAL.GetHelloo();


            //label1.Text = client.GetContent("UTS - kurser.txt");
            //DataLayer.DataLayer.GetHelloo();
            /*OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "TXT | *.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //textBoxFile_Name = ofd.FileName.ToString;
                textBoxFile_Name.Text = ofd.SafeFileName;
                textBoxFile_Name.Text = ofd.FileName;
                string fileName = textBoxFile_Name.Text;
                Controller.Controller Controller = new Controller.Controller();
                labelDataResult.Text = Controller.GetContent(fileName);
            }*/

           
        }
        /*public static string GetHelloo()
        {
           
            string hello = client.HelloWorld();
            client.HelloWorld();
            


            return hello;
        }*/

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
