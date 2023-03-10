using Microsoft.AspNetCore.Mvc;

namespace Mepas_Task.Controllers
{

    public class BaseController : Controller
    {
        public long CurrentUserId
        {
            get
            {
                return Convert.ToInt64(User.Claims.ToList()[1].Value);
            }
        }
    }
}
