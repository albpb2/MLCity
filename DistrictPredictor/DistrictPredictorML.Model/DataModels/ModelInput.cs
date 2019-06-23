//*****************************************************************************************
//*                                                                                       *
//* This is an auto-generated file by Microsoft ML.NET CLI (Command-Line Interface) tool. *
//*                                                                                       *
//*****************************************************************************************

using Microsoft.ML.Data;

namespace DistrictPredictorML.Model.DataModels
{
    public class ModelInput
    {
        [ColumnName("LATITUD"), LoadColumn(0)]
        public float LATITUD { get; set; }


        [ColumnName("LONGITUD"), LoadColumn(1)]
        public float LONGITUD { get; set; }


        [ColumnName("DISTRITO"), LoadColumn(2)]
        public string DISTRITO { get; set; }


    }
}
