using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace virualproject
{
    internal class Choclate : Machine
    {
        public int _counter;
        private Choclate[] _choclates;
        public Choclate() { }
        public Choclate(int size)
        {
            _choclates = new Choclate[size];
            for (int i = 0; i < size; i++)
            {
                _choclates[i] = new Choclate();
                _counter++;
            }
        }
        public void Selectchoclate()
        {
            string[] choco = new string[Maxdrinks];
            Console.WriteLine("Select Choclate..");
            choco[0] = "Sokolit " + " " + "A1" + " " + "4₪";
            choco[1] = "Dark choclate" + " " + "A2" + " " + "4₪";
            choco[2] = "Vegan choclate milk" + " " + "4₪";
            for (int i = 0; i < choco.Length; i++)
            {
                Console.WriteLine(choco[i]);
            }

            bool IsValid = false;
            string option = Console.ReadLine();

            while (option != null && !IsValid)
            {
                if (option == "A1")
                {
                    
                    IsValid = true;
                    Console.Clear();
                }
                else if (option == "A2")
                {
                    Console.WriteLine("3.5NIS");
                    IsValid = true;
                    Console.Clear();
                }
                else if (option == "A3")
                {
                    Console.WriteLine("3.5NIS");
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
        public bool Chocolate(Choclate[] choclate)
        {
            if (_choclates.Length >= Maxdrinks)
            {
                throw new arguments(_choclates.Length);
            }

            _choclates[_counter++] = choclate[_counter++];
            return true;
        }
        public override string ToString()
        {
            return $"number of choclates:{_counter}";
        }
    }
}
