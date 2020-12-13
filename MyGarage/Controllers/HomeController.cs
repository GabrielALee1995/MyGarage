using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyGarage.Controllers
{
   public class HomeController : Controller
   {
      //   F i e l d s   &   P r o p e r t i e s

      //   C o n s t r u c t o r s

      //   M e t h o d s
      public IActionResult Index()
      {
         return View();
      }
   }
}
