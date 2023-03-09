using Mepas_Task.DataLayer;
using Mepas_Task.Models;
using Microsoft.AspNetCore.Mvc;

namespace Mepas_Task.Controllers
{
    public class LoginController : Controller
    {

        private readonly ILogger<LoginController> _logger;

        private readonly IExcelRepository _excelRepository;

        public LoginController(ILogger<LoginController> logger, IExcelRepository excelRepository)
        {
            _logger = logger;
            _excelRepository = excelRepository;

        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

      
        public bool UserControl(string username, string password)
        {
            var user = _excelRepository.GetUsers().ToList().Where(x => x.Username == username && x.Password == password).FirstOrDefault();
            if (user != null)
            {
                return true;
            }
            else
            {
                return false;
            }
                
        }

        public bool CheckApprove( string approvalCode)
        {
            if (approvalCode == "1111")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
