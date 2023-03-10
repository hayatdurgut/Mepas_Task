using Mepas_Task.DataLayer;
using Mepas_Task.Models;
using Mepas_Task.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Mepas_Task.Controllers
{
    [Authorize]
    public class HomeController : BaseController
    {
     
        public IActionResult Index()
        {
            return View();
        }

    
    }
}