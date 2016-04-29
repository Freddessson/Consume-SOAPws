using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataLayer
{
    public class Dal
    {
        //private static ServiceReference2.WebServiceSoapClient client = new ServiceReference2.WebServiceSoapClient();

        

        public static string GetContent(string fileName)
        {
            WebReff.WebService client = new WebReff.WebService();
            
            string data = client.GetContent(fileName);
            return data;
        }
        public static string GetHelloo()
       {

            //Console.WriteLine(client.HelloWorld());
            WebReff.WebService client = new WebReff.WebService();
            string hello = client.HelloWorld(); 
            return hello; 
            
            
            /*try
            {
                
            WebServiceSoapClient ws = new WebServiceSoapClient();
            Console.WriteLine(ws.HelloWorld()); 
            string hello = ws.HelloWorld();
                return hello;
            }
            
            catch (Exception e)
            {

                Console.WriteLine(e);
                
            }
            string returnshit="";
            return returnshit;*/

        }
    }
}
