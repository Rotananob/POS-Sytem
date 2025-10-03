using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test1.Models;

namespace finalProject.Models
{
    internal class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public void LogIn()
        {
            Console.WriteLine("-------System LogIn------------");
            Console.Write("UesrName :");
            this.UserName = Console.ReadLine();
            Console.Write("Password :");
            this.Password = Console.ReadLine();
            if (this.UserName.Equals("Rotana") && this.Password.Equals("1280"))
            {
                MainMenu mainMenu = new MainMenu();
                mainMenu.Menu();

            }
            else
            {
                Console.WriteLine("\t");
                Console.WriteLine("=========================");
                Console.WriteLine("Username or Pw is Invalid");
                Console.WriteLine("=========================");
            }
        }
    }
}
