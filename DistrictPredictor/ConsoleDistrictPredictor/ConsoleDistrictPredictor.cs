using System;
using DistrictPredictor;
using DistrictPredictorML.Model.DataModels;

namespace ConsoleDistrictPredictor
{
    public class ConsoleDistrictPredictor
    {
        private readonly DistrictPredictor.DistrictPredictor _districtPredictor;

        public ConsoleDistrictPredictor(DistrictPredictor.DistrictPredictor districtPredictor)
        {
            _districtPredictor = districtPredictor;
        }

        public void PredictDistrict()
        {
            Console.WriteLine("DISTRICT PREDICTOR");

            Console.Write("Latitude: ");
            var latitude = float.Parse(Console.ReadLine());

            Console.Write("Longitude: ");
            var longitude = float.Parse(Console.ReadLine());

            var input = new ModelInput(latitude, longitude);

            // Try model on sample data
            ModelOutput result = _districtPredictor.PredictDistrict(input);

            Console.WriteLine($"District: {result.Prediction}");
            Console.WriteLine($"Predicted value: {result.Prediction} | Predicted scores: [{String.Join(",", result.Score)}]");
        }
    }
}
