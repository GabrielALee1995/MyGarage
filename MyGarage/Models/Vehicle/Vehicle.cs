using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyGarage.Models
{
   [Table("Vehicle")]
   public class Vehicle
   {
      public int    Id           { get; set; }

      [Required(ErrorMessage = "Year is Required")]
      public int    Year         { get; set; }

      [Required(ErrorMessage = "Make is Required")]
      public string Make         { get; set; }

      [Required(ErrorMessage = "Model is Required")]
      public string Model        { get; set; }

      public string NickName     { get; set; }

      [Required(ErrorMessage = "Mileage is Required")]
      public int    Mileage      { get; set; }

      public string LicensePlate { get; set; }

      public string VehicleVIN   { get; set; }

      public string Photo        { get; set; } 

      [ForeignKey("User")]
      public int    UserId       { get; set; }
      public User   User         { get; set; }
   }
}
