using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1.Models
{
    internal class CustomerMeun
    {
        public void ShowMenu()
        {
            int option;
            do
            {

                Console.WriteLine("---------------------Customer Menu------------------------");
                Console.WriteLine("1. Add Customer");
                Console.WriteLine("2. Show Customer");
                Console.WriteLine("3. Delete Customer");
                Console.WriteLine("4. Serach Customer");
                Console.WriteLine("5. Update Customer");
                Console.WriteLine("6. Back to Main Menu");
                Console.WriteLine("---------------------------------------------------");
                Console.Write("Please choose an option: ");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Customer customer = new Customer();
                        customer.Add();
                        break;
                    case 2:
                        Customer customer1 = new Customer();
                        customer1.Show();
                        break;
                    case 3:
                        Customer customer2 = new Customer();
                        customer2.Detele();
                        break;
                    case 4:
                        Customer customer3 = new Customer();
                        customer3.Search();
                        break;
                    case 5:
                        Customer customer4 = new Customer();
                        customer4.Detele();
                        break;
                }
            } while (option != 6);
        }
    }
}
