using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1.Models
{
    internal class ProductMenu
    {
        public void ShowMenu()
        {
            int option;
            do
            {

                Console.WriteLine("---------------------Product Menu------------------------");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Show Product");
                Console.WriteLine("3. Delete Product");
                Console.WriteLine("4. Serach Product");
                Console.WriteLine("5. Update Product");
                Console.WriteLine("6. Back to Main Menu");
                Console.WriteLine("---------------------------------------------------");
                Console.Write("Please choose an option: ");
                option = int.Parse(Console.ReadLine());
                
                switch (option)
                {
                    case 1:
                        Product product = new Product();
                        product.Add();
                        break;
                    case 2:
                        Product product1 = new Product();
                        product1.Show();
                        break;
                    case 3:
                        Product product2 = new Product();
                        product2.Delete();
                        break;
                    case 4:
                        Product product3 = new Product();
                        product3.Search();
                        break;
                    case 5:
                        Product product4 = new Product();
                        product4.Update();
                        break;
                }
            } while (option != 6);
        }
    }
}
