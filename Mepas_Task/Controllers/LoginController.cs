using DocumentFormat.OpenXml.Spreadsheet;
using Mepas_Task.DataLayer;
using Mepas_Task.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Mepas_Task.Controllers
{
    public class LoginController : BaseController
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

        // Kullanıcı adı ve şifresini kontrol eder.
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


        // Doğrulama kodunun kontrolünü gerçekleştirir.
        public bool CheckApprove( string approvalCode)
        {
            if (_excelRepository.CheckApproval(approvalCode))
            {
                return true;
               
            }
            else
            {
                return false;
            }
        }


        //public async Task<IActionResult> Login(int userId)
        //{
        //    var claims = new List<Claim>
        //        {
        //            new Claim(ClaimTypes.Name,userId.ToString())
        //        };
        //    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
        //    var authProperties = new AuthenticationProperties();
        //    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProperties);
        //    return RedirectToAction("Index", "Home");
        //}
    }
}
