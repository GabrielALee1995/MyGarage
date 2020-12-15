using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGarage.Models
{
   public interface IUpgradeRepository
   {
      //   C r e a t e
      Upgrade CreateUpgrade(Upgrade upgrade);

      //   R e a d
      public IQueryable<Upgrade> GetVehicleUpgrades(int vehicleId);
      Upgrade GetUpgradeById(int upgradeId);

      //   U p d a t e
      public Upgrade UpdateUpgrade(Upgrade upgrade);

      //   D e l e t e
      public bool DeleteUpgrade(int upgradeId);
   }
}
