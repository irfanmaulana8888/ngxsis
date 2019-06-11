using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xsis.Model
{

    [Table("x_riwayat_pekerjaan")]
    public class Riwayat_Pekerjaan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long riwayat_pekerjaan_id { get; set; }

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

        public long biodata_id { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string city { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string country { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string joinYear { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string joinMonth { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string resignYear { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string resignMonth { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string lastPosition { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        public string income { get; set; }

        public Boolean isitRelated { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(1000)]
        public string aboutJob { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(500)]
        public string exitReason { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(5000)]
        public string notes { get; set; }
    }
}