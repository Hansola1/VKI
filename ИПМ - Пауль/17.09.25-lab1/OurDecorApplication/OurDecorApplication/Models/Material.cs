using System.ComponentModel.DataAnnotations;

namespace OurDecorApplication.Models
{
    public class Material
    {
        [Key]
        public string Id { get; set; } 

        public string NameMaterial { get; set; }
        public float? TypeMaterialId { get; set; }
        public string TypeMaterial { get; set; }
        public float? CostMaterialOne { get; set; }
        public float? CountMaterial { get; set; }
        public float? MinCount { get; set; }
        public float? CountInPackage { get; set; }
        public string UnitMeasurement { get; set; }
    }
}