using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mis321_pa1_FredP
{
    public class Driver
    {
        public Guid id {get; set;}
        public string name {get; set;}
        public DateTime hiredate {get; set;}
        public int rating {get; set;}
        public bool Delete {get; set;}
        public vehicle Car {get; set;}

        public Driver() {
            id = Guid.NewGuid();
            hiredate = DateTime.Now;
            Delete = false;
            Car = new vehicle();

        }

        public override string ToString()
        {
            return ("ID: " + id + name + hiredate + rating + Car.mtnDate);// what does $ do
        }
    }
}