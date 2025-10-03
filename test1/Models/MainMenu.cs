using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1.Models
{
    internal class MainMenu
    {
        public void Menu()
        {
                int option;
            do
            {
                Console.WriteLine("--------------------------POS System-----------------------");
                Console.WriteLine("1. Product");
                Console.WriteLine("2. Category");
                Console.WriteLine("3. User");
                Console.WriteLine("4. Customer");
                Console.WriteLine("5. Supplier");
                Console.WriteLine("6. Exit");
                Console.WriteLine("------------------------------------------------------------");
                Console.Write("Please choose an option: ");

                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        ProductMenu productMenu = new ProductMenu();
                        productMenu.ShowMenu();
                        break;
                    case 2:
                        CategoryMeun categoyMeun = new CategoryMeun();
                        categoyMeun.ShowMenu();
                        break;
                    case 3:
                        UserMeun userMeun = new UserMeun();
                        userMeun.ShowMenu();
                        break;
                    case 4:
                        CustomerMeun customerMeun = new CustomerMeun();
                        customerMeun.ShowMenu();
                        break;
                    case 5:
                        SupplierMeun supplierMeun = new SupplierMeun();
                        supplierMeun.ShowMenu();
                        break;
                    case 6:
                        Console.WriteLine("Exiting...");
                        break;
                }
            } while (option != 6);
        }
    }
}
