using System.Linq;

namespace MyGarage.Models
{
   public interface IRepairRepository
   {
      //   C r e a t e
      Repair CreateRepair(Repair repair);

      //   R e a d
      public IQueryable<Repair> GetVehicleRepairs(int vehicleId);
      Repair GetRepairById(int repairId);

      //   U p d a t e
      public Repair UpdateRepair(Repair repair);

      //   D e l e t e
      public bool DeleteRepair(int repairId);
   }
}