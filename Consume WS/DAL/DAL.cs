using DAL;
using DAL.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class DAL
    {
        public static Customer[] FindAllCustomers()
        {
            ServiceReference1.WebServiceSoapClient ws = new ServiceReference1.WebServiceSoapClient();
            ws.HelloWorld();
            
            //Customer[] customerList = ws.FindAllCustomers();

           
           
            //return customerList;
        }
        public static void GetContentRequest(string fileName)
        {
            ServiceReference1.WebServiceSoapClient ws = new ServiceReference1.WebServiceSoapClient();
            //string fileName = textBoxFileName.Text;
            //labelFiletoText.Text = ws.GetContent(fileName);
        }

    }
}
