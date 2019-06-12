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
            using (DataContext db = new DataContext())
            {
                result = db.Keahlian.ToList();
                //var query = from t in db.Keahlian
                //            where t.is_delete == false
                //            select new { t.col1, t.col2, t.col3 };
                //var myObject = query.SingleOrDefault();

            }
            return result;
        }

        public static Boolean Createkeahlian(Keahlian keahlianmdl)
        {
            try
            {
                Keahlian keahlian = new Keahlian();
                using (DataContext db = new DataContext())
                {
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

    }
}
