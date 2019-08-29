using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetLife.Entities
{
    [Table("tblImages")]
    public class Image
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("UserPhoto")]
        public int UserId { get; set; }

        public string Image32 { get; set; }

        public string Image64 { get; set; }

        public string Image512 { get; set; }

        public virtual User UserPhoto { get; set; }
    }
}
