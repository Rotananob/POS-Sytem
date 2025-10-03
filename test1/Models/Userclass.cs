using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1.Models
{
    internal class User
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public DateTime Dob { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }

        public static List<User> userList = new List<User>();

        public void Add()
        {
            Console.WriteLine("--------------------User Information--------------------");
            int n;
            Console.Write("Input n: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                User user = new User();
                Console.Write("Enter User ID: ");
                user.Id = int.Parse(Console.ReadLine());
                Console.Write("Enter First Name: ");
                user.FirstName = Console.ReadLine();
                Console.Write("Enter Last Name: ");
                user.LastName = Console.ReadLine();
                Console.Write("Enter Username: ");
                user.Username = Console.ReadLine();
                Console.Write("Enter Password: ");
                user.Password = Console.ReadLine();
                Console.Write("Enter Gender: ");
                user.Gender = Console.ReadLine();
               /* Console.Write("Enter Date of Birth (yyyy-mm-dd): ");
                user.Dob = DateTime.Parse(Console.ReadLine());*/
                Console.Write("Enter Address: ");
                user.Address = Console.ReadLine();
                Console.Write("Enter Telephone: ");
                user.Tel = Console.ReadLine();
                userList.Add(user);
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine();
            }
        }
        public void Show()
        {
            string columnHeader, datarecord;
            Console.WriteLine("------------------------------------------User Information-----------------------------------------------------------");

            columnHeader = string.Format("{0,-10}{1,-25}{2,-15}{3,-15}{4,-10}{5,-20}{6,-10}{7,-15}",
                "ID", "FullName", "Username", "Password", "Gender", "DOB", "Address", "Tel");

            Console.WriteLine(columnHeader);
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");

            foreach (User user in userList)
            {
                string fullName = user.FirstName + " " + user.LastName;
                datarecord = string.Format("{0,-10}{1,-25}{2,-15}{3,-15}{4,-10}{5,-20}{6,-10}{7,-15}",
                    user.Id, fullName, user.Username, user.Password, user.Gender, user.Dob.ToString("yyyy-MM-dd"), user.Address, user.Tel);

                Console.WriteLine(datarecord);
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
            }
        }

        public void Delete()
        {
            Console.Write("Remone By Id= ");
            this.Id = int.Parse(Console.ReadLine());
            foreach (User user in userList)
            {
                if (user.Id == this.Id)
                {
                    userList.Remove(user);
                    Console.Write("User have been Remove");
                    break;
                }
            }
        }
        public void Search()
        {
            List<User> users = new List<User>();
            Console.WriteLine("Search By Id= ");
            this.Id = int.Parse(Console.ReadLine());
            foreach (User user in users)
            {
                if (user.Id == this.Id)
                {
                    users.Add(user);
                }
            }
            string columnHeader, datarecord;
            Console.WriteLine("--------------------User Information---------------------");
            columnHeader = string.Format("{0,-10}{1,-15}{2,-15}{3,-15}{4,-15}{5,-15}{6,-15}{7,-15}{8,-15}"
                , "ID", "FullName", "Gender", "DOB", "Address", "Tel");
            Console.WriteLine(columnHeader);
            Console.WriteLine("---------------------------------------------------------");
            foreach (User user in users)
            {
                datarecord = string.Format("{0,-10}{1,-15}{2,-15}{3,-15}{4,-15}{5-,15}{6,-15}{7,-15}",
                    user.Id, user.FirstName + user.LastName, user.Username, user.Password, user.Gender, user.Dob, user.Address, user.Tel);
                Console.WriteLine(datarecord);
                Console.WriteLine("--------------------------------------------------------------------------------------------");
            }
        }
        public void Update()
        {
            Console.WriteLine("-----------Update User Information---------");
            Console.Write("Search By Id: ");
            int searchId = int.Parse(Console.ReadLine());

            foreach (User user in userList)
            {
                if (user.Id == searchId)
                {
                    Console.WriteLine("User found. Leave fields blank to keep the current value.");
                    Console.Write("First Name (current: " + user.FirstName + "): ");
                    string newFirstName = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(newFirstName))
                    {
                        user.FirstName = newFirstName;
                    }
                    Console.Write("Last Name (current: " + user.LastName + "): ");
                    string newLastName = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(newLastName))
                    {
                        user.LastName = newLastName;
                    }
                    Console.Write("Username (current: " + user.Username + "): ");
                    string newUsername = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(newUsername))
                    {
                        user.Username = newUsername;
                    }
                    Console.Write("Password (current: " + user.Password + "): ");
                    string newPassword = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(newPassword))
                    {
                        user.Password = newPassword;
                    }
                    Console.Write("Gender (current: " + user.Gender + "): ");
                    string newGender = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(newGender))
                    {
                        user.Gender = newGender;
                    }
                    Console.Write("Date of Birth (current: " + user.Dob.ToString("yyyy-MM-dd") + "): ");
                    string newDob = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(newDob))
                    {
                        user.Dob = DateTime.Parse(newDob);
                    }
                    Console.Write("Address (current: " + user.Address + "): ");
                    string newAddress = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(newAddress))
                    {
                        user.Address = newAddress;
                    }
                    Console.Write("Telephone (current: " + user.Tel + "): ");
                    string newTel = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(newTel))
                    {
                        user.Tel = newTel;
                    }

                    Console.WriteLine("User information has been updated successfully!");
                    return;
                }
            }

            Console.WriteLine("User with the specified Id not found.");
        }

    }
}
