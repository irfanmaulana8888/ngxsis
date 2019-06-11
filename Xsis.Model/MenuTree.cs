using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xsis.Model
{

    [Table("x_menutree")]
    public class MenuTree
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long menu_tree_id { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string title { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string menu_image_url { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string menu_icon { get; set; }

        public int menu_order { get; set; }

        public int menu_level { get; set; }

        public long menu_parent { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string menu_url { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string menu_type { get; set; }

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

    }
}
