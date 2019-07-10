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
    public class RencanaJadwalController : Controller
    {
        // GET: RencanaJadwal
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AmbilID()
        {
            return Json(RencanaJadwalRepo.GetLast(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Create()
        {
            return PartialView("_Create");
        }

        public ActionResult Edit()
        {
            return PartialView("_Edit");
        }

        public ActionResult AmbilData(int ID)
        {
            return Json(RencanaJadwalRepo.GetByID(ID), JsonRequestBehavior.AllowGet);
        }

        public ActionResult AmbilData2(int ID)
        {
            return Json(RencanaJadwalRepo.GetByID2(ID), JsonRequestBehavior.AllowGet);
        }


        public ActionResult Check()
        {
            return Json(RencanaJadwalRepo.GetCheck(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Save(RencanaJadwalViewModel rj)
        {
            rj.created_by = Convert.ToInt64(Session["foo"]);
            if (RencanaJadwalRepo.CreateRJ(rj))
            {
                return Json(new { Simpan = "Berhasil" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { Simpan = "Gagal" }, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult Cari(DateTime Dari, DateTime Sampai, string SortType)
        {
            return Json(RencanaJadwalRepo.GetData(Dari, Sampai, SortType), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Select()
        {
            return Json(RencanaJadwalRepo.GetSelect(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult EditSimpan(RencanaJadwalViewModel editrj)
        {
            editrj.modified_by = Convert.ToInt64(Session["foo"]);
            editrj.deleted_by = Convert.ToInt64(Session["foo"]);
            editrj.created_by = Convert.ToInt64(Session["foo"]);
            if (RencanaJadwalRepo.Editrencana(editrj))
            {
                return Json(new { EditSimpan = "Berhasil" }, JsonRequestBehavior.AllowGet); //return json digunakan untuk memunculkan alert
            }
            else
            {
                return Json(new { EditSimpan = "Gagal" }, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult DeleteCfr(int ID)
        {
            return PartialView("_Delete");
        }

        public ActionResult Delete(int ID, Rencana_Jadwal RJmdl)
        {
            RJmdl.deleted_by = Convert.ToInt64(Session["foo"]);
            if (RencanaJadwalRepo.Deleterencana(ID, RJmdl)) //non static if ( KeahlianRepo.Deletekeahlian(ID))
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