using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            var lot = new CarLot();

            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //using DOT NOTATION
            var firstCar = new Car();
            firstCar.Year = 2007;
            firstCar.Make = "Honda";
            firstCar.Model = "Civic";
            firstCar.EngineNoise = "purr";
            firstCar.HonkNoise = "boop beep";
            firstCar.IsDriveable = true;

            //adding first car to carlot--> instance.field.add method(object)
            lot.listOfCars.Add(firstCar);

            //using OBJECT INITIALIZER SYNTAX
            var secondCar = new Car()
            {
                Year = 2011,
                Make = "Toyota",
                Model = "Tacoma",
                EngineNoise = "vroom",
                HonkNoise = "HONK",
                IsDriveable = false
            };
            //adding second car to carlot list
            lot.listOfCars.Add(secondCar);

            //using CUSTOM CONSTRUCTOR
            Car thirdCar = new Car(2023, "Jeep", "Wrangler", "vroom!!!", "beep", true);

            //adding third car to carlot list
            lot.listOfCars.Add(thirdCar);


            //Call each of the methods for each car

            firstCar.MakeEngineNoise(firstCar.EngineNoise);
            secondCar.MakeEngineNoise(secondCar.EngineNoise);
            thirdCar.MakeEngineNoise(thirdCar.EngineNoise);

            firstCar.MakeHonkNoise(firstCar.HonkNoise);
            secondCar.MakeHonkNoise(secondCar.HonkNoise);
            thirdCar.MakeHonkNoise(thirdCar.HonkNoise);

            //*************BONUS*************//


            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            foreach (var car in lot.listOfCars)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}");
            }
        }
    }
}
