using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace virualproject
{
    internal class Tea : Beverage
    {
        public int _counter;
        private Tea[] _teas;

        public Tea(int size)
        {
            _teas = new Tea[size];
            for (int i = 0; i < size; i++)
            {
                _teas[i] = new Tea();
                _counter++;
            }
        }

        public Tea() { }

        public override string ToString()
        {
            return $"number of teas:{_counter}";
        }
        public void SelectTea()
        {
            string[] tea = new string[Maxdrinks];
            Console.WriteLine("Select tea.. ");
            tea[0] = "Green tea" + " " + "F1" + " " + "3.5₪";
            tea[1] = "Black tea" + " " + "F2" + " " + "4₪";
            tea[2] = "Yellow tea" + " " + "F3" + " " + "8₪";
            tea[3] = "matcha" + " " + "F4" + " " + "9.5₪";
            for (int i = 0; i < tea.Length; i++)
            {
                Console.WriteLine(tea[i]);
            }
            bool IsValid = false;
            string option = Console.ReadLine();

            while (option != null && !IsValid)
            {
                if (option == "F1")
                {

                    IsValid = true;
                    Console.Clear();
                }
                else if (option == "F2")
                {
                    
                    IsValid = true;
                    Console.Clear();
                }
                else if (option == "F3")
                {
                    
                    IsValid = true;
                    Console.Clear();
                }
                else if( option == "F4")
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
        public bool TeaChecker(Tea[] tea)
        {
            if (_teas.Length >= Maxdrinks)
            {
                throw new arguments(_teas.Length);
            }

            _teas[_counter++] = tea[_counter++];
            return true;
        }

    }
}
