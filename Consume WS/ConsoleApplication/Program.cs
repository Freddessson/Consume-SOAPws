using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            string selection;
            Controller.ConsoleController controller = new Controller.ConsoleController();
            do
            {
                Console.WriteLine("1=Read File 2=Get Cobra Customer names 3=Close application");
                Console.Write("Please enter your selection: ");
                selection = Console.ReadLine(); switch (selection)
                {
                    case "1":

                        
                        Console.WriteLine("Seach for file: ");
                        string searchFile = Console.ReadLine();
                        Console.WriteLine(controller.GetContent(searchFile));
                        Console.WriteLine("--------------------------------\n");

                        break;
                    case "2":

                        List<Customer> customerList = new List<Customer>();
                        
                        customerList = controller.GetCustomers();
                        foreach (Customer c in customerList)
                        {
                            Console.WriteLine(c.name);
                        }
                        Console.WriteLine("--------------------------------\n");
                        break;

                    default:
                        Console.WriteLine("Invalid selection. Please select 1, 2, or 3.");
                        break;
                }
            } while (selection != "3");


        }
        
    }
}
    
