using HISSystem.Filters;
using HISSystem.Helper;
using Microsoft.AspNetCore.Mvc;

namespace HISSystem.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        [CustomAuth(Page.Dashboard, ActionButton.Index)]
        public IActionResult Index()
        {
            return View();
        }
    }
}