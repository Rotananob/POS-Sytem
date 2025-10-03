using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace test1.Models
{
    internal class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }

        public static List<Supplier> supplierList = new List<Supplier>();

        public void Add()
        {
            Console.WriteLine("-----------------Supplier Information---------------");
            int n;
            Console.Write("Input N: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Supplier supplier = new Supplier();
                Console.Write("Input Id: ");
                supplier.Id = int.Parse(Console.ReadLine());
                Console.Write("Input Name: ");
                supplier.Name = Console.ReadLine();
                Console.Write("Input Address: ");
                supplier.Address = Console.ReadLine();
                Console.Write("Input Telephon: ");
                supplier.Telephone = Console.ReadLine();
                supplierList.Add(supplier);
                Console.WriteLine("------------------------------------------------------");
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
            foreach (Supplier supplier in supplierList)
            {
                dataRecord = string.Format("{0,-10}{1,-15}{2,-15}{3,-15}",
                    supplier.Id, supplier.Name, supplier.Address, supplier.Telephone);
                Console.WriteLine(dataRecord);
                Console.WriteLine("-------------------------------------------------------------------------------");
            }
        }
        public void Delete()
        {
            Console.Write("Remove By Id= ");
            this.Id = int.Parse(Console.ReadLine());
            foreach (Supplier supplier in supplierList)
            {
                if (supplier.Id == this.Id)
                {
                    supplierList.Remove(supplier);
                    Console.WriteLine("The supplier have been deleted");
                    break;
                }

            }
        }
        public void Search()
        {
            string columnHeader, dataRecord;
            Console.WriteLine("----------------------------Product List----------------------------------------");
            columnHeader = string.Format("{0,-10}{1,-15}{2,-15}{3,-15}",
                "Id", "Name", "Gender", "tel");
            Console.WriteLine(columnHeader);
            Console.WriteLine("--------------------------------------------------------------------------------");
            foreach (Supplier supplier in supplierList)
            {
                dataRecord = string.Format("{0,-10}{1,-15}{2,-15}{3,-15}",
                    supplier.Id, supplier.Name, supplier.Address, supplier.Telephone);
                Console.WriteLine(dataRecord);
                Console.WriteLine("-------------------------------------------------------------------------------");
            }
        }
        public void Update()
        {
            Console.WriteLine("-----------------Update Supplier Information------------------");
            Console.Write("Search by Id: ");
            int searchId = int.Parse(Console.ReadLine());

            foreach (Supplier supplier in supplierList)
            {
                if (supplier.Id == searchId)
                {
                    Console.WriteLine("Leave fields blank to keep the current value.");
                    Console.Write("Name (current: " + supplier.Name + "): ");
                    string newName = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(newName))
                    {
                        supplier.Name = newName;
                    }
                    Console.Write("Address (current: " + supplier.Address + "): ");
                    string newAddress = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(newAddress))
                    {
                        supplier.Address = newAddress;
                    }
                    Console.Write("Telephone (current: " + supplier.Telephone + "): ");
                    string newTelephone = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(newTelephone))
                    {
                        supplier.Telephone = newTelephone;
                    }
                    Console.WriteLine("Supplier information updated successfully.");
                    return;
                }
            }

            Console.WriteLine("Supplier with the specified Id not found.");
        }
    }
    
}


