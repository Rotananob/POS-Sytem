using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1.Models
{
    internal class SupplierMeun
    {
        public void ShowMenu()
        {
            int option;
            do
            {

                Console.WriteLine("---------------------Supplier Menu------------------------");
                Console.WriteLine("1. Add Supplier");
                Console.WriteLine("2. Show Supplier");
                Console.WriteLine("3. Delete Supplier");
                Console.WriteLine("4. Serach Supplier");
                Console.WriteLine("5. Update Supplier");
                Console.WriteLine("6. Back to Main Menu");
                Console.WriteLine("---------------------------------------------------");
                Console.Write("Please choose an option: ");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Supplier supplier = new Supplier();
                        supplier.Add();
                        break;
                    case 2:
                        Supplier supplier1 = new Supplier();
                        supplier1.Show();
                        break;
                    case 3:
                        Supplier supplier2 = new Supplier();
                        supplier2.Delete();
                        break;
                    case 4:
                        Supplier supplier3 = new Supplier();
                        supplier3.Search();
                        break;
                    case 5:
                        Customer customer4 = new Customer();
                        customer4.Update();
                        break;
                }
            } while (option != 6);
        }
    }
}
