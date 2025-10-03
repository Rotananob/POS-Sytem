using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1.Models
{
    internal class UserMeun
    {
        public void ShowMenu()
        {
            int option;
            do
            {

                Console.WriteLine("---------------------User Menu------------------------");
                Console.WriteLine("1. Add User");
                Console.WriteLine("2. Show User");
                Console.WriteLine("3. Delete User");
                Console.WriteLine("4. Serach User");
                Console.WriteLine("5. Update User");
                Console.WriteLine("6. Back to Main Menu");
                Console.WriteLine("---------------------------------------------------");
                Console.Write("Please choose an option: ");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        User user = new User();
                        user.Add();
                        break;
                    case 2:
                        User user1 = new User();
                        user1.Show();
                        break;
                    case 3:
                        User user2 = new User();
                        user2.Delete();
                        break;
                    case 4:
                        User user3 = new User();
                        user3.Search();
                        break;
                    case 5:
                        User user4 = new User();
                        user4.Update();
                        break;
                }
            } while (option != 6);
        }
    }
}
