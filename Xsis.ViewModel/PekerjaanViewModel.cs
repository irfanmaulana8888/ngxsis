using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xsis.ViewModel
{
    public class PekerjaanViewModel
    {
        //riwayat pekerjaan
        public long id { get; set; }

        [Required(AllowEmptyStrings = false)]
        public long created_by { get; set; }

        [Column(TypeName = "DateTime")]
        [Required(AllowEmptyStrings = false)]
        public DateTime created_on { get; set; }

        public Nullable<long> modified_by { get; set; }

        [Column(TypeName = "DateTime")]
        public Nullable<DateTime> modified_on { get; set; }

        public Nullable<long> deleted_by { get; set; }

        [Column(TypeName = "DateTime")]
        public Nullable<DateTime> deleted_on { get; set; }

        public Boolean is_delete { get; set; }

        public long biodata_id { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string company_name { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string city { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string country { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string join_year { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string join_month { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string resign_year { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string resign_month { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string last_position { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        public string income { get; set; }

        public Nullable<Boolean> is_it_related { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(1000)]
        public string about_job { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(500)]
        public string exit_reason { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(5000)]
        public string notes { get; set; }

        //riwayat proyek
        public long id_proyek { get; set; }

        public long riwayat_pekerjaan_id { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string start_year { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string start_month { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string project_name { get; set; }

        public Nullable<int> project_duration { get; set; }

        public Nullable<long> time_period_id { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string client { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string project_position { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(1000)]
        public string description { get; set; }
    }
}
