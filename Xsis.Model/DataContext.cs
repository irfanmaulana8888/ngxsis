using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xsis.Model
{
    public class DataContext : DbContext
    {
        public DataContext() : base("Name=NgxsisConn")
        {
            Database.SetInitializer(new Initializer());
            //Database.SetInitializer<DataContext>(null);
        }

        public virtual DbSet<AddrBook> AddrBook { get; set; }
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<Biodata> Biodata { get; set; }
        public virtual DbSet<Biodata_Attachment> Biodata_Attachment { get; set; }
        public virtual DbSet<Catatan> Catatan { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<Educational_Level> Educational_Level { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
