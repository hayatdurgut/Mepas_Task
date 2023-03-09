using Mepas_Task.DataLayer;
using Mepas_Task.Models;
using Mepas_Task.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Mepas_Task.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    
    }
}