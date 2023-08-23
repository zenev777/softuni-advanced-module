using System;
using System.Collections.Generic;
using System.Text;

namespace _06._Speed_Racing
{
    public class Car
    {
        private string model;
        private double fuelamount;
        private double consumperkilo;
        private double distance;

        public Car()
        {
            model = " ";
            fuelamount = 0;
            consumperkilo = 0;
            distance = 0;
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public double FuelAmount
        {
            get { return fuelamount; }
            set { fuelamount = value; }
        }

        public double ConsumPerKilo
        {
            get { return consumperkilo; }
            set { consumperkilo = value; }
        }

        public double Distance
        {
            get { return distance; }
            set { distance = value; }
        }

        public void Calculate(string carModel, double kms)
        {
            double neededLitres = kms * this.ConsumPerKilo;

            if (this.FuelAmount >= neededLitres)
            {
                this.FuelAmount -= neededLitres;
                this.Distance += kms;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }

    

    }
}
