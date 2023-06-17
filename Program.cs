using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using virualproject;
using System.Threading;
using System.Reflection.PortableExecutable;


public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        // Create a CultureInfo object for Hebrew (Israel) culture
        CultureInfo hebrewCulture = new CultureInfo("he-IL");

        // Set the thread's culture to Hebrew (Israel)
        Thread.CurrentThread.CurrentCulture = hebrewCulture;
        Thread.CurrentThread.CurrentUICulture = hebrewCulture;
        //create vendingmachine obj
        Machine machine = new Machine();
        //running the program
        machine.RunProgram();


    }
}

