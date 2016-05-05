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
            //Här blir vår List<List<string>> en array.
            string[][] cronusEmployeeList  = client.GetCronusEmployees();

            return cronusEmployeeList;
        }
        public static string[][] GetCronusMetadata()
        {

            WebReff.WebService client = new WebReff.WebService();
            //Här blir vår List<List<string>> en array.
            string[][] cronusMetadataList = client.GetCronusMetadata();

            return cronusMetadataList;
        }
        public static string[][] GetCronus(string parameter)
        {
            WebReff.WebService client = new WebReff.WebService();
            //Här blir vår List<List<string>> en array.
            string[][] cronusList = client.GetCronus(parameter);

            return cronusList;
        }

    }
}
