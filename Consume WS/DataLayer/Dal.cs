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

        public static List<> GetCustomers()
        {
            WebReff.WebService client = new WebReff.WebService();
            client.FindAllCustomers().ToList<>;
            string hello = client.HelloWorld();
            return hello;

        }
    }
}
