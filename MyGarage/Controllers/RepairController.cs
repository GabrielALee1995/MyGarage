using Microsoft.AspNetCore.Mvc;
using MyGarage.Models;
using System;
using System.Linq;

namespace MyGarage.Controllers
{
   public class RepairController : Controller
   {
      //   F i e l d s   &   P r o p e r t i e s
      private IRepairRepository _repository;
      private IVehicleRepository _vehicleRepository;

      //   C o n s t r u c t o r s
      public RepairController(IRepairRepository repository, IVehicleRepository vehicleRepository)
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

         Repair r = new Repair();
         r.Vehicle = v;
         r.VehicleId = v.Mileage;
         r.VehicleMileage = v.Mileage;
         return View(r);
      }//End Add() [Get]

      [HttpPost]
      public IActionResult Add(Repair r)
      {
         if (ModelState.IsValid)
         {
            Vehicle v = _vehicleRepository.GetVehicleById(r.VehicleId);

            if (r.VehicleMileage > v.Mileage)
            {
               v.Mileage = r.VehicleMileage;
            }

            _repository.CreateRepair(r);
            return RedirectToAction("ListRepairs", new { vehicleId = r.VehicleId });
         }
         return View(r);
      }//End Add() [Post]

      //   R e a d
      public IActionResult ListRepairs(int vehicleId)
      {
         IQueryable<Repair> vehicleRepairs = _repository.GetVehicleRepairs(vehicleId);

         float total = 0;

         foreach (Repair r in vehicleRepairs)
         {
            total += r.Cost.Value;
         }

         ViewBag.TotalRepairCost = total.ToString("C");

         Vehicle vehicle = _vehicleRepository.GetVehicleById(vehicleId);
         ViewBag.VehicleNickName = vehicle.NickName;
         ViewBag.VehicleId = vehicle.Id;

         return View(vehicleRepairs);
      }//End ListRepairs()

      public IActionResult Details(int repairId)
      {
         Repair r = _repository.GetRepairById(repairId);

         Vehicle v = _vehicleRepository.GetVehicleById(r.VehicleId);
         ViewBag.VehicleNickName = v.NickName;

         return View(r);
      }//End Details()

      //   U p d a t e
      [HttpGet]
      public IActionResult Edit(int repairId)
      {
         Repair r = _repository.GetRepairById(repairId);
         Vehicle v = _vehicleRepository.GetVehicleById(r.VehicleId);
         ViewBag.VehicleNickName = v.NickName;
         ViewBag.VehicleId = v.Id;

         return View(r);
      }//End Edit() [Get]

      [HttpPost]
      public IActionResult Edit(Repair updatedRepair)
      {
         if(ModelState.IsValid)
         {
            _repository.UpdateRepair(updatedRepair);
            return RedirectToAction("ListRepairs", "Repair", new { vehicleId = updatedRepair.VehicleId });
         }
         return View(updatedRepair);
      }//End Edit() [Post]

      //   D e l e t e
      [HttpGet]
      public IActionResult Delete(int repairId)
      {
         Repair r = _repository.GetRepairById(repairId);

         Vehicle v = _vehicleRepository.GetVehicleById(r.VehicleId);
         ViewBag.VehicleNickName = v.NickName;
         ViewBag.VehicleId = v.Id;

         if (r == null)
         {
            return RedirectToAction("ListRepairs", "Repair", new { vehicleId = r.VehicleId });
         }
         return View(r);
      }//End Delete() [Get]

      [HttpPost]
      public IActionResult Delete(Repair r)
      {
         _repository.DeleteRepair(r.Id);
         return RedirectToAction("ListRepairs", "Repair", new { vehicleId = r.VehicleId });
      }//End Delete() [Post]
   }
}
