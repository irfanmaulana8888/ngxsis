using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xsis.Model;

namespace Xsis.Repo
{
    public class KeahlianRepo
    {
        public static List<Keahlian> GetAll()
        {
            List<Keahlian> result = new List<Keahlian>();
            using (var db = new DataContext())
            {
                //result = db.Keahlian.ToList();

                result = (from t in db.Keahlian
                          where t.is_delete == false
                          select t).ToList();
                //select new Keahlian { skill_name = t.skill_name, notes = t.notes, skill_level_id = t.skill_level_id }).ToList();


                //result = (from item in db.Keahlian
                //          where item.is_delete == false
                //          select new Keahlian { item.skill_name }).ToList();
                return result;
            }
        }

        public static List<Skill_Level> GetSelect()
        {
            List<Skill_Level> result = new List<Skill_Level>();
            using (var db = new DataContext())
            {
                result = db.Skill_Level.ToList();
                return result;
            }
        }

        public static Boolean Createkeahlian(Keahlian keahlianmdl)
        {
            try
            {
                Keahlian keahlian = new Keahlian();
                using (DataContext db = new DataContext())
                {
                    keahlian.biodata_id = 1;
                    keahlian.created_by=keahlianmdl.created_by;
                    keahlian.created_on = DateTime.Now.Date;
                    keahlian.skill_name = keahlianmdl.skill_name;
                    keahlian.skill_level_id = keahlianmdl.skill_level_id;
                    keahlian.notes = keahlianmdl.notes;
                    db.Keahlian.Add(keahlian);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public static Keahlian GetByID(int ID)
        {
            Keahlian keahlian = new Keahlian();
            using (DataContext db = new DataContext())
            {
                keahlian = db.Keahlian.Where(d => d.id == ID).First();
                return keahlian;
            }
        }

        
        public static Boolean Deletekeahlian(int ID, Keahlian keahlianmdl)
        {
            try
            {

                Keahlian dep;
                using (DataContext db = new DataContext())
                {
                    dep = db.Keahlian.Where(d => d.id == ID).First();
                    dep.is_delete = true;
                    dep.deleted_by = keahlianmdl.deleted_by;
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

        public static Boolean Editkeahlian(Keahlian keahlian)
        {
            try
            {
                Keahlian dep;
                using (DataContext db = new DataContext())
                {
                    dep = db.Keahlian.Where(d => d.id == keahlian.id).First();
                    dep.modified_by = keahlian.modified_by;
                    dep.modified_on = DateTime.Now.Date;
                    dep.notes = keahlian.notes;
                    dep.skill_level_id = keahlian.skill_level_id;
                    dep.skill_name = keahlian.skill_name;
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
