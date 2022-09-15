using mis321_pa1_FredP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


driverUtility utils = new driverUtility();
Menu menu = new Menu();

string userInput = menu.GetMenuChoice();
while(userInput != "6"){
    Route(userInput);
    userInput = menu.GetMenuChoice();
}

void Route(string userInput){
    switch(userInput){
        case "1":
        utils.DisplayDrivers();
        break;
        case "2":
        utils.AddDriver();
        break;
        case "3":
        utils.DeleteDriver();
        break;
        case "4":
        utils.EditDriver();
        break;
        case "5":
        utils.MtnByMonth();
        break;
        case "6":
        Exit();
        break;
        default:
        System.Console.WriteLine("Bad Entry");
        break;
    }

    static void Exit()
        {
            Environment.Exit(0); //Closes program
        }
}
