using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mis321_pa1_FredP
{
    public class driverUtility
    {
        public List<Driver> drivers = new List<Driver>();

        private DriverFileHandler fileHandler = new DriverFileHandler();

        public driverUtility(){
            drivers = fileHandler.drivers;
            SortDrivers();
        }

        public void AddDriver(){
            Driver newDriver = new Driver();
            System.Console.WriteLine("What is the Driver's name?");
            newDriver.name = Console.ReadLine();
            System.Console.WriteLine("What is the Driver's rating from 1 to 5?");
            newDriver.rating = int.Parse(Console.ReadLine());
            drivers.Add(newDriver);
            SortDrivers();
            SaveDrivers();
        }

        public void DisplayDrivers(){
            foreach(Driver driver in drivers){
                if(!driver.Delete){
                System.Console.WriteLine(driver.ToString());
                }
            }
            SaveDrivers();
        }

        public void EditDriver(){
            DisplayDrivers();
            System.Console.WriteLine("Enter the Driver's Guid you would like to edit");
            Guid userInput = Guid.Parse(Console.ReadLine());
            Driver editDriver = FindDriver(userInput);
            if(editDriver == null){
                System.Console.WriteLine("Driver not found");
            }
            else{
                System.Console.WriteLine("What should Driver rating be?");
                editDriver.rating = int.Parse(Console.ReadLine());
            }
            SaveDrivers();
        }

        public void DeleteDriver(){
            DisplayDrivers();
            System.Console.WriteLine("Enter the Driver's Guid you would like to remove.");
            Guid userInput = Guid.Parse(Console.ReadLine());
            Driver deleteDriver = FindDriver(userInput);
            if(deleteDriver == null){
                System.Console.WriteLine("Driver not found.");
            }
            else{
                deleteDriver.Delete = true; 
            }
             SaveDrivers();
        }

        private Driver FindDriver(Guid searchVal){
            Driver returnVal = drivers.Find(x => x.id == searchVal);
            return returnVal;
        }

        private void SaveDrivers(){
            fileHandler.drivers = drivers;
            fileHandler.SaveAllDrivers();
        }

        private void SortDrivers(){
            drivers.Sort((x,y) => x.hiredate.CompareTo(y.hiredate));
        }

        public void MtnByMonth() {
            drivers.Sort((x,y) => x.Car.mtnDate.CompareTo(y.Car.mtnDate));
            int count = 1;
            int currMonth = drivers[0].Car.mtnDate.Month;
            int currYear = drivers[0].Car.mtnDate.Year;
            System.Console.WriteLine(drivers[0].Car.mtnDate);
            for(int i = 1; i < drivers.Count; i++) {
                if(drivers[i].Car.mtnDate.Month == currMonth && drivers[i].Car.mtnDate.Year == currYear) {
                    count++;
                    System.Console.WriteLine(drivers[i].Car.mtnDate);
                }
                else{
                    ProcessBreak(ref count, ref currMonth, ref currYear, i);
                }
            }
            ProcessBreak(ref count, ref currMonth, ref currYear, 0);
        }

        public void ProcessBreak(ref int count, ref int currMonth, ref int currYear, int i) {
            System.Console.WriteLine($"There are {count} maintenance dates in {currMonth} in {currYear}.");
            currMonth = drivers[i].Car.mtnDate.Month;
            currYear = drivers[i].Car.mtnDate.Year;
            count = 1;
            if(i != 0) {
                System.Console.WriteLine(drivers[i].Car.mtnDate);
            }
        }
    }
}