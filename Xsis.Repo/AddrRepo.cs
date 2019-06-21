using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xsis.Model;

namespace Xsis.Repo
{
    public class AddrRepo
    {
        public static List<AddrBook> GetAll()
        {
            List<AddrBook> result = new List<AddrBook>();
            using (var db = new DataContext())
            {

                result = (from t in db.AddrBook
                          where t.is_delete == false
                          select t).ToList();
      
                return result;
            }
        }

        public static AddrBook GetByEmail(string Email)
        {
            AddrBook addr = new AddrBook();
            using (DataContext db = new DataContext())
            {
                addr = db.AddrBook.Where(d => d.email == Email && d.is_delete == false).First();
                return addr;
            }
        }

        public static Boolean Deleteaddr(int ID, AddrBook addrmdl)
        {
            try
            {

                AddrBook dep;
                using (DataContext db = new DataContext())
                {
                    dep = db.AddrBook.Where(d => d.id == ID).First();
                    dep.is_delete = true;
                    dep.deleted_by = addrmdl.deleted_by;
                    dep.deleted_on = DateTime.Now;
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
