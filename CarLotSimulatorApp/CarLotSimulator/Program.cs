using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)

        {
            var parkingLot = new CarLot();
            {

                //TODO

                //Create a seperate class file called Car = DONE
                //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable = DONE
                //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
                //The methods should take one string parameter: the respective noise property


                //Now that the Car class is created we can instanciate 3 new cars
                //Set the properties for each of the cars
                //Call each of the methods for each car

                var corvette = new Car();
                //Dot Notation
                corvette.Year = 2020;
                corvette.Make = "Chevy";
                corvette.Model = "Corvette";
                corvette.EngineNoise = "Vroomvroom!";
                corvette.HonkNoise = "Honk!";
                corvette.IsDriveable = true;

                parkingLot.CarList.Add(corvette);

                //Object Initializer Syntax
                var ford = new Car()
                {
                    Year = 2020,
                    Make = "Ford",
                    Model = "Mustang",
                    EngineNoise = "Zoomzoom!",
                    HonkNoise = "Beep!",
                    IsDriveable = true
                };

                parkingLot.CarList.Add(ford);

                //Custom Constructor
                var dodge = new Car(2020, "Dodge", "Charger", "Clunkclunk!!", "Toot!", false);

                parkingLot.CarList.Add(dodge);

                //*************BONUS*************//

                // Set the properties utilizing the 3 different ways we learned about, one way for each car

                //*************BONUS X 2*************//

                //Create a CarLot class
                //It should have at least one property: a List of cars
                //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
                //At the end iterate through the list printing each of car's Year, Make, and Model to the console

                foreach (var car in parkingLot.CarList)
                {
                    Console.WriteLine($"Year: {car.Year}");
                    Console.WriteLine($"Make: {car.Make}");
                    Console.WriteLine($"Model: {car.Model}");
                    car.MakeEngineNoise(car.EngineNoise);
                    car.MakeHonkNoise(car.HonkNoise);
                }


            }
        }
    }
}
