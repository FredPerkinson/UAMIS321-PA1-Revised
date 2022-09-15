using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mis321_pa1_FredP
{
    public class Menu
    {
        public void DisplayMainMenu(){
            Console.ReadKey();
            Console.Clear();
            System.Console.WriteLine("Press one of the below numbers to navigate the program:");
            System.Console.WriteLine("1.Display Drivers");
            System.Console.WriteLine("2.Add Driver");
            System.Console.WriteLine("3.Delete Driver");
            System.Console.WriteLine("4.Change Driver Rating");
            System.Console.WriteLine("5.View Maintanence Data");
            System.Console.WriteLine("6.Exit Program");
        }

        public string GetMenuChoice(){
            DisplayMainMenu();
            System.Console.WriteLine("Enter Menu Choice");
            return Console.ReadLine();
        }
    }
}