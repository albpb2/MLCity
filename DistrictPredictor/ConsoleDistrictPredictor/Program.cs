using System;

namespace DistrictPredictor
{
    public class Program
    {
        static void Main(string[] args)
        {
            var districtPredictor = new DistrictPredictor();
            var consoleDistrictPredictor = new ConsoleDistrictPredictor.ConsoleDistrictPredictor(districtPredictor);

            ConsoleKeyInfo userInput = new ConsoleKeyInfo();

            while (userInput.Key != ConsoleKey.E)
            {
                consoleDistrictPredictor.PredictDistrict();

                Console.WriteLine("Press e to exit, any other key to make another prediction");
                userInput = Console.ReadKey();
            }

        }
    }
}
