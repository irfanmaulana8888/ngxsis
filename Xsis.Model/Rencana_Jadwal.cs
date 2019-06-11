using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xsis.Model
{

    [Table("x_rencana_jadwal")]
    public class Rencana_Jadwal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long rencana_jadwal_id { get; set; }

        public long created_by { get; set; }

        [Column(TypeName = "Date")]
        public DateTime created_on { get; set; }

        public long modified_by { get; set; }

        [Column(TypeName = "Date")]
        public DateTime modified_on { get; set; }

        public long deleted_by { get; set; }

        [Column(TypeName = "Date")]
        public DateTime deleted_on { get; set; }

        public Boolean is_delete { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        public string schedule_code { get; set; }

        [Column(TypeName = "Date")]
        public DateTime shcedule_date { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string time { get; set; }

        public long ro { get; set; }

        public long tro { get; set; }

        public long schedule_type_id { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string location { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string other_ro_tro { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(1000)]
        public string notes { get; set; }

        public Boolean is_automatic_mail { get; set; }

        [Column(TypeName = "Date")]
        public DateTime sent_date { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string status { get; set; }



    }
}