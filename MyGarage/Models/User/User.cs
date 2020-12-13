using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyGarage.Models
{
   [Table("User")]
   public class User
   {
      public int           Id       { get; set; }

      [EmailAddress]
      [MaxLength(128)]
      [MinLength(10)]
      [Required(ErrorMessage = "User Name / Email Address is required")]
      [UIHint("email")]
      public string        Email    { get; set; }

      [MaxLength(128)]
      [Required(ErrorMessage = "Password is required")]
      [UIHint("password")] //   type="password
      public string        Password { get; set; }

      public bool          IsAdmin  { get; set; } = false;

      public List<Vehicle> Vehicles { get; set; }
   }
}