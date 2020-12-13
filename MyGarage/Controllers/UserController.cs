using Microsoft.AspNetCore.Mvc;
using MyGarage.Models;

namespace MyGarage.Controllers
{
   public class UserController : Controller
   {
      //   F i e l d s   &   P r o p e r t i e s
      private IUserRepository _repository;

      //   C o n s t r u c t o r s
      public UserController(IUserRepository repository)
      {
         _repository = repository;
      }
      //   M e t h o d s

      //   C r e a t e
      [HttpGet]
      public IActionResult Register()
      {
         return View();
      } //End Add( ) [Get]

      [HttpPost]
      public IActionResult Register(User u)
      {
         _repository.AddUser(u);
         if (u.Id < 1)
         {
            return View(u);
         }

         return RedirectToAction("ListVehicles", "Vehicle", new { userId = u.Id });
      } //End Add( ) [Post]

      //   R e a d
      public IActionResult Details(int userId)
      {
         User u = _repository.GetUserById(userId);
         return View(u);
      }

      [HttpGet]
      public IActionResult Login()
      {
         return View();
      }//End Login [Get]

      [HttpPost]
      public IActionResult Login(User u)
      {
         User loginUser = _repository.GetUserByEmail(u.Email);
         int _userId = loginUser.Id;
         bool validUser = _repository.Login(u);
         if (validUser == true)
         {
            return RedirectToAction("ListVehicles", "Vehicle", new { userId = _userId }); //("View", "Controller", parameter)
         }
         return View();
      }//End Login() [Post]

      //   U p d a t e
      [HttpGet]
      public IActionResult UpdateEmail(int userId)
      {
         User u = _repository.GetUserById(userId);
         return View(u);
      }//End EditEmail() [Get]

      [HttpPost]
      public IActionResult UpdateEmail(User updatedUser)
      {
         if (ModelState.IsValid)
         {
            _repository.UpdateUser(updatedUser);
            return RedirectToAction("Details", new { userId = updatedUser.Id });
         }
         return View(updatedUser);
      }//End EditEmail() [Post]

      [HttpGet]
      public IActionResult UpdatePassword(int userId)
      {
         User u = _repository.GetUserById(userId);
         return View(u);
      }//End EditPassword() [Get]

      [HttpPost]
      public IActionResult UpdatePassword(User updatedUser)
      {
         if (ModelState.IsValid)
         {
            _repository.UpdateUserPassword(updatedUser);
            return RedirectToAction("Details", new { userId = updatedUser.Id });
         }
         return View(updatedUser);
      }//End EditPassword() [Post]

      //   D e l e t e
      [HttpGet]
      public IActionResult Delete(int userId)
      {
         User u = _repository.GetUserById(userId);
         if (u == null)
         {
            return RedirectToAction("Details", "User", new { userId = u.Id });
         }
         return View(u);
      }//End Delete() [Get]

      [HttpPost]
      public IActionResult Delete(User u)
      {
         _repository.DeleteUser(u.Id);
         return RedirectToAction("Index", "Home");
      }//End Delete() [Post]
   }
}
