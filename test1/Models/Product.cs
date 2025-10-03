using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace test1.Models
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Barcode { get; set; }
        public decimal Unitprice { get; set; }
        public decimal Sellprice { get; set; }
        public int QtyInStock { get; set; }

        public static List<Product> productLists = new List<Product>();

        public void Add()
        {

            Console.WriteLine("--------------Product Information-------------");
            int n;
            Console.Write("Input N:");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Product product = new Product();
                Console.Write("Input Id= ");
                product.Id = int.Parse(Console.ReadLine());
                Console.Write("Input Name:");
                product.Name = Console.ReadLine();
                Console.Write("Input BarCode=");
                product.Barcode = int.Parse(Console.ReadLine());
                Console.Write("Input UnitPrice=");
                product.Unitprice = decimal.Parse(Console.ReadLine());
                Console.Write("Input SellPrice=");
                product.Sellprice = decimal.Parse(Console.ReadLine());
                Console.Write("Input QtyInSock=");
                product.QtyInStock = int.Parse(Console.ReadLine());
                productLists.Add(product);
                Console.Write("---------------------------------------");
                Console.WriteLine();
            }
        }
        public void Show()
        {
            string columHeader, dateRecord;
            Console.WriteLine("---------------------------Product List------------------------------------------");
            columHeader = string.Format("{0,-10}{1,-15}{2,-15}{3,-15}{4,-15}{5,-15}",
                "Id", "Name", "Barcode", "UnitPrice", "SellPrice", "QtyInStock");
            Console.WriteLine(columHeader);
            Console.WriteLine("---------------------------------------------------------------------------------");
            foreach (Product product in productLists)
            {
                dateRecord = string.Format("{0,-10}{1,-15}{2,-15}{3,-15}{4,-15}{5,-15}",
                product.Id, product.Name, product.Barcode, product.Unitprice, product.Sellprice, product.QtyInStock);
                Console.WriteLine(dateRecord);
                Console.WriteLine("---------------------------------------------------------------------------------");
            }
        }
        public void Delete()
        {
            Console.Write("Remove By Id=");
            this.Id = int.Parse(Console.ReadLine());
            foreach (Product product in productLists)
            {
                if (product.Id == this.Id)
                {
                    productLists.Remove(product);
                    Console.WriteLine("Product have been remove");
                    break;
                }
            }
        }
        public void Search()
        {
            List<Product> productsList1 = new List<Product>();
            Console.Write("Search By Id=");
            this.Id = int.Parse(Console.ReadLine());
            foreach (Product product in productLists)
            {
                if (product.Id == this.Id)
                {
                    productsList1.Add(product);
                }
            }
            {
                string columnHeader, dataRecord;
                Console.WriteLine("----------------------------Product List-------------------------------------------------");
                columnHeader = string.Format("{0,-10}{1,-15}{2,-15}{3,-15}{4,-15}{5,-15}",
                    "Id", "Name", "Barcode", "UnitPrice", "SellPrice", "QtyInStock");
                Console.WriteLine(columnHeader);
                Console.WriteLine("-----------------------------------------------------------------------------------------");
                foreach (Product product in productsList1)
                {
                    dataRecord = string.Format("{0,-10}{1,-15}{2,-15}{3,-15}{4,-15}{5,-15}",
                    product.Id, product.Name, product.Barcode, product.Unitprice, product.Sellprice, product.QtyInStock);
                    Console.WriteLine(dataRecord);
                    Console.WriteLine("-------------------------------------------------------------------------------");
                }
            }
        }
        public void Update()
        {
            Console.WriteLine("--------------Update Product-----------------");
            Console.Write("Search Id = ");
            this.Id = int.Parse(Console.ReadLine());

            foreach (Product product in productLists)
            {
                if (product.Id == this.Id)
                {
                    Console.WriteLine("Product found. Leave fields blank to keep the current value.");

                    // Update Name
                    Console.Write("Name (current: " + product.Name + "): ");
                    string newName = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(newName))
                    {
                        product.Name = newName;
                    }

                    // Update Barcode
                    Console.Write("Barcode (current: " + product.Barcode + "): ");
                    string newBarcode = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(newBarcode))
                    {
                        product.Barcode = int.Parse(newBarcode);
                    }

                    // Update UnitPrice
                    Console.Write("UnitPrice (current: " + product.Unitprice + "): ");
                    string newUnitPrice = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(newUnitPrice))
                    {
                        product.Unitprice = decimal.Parse(newUnitPrice);
                    }

                    // Update SellPrice
                    Console.Write("SellPrice (current: " + product.Sellprice + "): ");
                    string newSellPrice = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(newSellPrice))
                    {
                        product.Sellprice = decimal.Parse(newSellPrice);
                    }

                    // Update QtyInStock
                    Console.Write("QtyInStock (current: " + product.QtyInStock + "): ");
                    string newQtyInStock = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(newQtyInStock))
                    {
                        product.QtyInStock = int.Parse(newQtyInStock);
                    }

                    Console.WriteLine("Product updated successfully!");
                    return; // Exit the loop after updating
                }
            }

            Console.WriteLine("Product with the specified ID not found.");
        }
    }
}
