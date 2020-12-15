using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MyGarage.Models
{
   public class Fluid
   {
      public int      Id             { get; set; }

      [MinLength(2)]
      [MaxLength(30)]
      [Required(ErrorMessage = "Fluid Type is required")]
      public string   Type           { get; set; }

      [Column(TypeName = "date")]
      [DataType(DataType.Date)]
      [Required(ErrorMessage = "Date of fluid change required")]
      [UIHint("date")]
      public DateTime Date           { get; set; }
      public string   Location       { get; set; }

      [Column(TypeName = "decimal(8,2)")]
      [Range(0.00, 999999.99, ErrorMessage = "Filter Cost Out of Range")]
      [UIHint("number")]
      public float?   FilterCost     { get; set; }
      public string   FilterType     { get; set; }

      [Column(TypeName = "decimal(8,2)")]
      [Range(0.00, 999999.99, ErrorMessage = "Fluid Cost Out of Range")]
      [UIHint("number")]
      public float    FluidCost      { get; set; }
      public string   FluidType      { get; set; }
      public string   StabilizerType { get; set; }
      public bool     Stabilizer     { get; set; }

      [Column(TypeName = "decimal(8,2)")]
      [Range(0.00, 999999.99, ErrorMessage = "Service Cost Out of Range")]
      [UIHint("number")]
      public float?   ServiceCost    { get; set; }

      [Range(0, 1500000, ErrorMessage = "Mileage Out of Range")]
      [UIHint("number")]
      public int      VehicleMileage { get; set; }
      [MaxLength(300)]
      public string Notes { get; set; }
      public string   Receipt        { get; set; }
      public string   Photo          { get; set; }

      [ForeignKey("Vehicle")]
      public int      VehicleId      { get; set; }
      public Vehicle  Vehicle        { get; set; }
   }
}
