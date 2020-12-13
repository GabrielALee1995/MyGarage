using Microsoft.AspNetCore.Mvc;
using MyGarage.Models;
using System.Linq;

namespace MyGarage.Controllers
{
   public class VehicleController : Controller
   {
      //   F i e l d s   &   P r o p e r t i e s
      private IVehicleRepository _repository;
      private IUserRepository _userRepository;

      //   C o n s t r u c t o r s
      public VehicleController(IVehicleRepository repository, IUserRepository userRepository)
      {
         _repository = repository;
         _userRepository = userRepository;
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
         Vehicle v = _repository.GetVehicleById(vehicleId);
         return View(v);
      }//End VehicleDetails

      //   U p d a t e
      [HttpGet]
      public IActionResult Edit(int vehicleId)
      {
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
