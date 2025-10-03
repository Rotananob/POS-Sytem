using finalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.LogIn();
            Console.ReadKey();
        }
    }
}
