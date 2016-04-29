using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    
    public class Class1
    {
        //private ServiceRef.WebServiceSoapClient client = new ServiceRef.WebServiceSoapClient();
        public static string GetHelloo()
        {
            WebReff.WebService myWebbservice = new WebReff.WebService();

            
            string hello = myWebbservice.HelloWorld();
            



            return hello;
        }
        public static string GetHello()
        {
            string hello = ClassLibrary1.Class1.GetHelloo();
            return hello;
        }

    }
}
