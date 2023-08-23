using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Speed_Racing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
                
            List<Car> cars = new List<Car>();

            Car currCar = new Car();
                
            for (int i = 0; i < n; i++)
            {
                string [] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                currCar.Model = input[0];
                currCar.FuelAmount = double.Parse(input[1]);
                currCar.ConsumPerKilo = double.Parse(input[2]);
                cars.Add(currCar);
                currCar = new Car();
            }

            

            string[] drives = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            cars.Equals(drives[1]);

            while (drives[0] != "End")
            {
                string carModel = drives[1];
                double kms = double.Parse(drives[2]);
                

                Car myCar = cars.Where(c=>c.Model==carModel)
                    .ToList()
                    .First();
                    
               
                myCar.Calculate(carModel,kms);

               



                drives = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray(); ;
            }

            foreach (var item in cars)
            {
                if (item.Distance>0)
                {
                    Console.WriteLine($"{item.Model} {item.FuelAmount:f2} {item.Distance}");
                }
            }

            
        }
    }
}
