using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace virualproject
{
    public class Admin : Machine
    {
        private string _username;
        private readonly int _Id;
        private static int _lastId;
        private string _password;



        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public Admin() { }
        static Admin()
        {
            _lastId = 1;
        }

        public Admin(string username)
        {
            _username = username;

            _Id = Admin.getNewID();

        }

        public void Access()
        {
            string password = "Admin10";
            string pattern = Regex.Escape(password);
            Regex regex = new Regex(pattern);
            bool IsValid = false;

            Console.WriteLine("Enter password");
            string access = Console.ReadLine();

            while (!IsValid)
            {
                if (regex.IsMatch(access))
                {
                    IsValid = true;
                    Console.Clear();
                    Console.WriteLine($"Welcome admin, {_username}");
                    continue;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Access denied due to wrong password!");
                    Console.WriteLine("Please try again");
                    IsValid = false;
                }
                access = Console.ReadLine();
            }
        }

        public override string ToString()
        {
            return $"Welcome {_username}, ID: {_Id}";
        }
        private static int getNewID()
        {
            return _lastId++;
        }
        internal void GetAdminNumbers()
        {
            Console.WriteLine("Admins in system:" + _lastId);
        }
        public void Adminoption(Machine machine)
        {
            Console.WriteLine("To get the current number of beverages press 1");
            Console.WriteLine("To add beverages press 2");
            Console.WriteLine("To remove beverages press 3");
            int option = Convert.ToInt32(Console.ReadLine());

            if (option == 1)
            {
                int currentCount = machine.GetCurrentBeverageCount();
                Console.WriteLine($"Current beverage count: {currentCount}");
            }

            else if (option == 2)
            {
                Console.WriteLine("Permission from program needed!");
            }
            else if (option == 3)
            {
                Console.WriteLine("Permission from program needed!");
            }
        }






        
    }
}
