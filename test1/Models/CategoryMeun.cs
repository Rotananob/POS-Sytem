using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1.Models
{
    internal class CategoryMeun
    {
        public void ShowMenu()
        {
            int option;
            do
            {

                Console.WriteLine("---------------------Category Menu------------------------");
                Console.WriteLine("1. Add Category");
                Console.WriteLine("2. Show Category");
                Console.WriteLine("3. Delete Category");
                Console.WriteLine("4. Serach Category");
                Console.WriteLine("5. Update Category");
                Console.WriteLine("6. Back to Main Menu");
                Console.WriteLine("---------------------------------------------------");
                Console.Write("Please choose an option: ");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Category category = new Category();
                        category.Add();
                        break;
                    case 2:
                        Category category1 = new Category();
                        category1.Show();
                        break;
                    case 3:
                        Category category2 = new Category();
                        category2.Detele();
                        break;
                    case 4:
                        Category category3 = new Category();
                        category3.Search();
                        break;
                    case 5:
                        Category category4 = new Category();
                        category4.Update();
                        break;
                }
            } while (option != 6);
        }

    }    
}
