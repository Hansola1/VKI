using System.ComponentModel.DataAnnotations;

namespace OurDecorApplication.Models
{
    public class Material
    {
        [Key]
        public string Id { get; set; }
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