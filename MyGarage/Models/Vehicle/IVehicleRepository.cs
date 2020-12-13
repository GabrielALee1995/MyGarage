using System.Linq;

namespace MyGarage.Models
{
   public interface IVehicleRepository
   {
      //   C r e a t e
      Vehicle CreateVehicle(Vehicle vehicle);

      //   R e a d
      public IQueryable<Vehicle> GetUserVehicles(int userId);
      public IQueryable<Vehicle> GetAllVehicles();
      Vehicle GetVehicleById(int vehicleId);
      IQueryable<Vehicle> GetVehiclesByMakeKeyword(string keyword);

      //   U p d a t e
      public Vehicle UpdateVehicle(Vehicle vehicle);

      //   D e l e t e
      public bool DeleteVehicle(int id);
   }
}
