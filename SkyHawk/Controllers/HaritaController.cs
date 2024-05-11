using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SkyHawk.Models;

namespace SkyHawk.Controllers
{
    public class HaritaController: Controller
    {
        public IActionResult Index(){
            return View();
        }
    }
}