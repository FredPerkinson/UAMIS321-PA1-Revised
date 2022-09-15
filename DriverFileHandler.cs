using Newtonsoft.Json;

namespace mis321_pa1_FredP
{
    public class DriverFileHandler
    {
        public List<Driver> drivers;

        public DriverFileHandler(){
            GetAllDrivers();
        }

        private void GetAllDrivers(){
            try{
                string json = File.ReadAllText("drivers.txt");
                drivers = JsonConvert.DeserializeObject<List<Driver>>(json);
            }
            catch(FileNotFoundException e)
            {
                System.Console.WriteLine($"The File could not be found {0}", e);
            }
        }

        public void SaveAllDrivers(){
            File.WriteAllText("drivers.txt", JsonConvert.SerializeObject(drivers));
        }
    }
}