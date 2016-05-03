using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataLayer
{
    public class ConsoleDAL
    {
        public static string GetContent(string fileName)
        {
            WebService client = new WebService();

            string data = client.GetContent(fileName);
            
            return data;
        }
        public static string GetHelloo()
        {
            WebService client = new WebService();
            string hello = client.HelloWorld();
            return hello;

        }
        public static List<Customer> GetCustomers()
        {

            WebService client = new WebService();
          
            List<Customer> customerList = new List<Customer>();
            customerList = client.FindAllCustomers().ToList<Customer>();

            return customerList;
        }
    }
}
