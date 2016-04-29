using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL
    {
        private static DALServiceReference.WebServiceSoapClient client = new DALServiceReference.WebServiceSoapClient();




        public static string GetContent(string fileName)
        {

            //ServiceReference2.GetContentRequest wsGc = new ServiceReference2.GetContentRequest();
            string data = client.GetContent(fileName);
            return data;
        }
        public static string GetHelloo()
        {

            Console.WriteLine(client.HelloWorld());
            string hello = client.HelloWorld();
            return hello;
        }
    }
}
