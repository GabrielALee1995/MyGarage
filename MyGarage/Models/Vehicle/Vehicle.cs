using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyGarage.Models
{
   [Table("Vehicle")]
   public class Vehicle
   {
      public int           Id             { get; set; }

      [Range(1760, 2030, ErrorMessage = "Year out of range")]
      [Required(ErrorMessage = "Year is Required")]
      [UIHint("number")]
      public int           Year           { get; set; }

      [Required(ErrorMessage = "Make is Required")]
      public string        Make           { get; set; }

      [Required(ErrorMessage = "Model is Required")]
      public string        Model          { get; set; }

      [MaxLength(20)]
      [Required(ErrorMessage = "Nickname is required")]
      public string        NickName       { get; set; }

      [Range(0, 1500000, ErrorMessage = "Mileage Out of Range")]
      [Required(ErrorMessage = "Mileage is Required")]
      [UIHint("number")]
      public int           Mileage        { get; set; }

      [Column(TypeName = "decimal(8,2)")]
      [Range(0.00, 999999.99, ErrorMessage = "Purchase price Out of Range")]
      [UIHint("number")]
      public float?        PurchasePrice  { get; set; }

      [MinLength(0)]
      public string        LicensePlate   { get; set; }

      public string        VehicleVIN     { get; set; }

      public string        Photo          { get; set; } 

      public List<Repair>  Repairs        { get; set; }
      public List<Upgrade> Upgrades       { get; set; }

      [ForeignKey("User")]
      public int           UserId         { get; set; }
      public User          User           { get; set; }
   }
}