using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xsis.Model
{

    [Table("x_riwayat_pendidikan")]
    public class Riwayat_Pendidikan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public long pendidikan_id { get; set; }


        [Required(AllowEmptyStrings = false)]
        public long created_by { get; set; }


        [Column(TypeName = "Date")]
        [Required(AllowEmptyStrings = false)]
        public DateTime created_on { get; set; }


        [Required(AllowEmptyStrings = true)]
        public long modified_by { get; set; }


        [Column(TypeName = "Date")]
        [Required(AllowEmptyStrings = true)]
        public DateTime modified_on { get; set; }


        [Required(AllowEmptyStrings = true)]
        public long deleted_by { get; set; }


        [Column(TypeName = "Date")]
        [Required(AllowEmptyStrings = true)]
        public DateTime deleted_on { get; set; }


        public Boolean is_delete { get; set; }


        [Required(AllowEmptyStrings = false)]
        public long biodata_id { get; set; }


        [Column(TypeName = "VARCHAR")]
        [StringLength(100)]
        [Required(AllowEmptyStrings = true)]
        public string school_name { get; set; }


        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        [Required(AllowEmptyStrings = true)]
        public string city { get; set; }


        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        [Required(AllowEmptyStrings = true)]
        public string country { get; set; }


        [Required(AllowEmptyStrings = true)]
        public long education_level_id { get; set; }


        [Column(TypeName = "VARCHAR")]
        [StringLength(10)]
        [Required(AllowEmptyStrings = true)]
        public string entry_year { get; set; }


        [Column(TypeName = "VARCHAR")]
        [StringLength(10)]
        [Required(AllowEmptyStrings = true)]
        public string graduation_year { get; set; }


        [Column(TypeName = "VARCHAR")]
        [StringLength(100)]
        [Required(AllowEmptyStrings = true)]
        public string major { get; set; }


        [Required(AllowEmptyStrings = true)]
        public double gpa { get; set; }


        [Column(TypeName = "VARCHAR")]
        [StringLength(1000)]
        [Required(AllowEmptyStrings = true)]
        public string notes { get; set; }


        [Required(AllowEmptyStrings = true)]
        public int order { get; set; }


        [Column(TypeName = "VARCHAR")]
        [StringLength(255)]
        [Required(AllowEmptyStrings = true)]
        public string judul_ta { get; set; }


        [Column(TypeName = "VARCHAR")]
        [StringLength(5000)]
        [Required(AllowEmptyStrings = true)]
        public string deskripsi_ta { get; set; }
    }
}