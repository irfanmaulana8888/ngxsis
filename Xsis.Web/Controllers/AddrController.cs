using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Xsis.Model;
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

        public ActionResult Tampil()
        {
            return Json(AddrRepo.GetAll(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult AmbilData(string Email)
        {
            return Json(AddrRepo.GetByEmail(Email), JsonRequestBehavior.AllowGet);
        }

        public ActionResult DeleteCfr(int ID)
        {
            return PartialView("_Delete");
        }

        public ActionResult Delete(int ID, AddrBook addrmdl)
        {
            addrmdl.deleted_by = Convert.ToInt64(Session["foo"]);
            if (AddrRepo.Deleteaddr(ID, addrmdl))
            {
                return Json(new { Hapus = "Berhasil" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { Hapus = "Gagal" }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}