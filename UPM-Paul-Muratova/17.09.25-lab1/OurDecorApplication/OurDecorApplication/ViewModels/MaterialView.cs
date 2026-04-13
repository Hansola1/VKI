using System.ComponentModel.DataAnnotations;

namespace OurDecorApplication.ViewModels
{
    public class MaterialView
    {
        public string NameMaterial { get; set; }
        public double? TypeMaterialId { get; set; }
        public string TypeMaterial { get; set; }
        public double? CostMaterialOne { get; set; }
        public double? CountMaterial { get; set; }
        public double? MinCount { get; set; }
        public double? CountInPackage { get; set; }
        public string UnitMeasurement { get; set; }
    }
}
