using MongoDB.Driver.Core.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virualproject
{
    internal class Beverage : Machine
    {
        private string _names;
        

        public Beverage() { }

        public Beverage(string names): base() 
        {
            _names = names;
          
            
            
        }
        public void Moresweets()
        {
            Console.WriteLine("press the number of beverage");
            string[] sweets = new string[Maxdrinks];
            sweets[0] = "Coca cola" + " " + "D1" + " " + "6₪";
            sweets[1] = "Pepsi" + " " + "D2" + " " + "5₪";
            sweets[2] = "Sprite" + " " + "D3" + " " + "5.5₪";
            sweets[3] = "Fuze tea" + " " + "D4" + " " + "7₪";
            sweets[4] = "Fanta" + " " + "D5" + " " + "5₪";
            sweets[5] = "Water" + " " + "D6" + " " + "10₪";
            foreach (string s in sweets)
            {
                Console.WriteLine(s);
            }
            bool IsValid = false;
            string option = Console.ReadLine();
            while (option != null && !IsValid)
            {
                if (option == "D1")
                {
                    IsValid = true;
                    Console.Clear();
                }
                else if (option == "D2")
                {

                    IsValid = true;
                    Console.Clear();
                }
                else if (option == "D3")
                {

                    IsValid = true;
                    Console.Clear();
                }
                else if (option == "D4")
                {

                    IsValid = true;
                    Console.Clear();
                }
                else if (option == "D5")
                {
                    IsValid = true;
                    Console.Clear();
                }
                else if (option == "D6")
                {
                    IsValid = true;
                    Console.Clear();
                }
                else if (option == "D7")
                {
                    IsValid = true;
                    Console.Clear();
                }
                else if (option == "D8")
                {
                    IsValid = true;
                    Console.Clear();
                }
                else if (option == "D9")
                {
                    IsValid = true;
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Invalid option. Please select again.");
                    option = Console.ReadLine();
                }

            }
        }


       



    }
}
