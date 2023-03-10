using Mepas_Task.DataLayer;
using Mepas_Task.Models;
using Mepas_Task.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Mepas_Task.Controllers
{
    [Authorize]
    public class ProductController : BaseController
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


        //Ürün ekleme sayfası açılır.
        [HttpGet]
        public IActionResult ProductAdd()
        {
            return View();
        }

        //Ürün ekleme işlemi gerçekleştirilir.
        [HttpPost]
        public IActionResult ProductAdd(Products product)
        {
                _excelRepository.AddProduct(product);
                return RedirectToAction("Index");
        }


        // Ürün güncelleme sayfası açılır. Ürün bilgileri ilgili girdi alanlarına yerleştirilir.
        [HttpGet]
        public IActionResult ProductUpdate(int id)
        {
            var product = _excelRepository.GetProducts().ToList().Where(x=>x.Id==id).FirstOrDefault();
            
            return View(product);
        }



        //Güncelleme işlemini gerçekleştirecek fonksiyon.
        [HttpPost]
        public IActionResult ProductUpdate(Products product)
        {
            return RedirectToAction("Index");
        }
    }
}
