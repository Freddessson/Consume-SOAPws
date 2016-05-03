using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataLayer
{
    public class Dal
    {
      
        public static string GetContent(string fileName)
        {
            WebReff.WebService client = new WebReff.WebService();
            
            string data = client.GetContent(fileName);
            return data;
        }
        public static string GetHelloo()
       {
            WebReff.WebService client = new WebReff.WebService();
            string hello = client.HelloWorld(); 
            return hello; 
            
        }
        public static string GetHello()
        {
            ServiceReference123.WebServiceSoapClient client2 = new ServiceReference123.WebServiceSoapClient();
            string hello = client2.HelloWorld();
            return hello;

        }

        public static List<WebReff.Customer> GetCustomers() { 
            
            WebReff.WebService client = new WebReff.WebService();
            List<WebReff.Customer> customerList = new List<WebReff.Customer>();
            customerList = client.FindAllCustomers().ToList<WebReff.Customer>();

            return customerList;


        }

        /*public static List<> GetCustomers()
        {
            WebReff.WebService client = new WebReff.WebService();
            client.FindAllCustomers().ToList<>;
            string hello = client.HelloWorld();
            return hello;

        }*/
    }
}
