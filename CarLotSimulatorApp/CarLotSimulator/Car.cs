using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace CarLotSimulator
{
    public class Car
    {
        //Default Constructor
        public Car()
        {
            CarLot.numberofCars++;
            Console.WriteLine($"# of Cars in Lot: {CarLot.numberofCars}");

        }

        //Custom Constructor
        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;
            CarLot.numberofCars++;
            Console.WriteLine($"# of Cars in Lot: {CarLot.numberofCars}");
        }

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }




        public void MakeEngineNoise(string engineNoise)
        {
            Console.WriteLine($"{engineNoise}");
        }
        public void MakeHonkNoise(string honkNoise)
        {
            Console.WriteLine($"{honkNoise}");
        }


    }

}
