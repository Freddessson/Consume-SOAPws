using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Controller
{
    public class Controller
    {
        public string GetContent(string fileName)
        {

            //data = GetContent(fileName);

            string data = DataLayer.Dal.GetContent(fileName);
            return data;
        }
        public static string GetHelloo()
        {

            string hello = Dal.GetHelloo();
            return hello;
        }

        public List<DataLayer.WebReff.Customer> GetCustomers()
        {
            return Dal.GetCustomers();
        }

        /*public static string GetHello()
        {

            string hello = Dal.GetHello();
            return hello;
        }*/
    }
}
