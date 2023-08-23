using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._Raw_Data
{
    public class Car
    {
        public Car(string model, int speed, int power,
            int weight, string type,
            double tire1Pressure, int tire1Age,
            double tire2Pressure, int tire2Age,
            double tire3Pressure, int tire3Age,
            double tire4Pressure, int tire4Age)
        {
            Model = model;
            Engine = new Engine(speed,power);
            Cargo = new Cargo (weight,type);
            Tire = new Tires[4];
            Tire[0] = new Tires(tire1Pressure, tire1Age);
        }

        public string Model { get; set; }

        public Engine Engine { get; set; }
 
        public Cargo Cargo { get; set; }
        
        public Tires [] Tire { get; set; }
    }
}
