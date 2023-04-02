
using Homework_3_Bizland__Backend_.Models;
using Microsoft.AspNetCore.Mvc;

namespace Homework_3_Bizland__Backend_.Controllers
{
    public class TeamController : Controller
    {
        public IActionResult Index()
        {
            return View(Data.teamList);
        }
        public IActionResult Detail(int id)
        {
            Team team = Data.teamList.Find(x => x.Id == id);

            return View(team);
        }
    }
}
