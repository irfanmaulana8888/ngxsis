using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xsis.Model
{
    [Table("x_sertifikasi")]
    public class Sertifikasi
    {
        [Key]
        // ID AUTO INCREAMENT PRIMARY KEY
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(AllowEmptyStrings = false)]
        public long id { get; set; }

        [Required(AllowEmptyStrings = false)]
        public long created_by { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Column(TypeName = "Date")]
        public DateTime create_on { get; set; }

        public long modified_by { get; set; }

        [Column(TypeName = "Date")]
        public DateTime modified_on { get; set; }

        public long delete_by { get; set; }

        [Column(TypeName = "Date")]
        public DateTime delete_on { get; set; }

        [Required(AllowEmptyStrings = false)]
        public Boolean is_delete { get; set; }

        [Required(AllowEmptyStrings = false)]
        public long biodata_id { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(200)]
        public string certificate_name { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string publisher { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string valid_start_year { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string valid_start_month { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string until_year { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string until_month { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(1000)]
        public string notes { get; set; }
    }
}