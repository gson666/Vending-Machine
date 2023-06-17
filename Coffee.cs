using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virualproject
{
    internal class Coffee : Machine
    {
        
        public int _counter;
        private Coffee[]_coffe;
        public Coffee()
        {
           
        }

        public Coffee(int size)
        {
           _coffe= new Coffee[size];
            for (int i = 0; i < size; i++)
            {
                _coffe[i] = new Coffee();
                _counter++;
            }
        }
       
       
        public override string ToString()
        {
            return $"number of coffes:{_counter}";
        }
        public void SelectCoffe()
        {
            Console.WriteLine("Select coffe..");
            string[] coffe = new string[Maxdrinks];
            coffe[0] = "Latte" + " " + "B1" + " " + "4₪";
            coffe[1] = "Capucino" + " " + "B2" + " " + "4₪";
            coffe[2] = "flat white" + " " + "B3" + " " + "4₪";
            coffe[3] = "Americano" + " " + "B4" + " " + "4₪";
            coffe[4] = "Espresso" + " " + "B5" + " " + "4₪";
            coffe[5] = "Irish coffe" + " " + "B6" + " " + "4₪";
            coffe[6] = "Long black" + " " + "B7" + " " + "4₪";
            coffe[7] = "coffea arabica" + " " + "B8" + " " + "4₪";
            coffe[8] = "Doppio" + " " + "B9" + " " + "4₪";
            for (int i = 0; i < coffe.Length; i++)
            {
                Console.WriteLine(coffe[i]);
            }
            bool IsValid = false;
            string option = Console.ReadLine();
            while (option != null && !IsValid)
            {
                if (option == "B1")
                {
                    IsValid = true;
                }
                else if (option == "B2")
                {

                    IsValid = true;
                    Console.Clear();
                }
                else if (option == "B3")
                {
                    
                    IsValid = true;
                    Console.Clear();
                }
                else if (option == "B4")
                {
                   
                    IsValid = true;
                    Console.Clear();
                }
                else if (option == "B5")
                {
                    IsValid = true;
                    Console.Clear();
                }
                else if(option == "B6")
                {
                    IsValid = true;
                    Console.Clear();
                }
                else if(option == "B7")
                {
                    IsValid = true;
                    Console.Clear();
                }
                else if(option == "B8")
                {
                    IsValid = true;
                    Console.Clear();
                }
                else if(option == "B9")
                {
                    IsValid= true;
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
