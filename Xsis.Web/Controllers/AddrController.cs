using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Xsis.Model;
using Xsis.Repo;
using Xsis.ViewModel;

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

        public ActionResult Tampil2()
        {
            return Json(AddrRepo.GetAll(), JsonRequestBehavior.AllowGet);
        }


        public ActionResult AmbilData(string Email)
        {
            return Json(AddrRepo.GetByEmail(Email), JsonRequestBehavior.AllowGet);
        }

        public ActionResult AmbilData2(int ID)
        {
            return Json(AddrRepo.GetByID2(ID), JsonRequestBehavior.AllowGet);
        }


        public ActionResult Save(AddrViewModel addr)
        {
            addr.created_by = Convert.ToInt64(Session["foo"]);
            if (AddrRepo.Createaddr(addr))
            {
                return Json(new { Simpan = "Berhasil" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { Simpan = "Gagal" }, JsonRequestBehavior.AllowGet);
            }
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