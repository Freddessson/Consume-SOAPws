using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace Controller
{
    public class CronusController
    {
        public string[][] GetCronusEmployees()
        {
            return CronusDAL.GetCronusEmployees();
        }
        public string[][] GetCronusMetadata()
        {
            return CronusDAL.GetCronusMetadata();
        }
        public string[][] GetCronus(string parameter)
        {
            return CronusDAL.GetCronus(parameter);
        }
        public void CreateEmployee(string NO_, string FN, string LN, string JT)
        {
            CronusDAL.CreateEmployee(NO_, FN, LN, JT);
        }
        public string[][] GetAllEmployees()
        {
            return CronusDAL.GetAllEmployees();
        }
        public void UpdateEmployee(string NO_, string FN, string LN, string JT)
        {
            CronusDAL.UpdateEmployee(NO_, FN, LN, JT);
        }
        public void DeleteEmployee(string NO_)
        {
            CronusDAL.DeleteEmployee(NO_);
        }
    }
}
