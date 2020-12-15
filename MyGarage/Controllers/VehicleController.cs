using Microsoft.AspNetCore.Mvc;
using MyGarage.Models;
using System;
using System.Linq;

namespace MyGarage.Controllers
{
   public class VehicleController : Controller
   {
      //   F i e l d s   &   P r o p e r t i e s
      private IVehicleRepository _repository;
      private IUserRepository _userRepository;
      private IRepairRepository _repairRepository;
      private IUpgradeRepository _upgradeRepository;

      //   C o n s t r u c t o r s
      public VehicleController(IVehicleRepository repository, IUserRepository userRepository, IRepairRepository repairRepository, IUpgradeRepository upgradeRepository)
      {
         _repository = repository;
         _userRepository = userRepository;
         _repairRepository = repairRepository;
         _upgradeRepository = upgradeRepository;
      }

      //   M e t h o d s

      //   C r e a t e
      [HttpGet]
      public IActionResult Add(int userId)
      {
         User u = _userRepository.GetUserById(userId);
         Vehicle v = new Vehicle();
         v.User = u;
         v.UserId = userId;
         return View(v);
      } //End Add( ) [Get]

      [HttpPost]
      public IActionResult Add(Vehicle v)
      {
         DateTime nextYear = DateTime.Now;
         int yearMax = nextYear.Year + 1;
         ViewBag.NextYear = yearMax;

         if (ModelState.IsValid)
         {
            _repository.CreateVehicle(v);
            return RedirectToAction("Details", new { vehicleId = v.Id });
         }

         return View(v);

      } //End Add( ) [Post]

      //   R e a d
      public IActionResult ListVehicles(int userId)
      {
         IQueryable<Vehicle> userVehicles = _repository.GetUserVehicles(userId);
         return View(userVehicles);
      }//End UserVehicles()

      public IActionResult Details(int vehicleId)
      {
         float repairsCost = 0;
         float upgradeCost = 0;
         float vehicleCost = 0;
         float totalCost = 0;

         IQueryable<Repair> repairs = _repairRepository.GetVehicleRepairs(vehicleId);
         foreach(Repair r in repairs)
         {
            repairsCost += r.Cost.Value;
         }
         ViewBag.RepairsCost = repairsCost.ToString("C");

         IQueryable<Upgrade> upgrades = _upgradeRepository.GetVehicleUpgrades(vehicleId);
         foreach(Upgrade u in upgrades)
         {
            upgradeCost += u.Cost.Value;
         }
         ViewBag.UpgradesCost = upgradeCost.ToString("C");

         Vehicle v = _repository.GetVehicleById(vehicleId);

         if (v.PurchasePrice != null)
         {
            vehicleCost = v.PurchasePrice.Value;
         }
         totalCost = vehicleCost + repairsCost + upgradeCost;
         ViewBag.TotalCost = totalCost.ToString("C");

         return View(v);
      }//End VehicleDetails

      //   U p d a t e
      [HttpGet]
      public IActionResult Edit(int vehicleId)
      {
         DateTime nextYear = DateTime.Now;
         int yearMax = nextYear.Year + 1;
         ViewBag.NextYear = yearMax;

         Vehicle v = _repository.GetVehicleById(vehicleId);
         return View(v);
      }//End Edit() [Get]

      [HttpPost]
      public IActionResult Edit(Vehicle updatedVehicle)
      {
         if (ModelState.IsValid)
         {
            _repository.UpdateVehicle(updatedVehicle);
            return RedirectToAction("Details", new { vehicleId = updatedVehicle.Id });
         }
         return View(updatedVehicle);
      }//End Edit() [Post]

      //   D e l e t e
      [HttpGet]
      public IActionResult Delete(int vehicleId)
      {
         Vehicle v = _repository.GetVehicleById(vehicleId);
         if (v == null)
         {
            return RedirectToAction("ListVehicles", "Vehicle", new { userId = v.UserId});
         }
         return View(v);
      }//End Delete() [Get]

      [HttpPost]
      public IActionResult Delete(Vehicle v)
      {
         _repository.DeleteVehicle(v.Id);
         return RedirectToAction("ListVehicles", "Vehicle", new { userId = v.UserId });
      }//End Delete() [Post]
   }
}
