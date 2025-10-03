using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace test1.Models
{

    internal class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static List<Category> categoryList = new List<Category>();

        public void Add()
        {
            Console.WriteLine("----------Category List----------------");
            int n;
            Console.Write("Input N: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Category category = new Category();
                Console.Write("Input Id= ");
                category.Id = int.Parse(Console.ReadLine());
                Console.Write("Input Name: ");
                category.Name = Console.ReadLine();
                categoryList.Add(category);
                Console.WriteLine("-----------------------------------");
                Console.WriteLine();
            }
        }
        public void Show()
        {
            string columnHeader, dataRecord;
            Console.WriteLine("-------------------Product List-----------------");
            columnHeader = string.Format("{0,-10}{1,-15}",
                "Id", "Name");
            Console.WriteLine(columnHeader);
            Console.WriteLine("------------------------------------------------");
            foreach (Category category in categoryList)
            {
                dataRecord = string.Format("{0,-10}{1,-15}", category.Id, category.Name);
                Console.WriteLine(dataRecord);
                Console.WriteLine("--------------------------------------------");
            }
        }
        public void Detele()
        {
            Console.Write("Remove By Id");
            this.Id = int.Parse(Console.ReadLine());
            foreach (Category category in categoryList)
            {
                if (category.Id == this.Id)
                {
                    categoryList.Remove(category);
                    Console.WriteLine("Category have been Remove");
                    break;
                }
            }
        }
        public void Search()
        {
            List<Category> categoryList1 = new List<Category>();
            Console.Write("Search By Id= ");
            this.Id = int.Parse(Console.ReadLine());
            foreach (Category categoy in categoryList)
            {
                if (categoy.Id == this.Id)
                {
                    categoryList1.Add(categoy);
                }
            }
            {
                string columnHeader, dataRecord;
                Console.WriteLine("-------------------Product List-----------------");
                columnHeader = string.Format("{0,-10}{1,-15}", "Id", "Name");
                Console.WriteLine(columnHeader);
                Console.WriteLine("------------------------------------------------");
                foreach (Category categoy in categoryList1)
                {
                    dataRecord = string.Format("{0,-10}{1,-15}", categoy.Id, categoy.Name);
                    Console.WriteLine(dataRecord);
                    Console.WriteLine("------------------------------------------------");
                }
            }
        }
        public void Update()
        {
            Console.WriteLine("-----------Update Customer Information--------------");
            Console.Write("Search By Id: ");
            int searchId = int.Parse(Console.ReadLine());

            foreach (Category category in categoryList)
            {
                if (category.Id == searchId)
                {
                    Console.WriteLine("Customer found. Leave fields blank to keep the current value.");
                    // Update Gender
                    Console.Write("Gender (current: " + category.Id+ "): ");
                    string newId = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(newId))
                    {
                        category.Name = newId;
                    }
                    // Update Name
                    Console.Write("Name (current: " + category.Name + "): ");
                    string newName = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(newName))
                    {
                        category.Name = newName;
                    }

                    Console.WriteLine("Customer information has been updated.");
                    return; // Exit after update
                }
            }

            Console.WriteLine("Customer with the specified Id not found.");
        }

    }

}


