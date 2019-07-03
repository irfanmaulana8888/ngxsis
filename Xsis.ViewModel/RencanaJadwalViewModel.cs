using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xsis.ViewModel
{
    public class RencanaJadwalViewModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long id { get; set; }

        [Required(AllowEmptyStrings = false)]
        public long created_by { get; set; }

        [Column(TypeName = "Date")]
        [Required(AllowEmptyStrings = false)]
        public DateTime created_on { get; set; }

        public Nullable<long> modified_by { get; set; }

        [Column(TypeName = "Date")]
        public Nullable<DateTime> modified_on { get; set; }

        public Nullable<long> deleted_by { get; set; }

        [Column(TypeName = "Date")]
        public Nullable<DateTime> deleted_on { get; set; }

        public Boolean is_delete { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        public string schedule_code { get; set; }

        [Column(TypeName = "Date")]
        public Nullable<DateTime> schedule_date { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string time { get; set; }

        public Nullable<long> ro { get; set; }

        public Nullable<long> tro { get; set; }

        public Nullable<long> schedule_type_id { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string location { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string other_ro_tro { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(1000)]
        public string notes { get; set; }

        public Nullable<Boolean> is_automatic_mail { get; set; }

        [Column(TypeName = "Date")]
        public Nullable<DateTime> sent_date { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string status { get; set; }

        public string biodata_id { get; set; }
    }
}
