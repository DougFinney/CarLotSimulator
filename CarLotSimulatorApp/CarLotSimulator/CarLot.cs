using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class CarLot
    {
        //Field
        //public List<Car> carList = new List<Car>();

        //Property

        public List<Car> CarList { get; set; } = new List<Car>();

        public static int numberofCars; 

        private static void AddCar()
        {
            numberofCars++;
            Console.WriteLine($"# of Cars in Lot: {numberofCars}");
        }
    }
}
