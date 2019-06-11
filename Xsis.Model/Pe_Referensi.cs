using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xsis.Model
{

    [Table("x_pe_referensi")]
    public class Pe_Referensi
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long pe_referensi_id { get; set; }

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
        [StringLength(100)]
        public string name { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string position { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(1000)]
        public string address_phone { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string relation { get; set; }

    }
}