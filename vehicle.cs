using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mis321_pa1_FredP
{
    public class vehicle
    {

        public string model {get; set;}
        public DateTime mtnDate {get; set;}

        public Guid vehicleID {get; set;}

        public vehicle(){
            vehicleID = Guid.NewGuid();
            mtnDate = DateTime.Now;
            model = "Prius";
        }

    }


}