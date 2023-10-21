using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebTruyen.Controllers
{
    public class TrangChuController : Controller
    {
        // GET: TrangChu
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult NavPartial()
        {
            return View();
        }
        public ActionResult SliderPartial()
        {
            return PartialView();
        }
        public ActionResult Chitiettruyen()
        {
            return PartialView();
        }

    }
}