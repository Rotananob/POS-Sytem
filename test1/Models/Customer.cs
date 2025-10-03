using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1.Models
{
    internal class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Tel { get; set; }

        public static List<Customer> customerList = new List<Customer>();

        public void Add()
        {
            Console.WriteLine("----------Customer Information----------");
            int n;
            Console.Write("Input N: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Customer customer = new Customer();
                Console.Write("Input Id: ");
                customer.Id = int.Parse(Console.ReadLine());
                Console.Write("Input Name: ");
                customer.Name = Console.ReadLine();
                Console.Write("Input Gender: ");
                customer.Gender = Console.ReadLine();
                Console.Write("Input Tel: ");
                customer.Tel = Console.ReadLine();
                customerList.Add(customer);
                Console.WriteLine("------------------------------------------");
                Console.WriteLine();
            }
        }
        public void Show()
        {
            string columnHeader, dataRecord;
            Console.WriteLine("----------------------------Product List----------------------------------------");
            columnHeader = string.Format("{0,-10}{1,-15}{2,-15}{3,-15}",
                "Id", "Name", "Gender", "tel");
            Console.WriteLine(columnHeader);
            Console.WriteLine("--------------------------------------------------------------------------------");
            foreach (Customer customer in customerList)
            {
                dataRecord = string.Format("{0,-10}{1,-15}{2,-15}{3,-15}",
                    customer.Id, customer.Name, customer.Gender, customer.Tel);
                Console.WriteLine(dataRecord);
                Console.WriteLine("-------------------------------------------------------------------------------");
            }
        }
        public void Detele()
        {
            Console.WriteLine("Remove By Id= ");
            this.Id = int.Parse(Console.ReadLine());
            foreach (Customer customer in customerList)
            {
                if (customer.Id == this.Id)
                {
                    customerList.RemoveAt(customer.Id);
                    Console.WriteLine("The Customer have been deleted");
                    break;
                }
            }
        }
        public void Search()
        {
            List<Customer> customerlist1 = new List<Customer>();
            Console.WriteLine("Search By Id= ");
            this.Id = int.Parse(Console.ReadLine());
            foreach (Customer customer in customerList)
            {
                if (customer.Id == this.Id)
                {
                    customerlist1.Add(customer);
                }
            }
            string columnHeader, dataRecord;
            Console.WriteLine("----------------------------Product List----------------------------------------");
            columnHeader = string.Format("{0,-10}{1,-15}{2,-15}{3,-15}",
                "Id", "Name", "Gender", "tel");
            Console.WriteLine(columnHeader);
            Console.WriteLine("--------------------------------------------------------------------------------");
            foreach (Customer customer in customerlist1)
            {
                dataRecord = string.Format("{0,-10}{1,-15}{2,-15}{3,-15}",
                    customer.Id, customer.Name, customer.Gender, customer.Tel);
                Console.WriteLine(dataRecord);
                Console.WriteLine("-------------------------------------------------------------------------------");
            }
        }
        public void Update()
        {
            Console.WriteLine("-----------Update Customer Information--------------");
            Console.Write("Search By Id: ");
            int searchId = int.Parse(Console.ReadLine());

            foreach (Customer customer in customerList)
            {
                if (customer.Id == searchId)
                {
                    Console.WriteLine("Customer found. Leave fields blank to keep the current value.");
                    Console.Write("Name (current: " + customer.Name + "): ");
                    string newName = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(newName))
                    {
                        customer.Name = newName;
                    }
                    Console.Write("Gender (current: " + customer.Gender + "): ");
                    string newGender = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(newGender))
                    {
                        customer.Gender = newGender;
                    }
                    Console.Write("Tel (current: " + customer.Tel + "): ");
                    string newTel = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(newTel))
                    {
                        customer.Tel = newTel;
                    }
                    Console.WriteLine("Customer information has been updated.");
                    return; 
                }
            }

            Console.WriteLine("Customer with the specified Id not found.");
        }

    }
}
