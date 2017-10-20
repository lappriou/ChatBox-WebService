using Dashboard.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Dashboard.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            var context = new IndexViewModel();
            await context.InitAsync();
            return View(context);
        }


        public async Task<ActionResult> ListPoll()
        {
            var context = new ListPollViewModel();
            await context.InitRacletteListAsync();
            return View(context);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}