using DistrictPredictorML.Model.DataModels;
using Microsoft.ML;

namespace DistrictPredictor
{
    public class DistrictPredictor
    {
        private readonly PredictionEngine<ModelInput, ModelOutput> _predictionEngine;

        public DistrictPredictor()
        {
            MLContext mlContext = new MLContext();
            ITransformer mlModel = mlContext.Model.Load("MLModel.zip", out var modelInputSchema);
            _predictionEngine = mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);
        }

        public ModelOutput PredictDistrict(ModelInput input)
        {
            return _predictionEngine.Predict(input);
        }
    }
}
