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
        public static void CreateEmployee(string NO_, string FN, string LN, string JT)
        {
            WebReff.WebService client = new WebReff.WebService();
            client.CreateEmployee(NO_, FN, LN, JT);
        }

        public static string[][] GetAllEmployees()
        {
            WebReff.WebService client = new WebReff.WebService();
            return client.GetAllEmployees();
        }
        public static void UpdateEmployee(string NO_, string FN, string LN, string JT)
        {
            WebReff.WebService client = new WebReff.WebService();
            client.UpdateEmployee(NO_, FN, LN, JT);
        }
        public static void DeleteEmployee(string NO_)
        {
            WebReff.WebService client = new WebReff.WebService();
            client.DeleteEmployee(NO_);
        }

    }
}
