using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Xsis.Repo;

namespace Xsis.Web.Controllers
{
    public class AddrController : Controller
    {
        // GET: Addr
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AmbilData(string ID)
        {
            return Json(AddrRepo.GetByID(ID), JsonRequestBehavior.AllowGet);
        }
    }
}