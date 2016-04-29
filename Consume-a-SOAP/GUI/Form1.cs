using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Consume_a_SOAP;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Consume_a_SOAP.Form1.GetHelloo();
            label112.Text = ClassLibrary1.Class1.GetHello();
        }

        private void label112_Click(object sender, EventArgs e)
        {

        }
    }
}
