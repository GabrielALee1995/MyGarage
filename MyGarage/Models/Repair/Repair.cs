using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyGarage.Models
{
   public class Repair
   {
      public int       Id                 { get; set; }

      [MaxLength(30)]
      [MinLength(2)]
      [Required(ErrorMessage = "Repair Type is required")]
      public string    Type               { get; set; }

      [Column(TypeName = "date")]
      [DataType(DataType.Date)]
      [Required(ErrorMessage ="Repair Date is required")]
      [UIHint("date")]
      public DateTime  Date               { get; set; }
      public string    Location           { get; set; }

      [Column(TypeName ="decimal(8,2)")]
      [Range(0.00, 999999.99, ErrorMessage ="Repair Cost Out of Range")]
      [UIHint("number")]
      public float?     Cost               { get; set; }

      [Range(0, 1500000, ErrorMessage ="Mileage Out of Range")]
      [UIHint("number")]
      public int       VehicleMileage     { get; set; }

      [Column(TypeName ="date")]
      [DataType(DataType.Date)]
      [UIHint("date")]
      public DateTime? WarrantyExpiration { get; set; }

      [MaxLength(300)]
      //public string Notes { get; set; }
      public string    Receipt            { get; set; }
      public string    Photo              { get; set; }

      [ForeignKey("Vehicle")]
      public int       VehicleId          { get; set; }
      public Vehicle   Vehicle            { get; set; }
   }
}
