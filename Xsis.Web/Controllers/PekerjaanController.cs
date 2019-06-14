using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Xsis.Repo;

namespace Xsis.Web.Controllers
{
    public class PekerjaanController : Controller
    {
        // GET: Pekerjaan
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Tampil()
        {
            return Json(PekerjaanRepo.GetAll(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Create()
        {
            return PartialView("_Create");
        }
    }
}