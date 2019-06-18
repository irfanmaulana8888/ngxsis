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
        public static AddrBook GetByID(string ID)
        {
            AddrBook addr = new AddrBook();
            using (DataContext db = new DataContext())
            {
                addr = db.AddrBook.Where(d => d.email == ID).First();
                return addr;
            }
        }
    }
}
