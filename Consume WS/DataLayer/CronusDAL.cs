using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class CronusDAL
    {
        public static string[][] GetCronusEmployees()
        {

            WebReff.WebService client = new WebReff.WebService();
            //List<List<string>> cronusEmployeeList = new List<List<string>>();
            //Här blir vår List<List<string>> en array.
            string[][] cronusEmployeeList  = client.GetCronusEmployees();

            return cronusEmployeeList;


        }
    }
}
