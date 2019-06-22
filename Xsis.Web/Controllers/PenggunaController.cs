using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Xsis.Repo;

namespace Xsis.Web.Controllers
{
    public class PenggunaController : Controller
    {
        // GET: Pengguna
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Tampil()
        {
            return Json(PenggunaRepo.GetAll(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult AmbilData(string ID)
        {
            return Json(PenggunaRepo.GetByID(ID), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Check()
        {
            return Json(PenggunaRepo.GetCheck(), JsonRequestBehavior.AllowGet);
        }

    }
}