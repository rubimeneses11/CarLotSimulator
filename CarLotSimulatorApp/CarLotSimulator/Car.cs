using System;
namespace CarLotSimulator
{
        //Create a seperate class file called Car
    public class Car
    {
        public Car()
        {
        }

        public Car (int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;
        }

        //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
        //The methods should take one string parameter: the respective noise property
        public void MakeEngineNoise(string EngineNoise)
        {
            Console.WriteLine(EngineNoise);
        }

        public void MakeHonkNoise(string HonkNoise)
        {
            Console.WriteLine(HonkNoise);
        }
    }
}

