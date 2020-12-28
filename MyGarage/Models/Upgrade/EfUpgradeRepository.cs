using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGarage.Models
{
   public class EfUpgradeRepository : IUpgradeRepository
   {
      //   F i e l d s   &   P r o p e r t i e s
      private AppDbContext _context;

      //   C o n s t r u c t o r s
      public EfUpgradeRepository(AppDbContext context)
      {
         _context = context;
      }

      //   M e t h o d s

      //   C r e a t e - - - - - - - - - - - - - - - - - - - - - - - - - - -
      public Upgrade CreateUpgrade(Upgrade upgrade)
      {
         if (upgrade == null)
         {
            return null;
         }

         _context.Upgrades.Add(upgrade);
         _context.SaveChanges();
         return upgrade;
      }//End CreateUpgrade()

      //   R e a d - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
      public Upgrade GetUpgradeById(int upgradeId)
      {
         return _context.Upgrades.Include(u => u.Vehicle)
                                 .FirstOrDefault(u => u.Id == upgradeId);
      }//End GetUpgradeById()

      public IQueryable<Upgrade> GetVehicleUpgrades(int vehicleId)
      {
         return _context.Upgrades.Where(v => v.VehicleId == vehicleId);
      }//End GetVehicleUpgrades()

      //   U p d a t e - - - - - - - - - - - - - - - - - - - - - - - - - -
      public Upgrade UpdateUpgrade(Upgrade upgrade)
      {
         Upgrade upgradeToUpdate = _context.Upgrades
                                           .SingleOrDefault(u => u.Id == upgrade.Id);

         if(upgrade != null)
         {
            upgradeToUpdate.Type = upgrade.Type;
            upgradeToUpdate.Date = upgrade.Date;
            upgradeToUpdate.Location = upgrade.Location;
            upgradeToUpdate.PartsCost = upgrade.PartsCost;
            upgradeToUpdate.LaborCost = upgradeToUpdate.LaborCost;
            upgradeToUpdate.VehicleMileage = upgrade.VehicleMileage;
            upgradeToUpdate.WarrantyExpiration = upgrade.WarrantyExpiration;
            //upgradeToUpdate.Notes = upgrade.Notes;
            upgradeToUpdate.Receipt = upgrade.Receipt;
            upgradeToUpdate.Photo = upgrade.Photo;
            _context.SaveChanges();
         }
         return upgradeToUpdate;
      }//End UpdateUpgrade()

      //   D e l e t e - - - - - - - - - - - - - - - - - - - - - - - - - -
      public bool DeleteUpgrade(int upgradeId)
      {
         Upgrade upgradeToDelete = _context.Upgrades.Find(upgradeId);

         if(upgradeToDelete == null)
         {
            return false;
         }

         _context.Upgrades.Remove(upgradeToDelete);
         _context.SaveChanges();
         return true;
      }//End DeleteUpgrade()
   }
}
