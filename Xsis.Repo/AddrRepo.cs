using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Xsis.Model;
using Xsis.ViewModel;

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

                string password = addr.abpwd;

                System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
                System.Text.Decoder utf8Decode = encoder.GetDecoder();
                byte[] todecode_byte = Convert.FromBase64String(password);
                int charCount = utf8Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
                char[] decoded_char = new char[charCount];
                utf8Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
                string result = new String(decoded_char);

                addr.abpwd = result;

                return addr;
            }
        }

        public static long GetLast()
        {

            List<AddrBook> result = new List<AddrBook>();
            using (var db = new DataContext())
            {

                result = (from t in db.AddrBook
                          select t).ToList();

                long length = result.Count();

                return length;
            }
        }

        public static List<UserRole> GetByID2(int ID)
        {
            List<UserRole> roles = new List<UserRole>();
            using (DataContext db = new DataContext())
            {
                roles = db.UserRole.Where(d => d.addrbok_id == ID && d.is_delete == false).ToList();
                return roles;
            }
        }

        public static Boolean Createaddr(AddrViewModel addrmdl)
        {
            try
            {
                AddrBook addr = new AddrBook();
                using (DataContext db = new DataContext())
                {
                    addr.created_by = addrmdl.created_by;
                    addr.created_on = DateTime.Now;
                    addr.email = addrmdl.email;
                    addr.abuid = addrmdl.email;

                    string password = addrmdl.abpwd;

                    byte[] encData_byte = new byte[password.Length];
                    encData_byte = System.Text.Encoding.UTF8.GetBytes(password);
                    string encodedData = Convert.ToBase64String(encData_byte);

                    addr.abpwd = encodedData;
                    db.AddrBook.Add(addr);
                    db.SaveChanges();

                    UserRole role = new UserRole();
                    var a = addrmdl.role_id;
                    string[] rolid = a.Split(',');
                    var last = GetLast();

                    foreach (var item in rolid)
                    {
                        role.created_by = addrmdl.created_by;
                        role.created_on = DateTime.Now;
                        role.addrbok_id = last;
                        role.role_id = Convert.ToInt16(item);
                        db.UserRole.Add(role);
                        db.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception)
            {

                return false;
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
