using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetLife.Entities
{
    [Table("tblNews")]
    public class New
    {
        [Key]
        public int Id { get; set; }

        [Required, ForeignKey("IdOfUser")]
        public int IdUser { get; set; }

        [Required, StringLength(4000)]
        public string TextOfNew { get; set; }

        public virtual User IdOfUser { get; set; }
    }
}
