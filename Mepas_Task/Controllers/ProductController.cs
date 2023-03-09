using Mepas_Task.DataLayer;
using Mepas_Task.Models;
using Mepas_Task.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Mepas_Task.Controllers
{
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;

        private readonly IExcelRepository _excelRepository;

        public ProductController(ILogger<ProductController> logger, IExcelRepository excelRepository)
        {
            _logger = logger;
            _excelRepository = excelRepository;
           
        }


        public IActionResult Index()
        {
            
            return View();
        }

        [HttpGet]
        public IActionResult ProductAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ProductAdd(Products product)
        {


            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult ProductUpdate(int id)
        {
            var product = _excelRepository.GetProducts().ToList().Where(x=>x.Id==id).FirstOrDefault();
            
            return View(product);
        }
        [HttpPost]
        public IActionResult ProductUpdate(Products product)
        {
           

            return RedirectToAction("Index");
        }
    }
}
