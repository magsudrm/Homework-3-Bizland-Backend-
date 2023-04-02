using Homework_3_Bizland__Backend_.Models;
using Homework_3_Bizland__Backend_.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Homework_3_Bizland__Backend_.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            HomeViewModel homeVM = new HomeViewModel
            {
                Teams = Data.teamList,
                Services = Data.serviceList
            };
            return View(homeVM);
        }
        public IActionResult Contact()
        {
            return View();
        }
    }
}
