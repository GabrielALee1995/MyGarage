using Microsoft.AspNetCore.Mvc;
using MyGarage.Models;
using System;
using System.Linq;

namespace MyGarage.Controllers
{
   public class UpgradeController : Controller
   {
      //   F i e l d s   &   P r o p e r t i e s
      private IUpgradeRepository _repository;
      private IVehicleRepository _vehicleRepository;

      //   C o n s t r u c t o r s
      public UpgradeController(IUpgradeRepository repository, IVehicleRepository vehicleRepository)
      {
         _repository = repository;
         _vehicleRepository = vehicleRepository;
      }

      //   M e t h o d s

      //   C r e a t e

      //   R e a d
      public IActionResult ListUpgrades(int vehicleId)
      {
         IQueryable<Upgrade> vehicleUpgrades = _repository.GetVehicleUpgrades(vehicleId);

         float total = 0;

         foreach (Upgrade u in vehicleUpgrades)
         {
            total += u.Cost.Value;
         }

         ViewBag.TotalUpgradeCost = total.ToString("C");

         Vehicle vehicle = _vehicleRepository.GetVehicleById(vehicleId);
         ViewBag.VehicleNickName = vehicle.NickName;
         ViewBag.VehicleId = vehicle.Id;

         return View(vehicleUpgrades);
      }//End ListUpgrades()

      //   U p d a t e

      //   D e l e t e
   }
}
