using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xsis.Model;

namespace Xsis.Repo
{
    public class PekerjaanRepo
    {
        public static List<Riwayat_Pekerjaan> GetAll()
        {
            List<Riwayat_Pekerjaan> result = new List<Riwayat_Pekerjaan>();
            using (var db = new DataContext())
            {
                //result = db.Keahlian.ToList();

                result = (from t in db.Riwayat_Pekerjaan
                          where t.is_delete == false
                          select t).ToList();
                //select new Keahlian { skill_name = t.skill_name, notes = t.notes, skill_level_id = t.skill_level_id }).ToList();


                //result = (from item in db.Keahlian
                //          where item.is_delete == false
                //          select new Keahlian { item.skill_name }).ToList();
                return result;
            }
        }

        public static Boolean Createpekerjaan(Riwayat_Pekerjaan pekerjaanmdl)
        {
            try
            {
                //Riwayat_Pekerjaan pekerjaan = new Riwayat_Pekerjaan();
                using (DataContext db = new DataContext())
                {
                    //pekerjaan.biodata_id = 1;
                    //pekerjaan.created_by = keahlianmdl.created_by;
                    //pekerjaan.created_on = DateTime.Now.Date;
                    //pekerjaan.skill_name = keahlianmdl.skill_name;
                    //pekerjaan.skill_level_id = keahlianmdl.skill_level_id;
                    //pekerjaan.notes = keahlianmdl.notes;
                    pekerjaanmdl.biodata_id = 1;
                    pekerjaanmdl.created_by = pekerjaanmdl.created_by;
                    pekerjaanmdl.created_on = DateTime.Now.Date;
                    db.Riwayat_Pekerjaan.Add(pekerjaanmdl);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public static Boolean Deletepekerjaan(int ID, Riwayat_Pekerjaan pekerjaanmdl)
        {
            try
            {

                Riwayat_Pekerjaan dep;
                using (DataContext db = new DataContext())
                {
                    dep = db.Riwayat_Pekerjaan.Where(d => d.id == ID).First();
                    dep.is_delete = true;
                    dep.deleted_by = pekerjaanmdl.deleted_by;
                    dep.deleted_on = DateTime.Now.Date;
                    db.Entry(dep).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
