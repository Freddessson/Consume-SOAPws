using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class ConsoleController
    {
        public string GetContent(string fileName)
        {
            return DataLayer.ConsoleDAL.GetContent(fileName);
        }
        public List<Customer> GetCustomers()
        {
            return DataLayer.ConsoleDAL.GetCustomers();

        }
    }
}
