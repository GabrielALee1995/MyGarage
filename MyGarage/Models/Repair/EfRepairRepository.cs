using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace MyGarage.Models
{
   public class EfRepairRepository : IRepairRepository
   {
      //   F i e l d s   &   P r o p e r t i e s
      private AppDbContext _context;

      //   C o n s t r u c t o r s
      public EfRepairRepository(AppDbContext context)
      {
         _context = context;
      }

      //   M e t h o d s

      //   C r e a t e - - - - - - - - - - - - - - - - - - - - - - - - - - -
      public Repair CreateRepair(Repair repair)
      {
         if (repair == null)
         {
            return null;
         }

         _context.Repairs.Add(repair);
         _context.SaveChanges();
         return repair;
      }//End CreateVehicle()

      //   R e a d - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
      public Repair GetRepairById(int repairId)
      {
         return _context.Repairs.Include(r => r.Vehicle)
                                .FirstOrDefault(r => r.Id == repairId);
      }//End GetRepairById()

      public IQueryable<Repair> GetVehicleRepairs(int vehicleId)
      {
         return _context.Repairs.Where(v => v.VehicleId == vehicleId);
      }//End GetVehicleRepairs()

      //   U p d a t e - - - - - - - - - - - - - - - - - - - - - - - - - -
      public Repair UpdateRepair(Repair repair)
      {
         Repair repairToUpdate = _context.Repairs
                                         .SingleOrDefault(r => r.Id == repair.Id);

         if(repairToUpdate != null)
         {
            repairToUpdate.Type = repair.Type;
            repairToUpdate.Date = repair.Date;
            repairToUpdate.Location = repair.Location;
            repairToUpdate.Cost = repair.Cost;
            repairToUpdate.VehicleMileage = repair.VehicleMileage;
            repairToUpdate.WarrantyExpiration = repair.WarrantyExpiration;
            repairToUpdate.Reciept = repair.Reciept;
            repairToUpdate.Photo = repair.Photo;
            _context.SaveChanges();
         }
         return repairToUpdate;
      }//End UpdateRepair()

      //   D e l e t e - - - - - - - - - - - - - - - - - - - - - - - - - -
      public bool DeleteRepair(int repairId)
      {
         Repair repairToDelete = _context.Repairs.Find(repairId);

         if (repairToDelete == null)
         {
            return false;
         }

         _context.Repairs.Remove(repairToDelete);
         _context.SaveChanges();
         return true;
      }//End DeleteRepair()
   }
}
