using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xsis.Model
{

    [Table("x_riwayat_proyek")]
    public class Riwayat_Proyek
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long riwayat_proyek_id { get; set; }

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

        public int project_duration { get; set; }

        public long time_period_id { get; set; }

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