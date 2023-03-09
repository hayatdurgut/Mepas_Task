using DocumentFormat.OpenXml.Wordprocessing;
using Mepas_Task.DataLayer;
using Microsoft.AspNetCore.Mvc;

namespace Mepas_Task.Views.Shared.ViewComponents
{
    public class ProductListViewComponent : ViewComponent
    {
        private readonly IExcelRepository _excelRepository;
        public ProductListViewComponent(IExcelRepository excelRepository)
        {
            _excelRepository = excelRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var products = _excelRepository.GetProducts();
            return View(products);
        }
    }
}
