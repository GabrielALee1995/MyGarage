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
      [HttpGet]
      public IActionResult Add(int vehicleId)
      {
         Vehicle v = _vehicleRepository.GetVehicleById(vehicleId);
         ViewBag.VehicleNickName = v.NickName;
         ViewBag.VehicleId = v.Id;

         DateTime date = DateTime.Today;
         ViewBag.TodaysDate = date;

         Upgrade u = new Upgrade();
         u.Vehicle = v;
         u.VehicleId = v.Id;
         u.VehicleMileage = v.Mileage;
         return View(u);
      }//End Add() [Get]

      [HttpPost]
      public IActionResult Add(Upgrade u)
      {
         if (ModelState.IsValid)
         {
            Vehicle v = _vehicleRepository.GetVehicleById(u.VehicleId);

            if (u.VehicleMileage > v.Mileage)
            {
               v.Mileage = u.VehicleMileage;
            }

            _repository.CreateUpgrade(u);
            return RedirectToAction("ListUpgrades", new { vehicleId = u.VehicleId });
         }
         return View(u);
      }//End Add() [Post]

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

      public IActionResult Details(int upgradeId)
      {
         Upgrade u = _repository.GetUpgradeById(upgradeId);

         Vehicle v = _vehicleRepository.GetVehicleById(u.VehicleId);
         ViewBag.VehicleNickName = v.NickName;

         return View(u);
      }//End Details()

      //   U p d a t e
      [HttpGet]
      public IActionResult Edit(int upgradeId)
      {
         Upgrade u = _repository.GetUpgradeById(upgradeId);
         Vehicle v = _vehicleRepository.GetVehicleById(u.VehicleId);
         ViewBag.VehicleNickName = v.NickName;
         ViewBag.VehicleId = v.Id;

         return View(u);
      }//End Edit() [Get]

      [HttpPost]
      public IActionResult Edit(Upgrade updatedUpgrade)
      {
         if (ModelState.IsValid)
         {
            _repository.UpdateUpgrade(updatedUpgrade);
            return RedirectToAction("Details", "Upgrade", new { upgradeId = updatedUpgrade.Id });
         }
         return View(updatedUpgrade);
      }//End Edit() [Post]

      //   D e l e t e
      [HttpGet]
      public IActionResult Delete(int upgradeId)
      {
         Upgrade u = _repository.GetUpgradeById(upgradeId);

         Vehicle v = _vehicleRepository.GetVehicleById(u.VehicleId);
         ViewBag.VehicleNickName = v.NickName;
         ViewBag.VehicleId = v.Id;

         if (u == null)
         {
            return RedirectToAction("ListUpgrades", "Upgrade", new { vehicleId = u.VehicleId });
         }
         return View(u);
      }//End Delete() [Get]

      [HttpPost]
      public IActionResult Delete(Upgrade u)
      {
         _repository.DeleteUpgrade(u.Id);
         return RedirectToAction("ListUpgrades", "Upgrade", new { vehicleId = u.VehicleId });
      }//End Delete() [Post]
   }
}
