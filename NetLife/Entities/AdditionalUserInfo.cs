using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetLife.Entities
{
    [Table("tblAditionalInfos")]
    public class AdditionalUserInfo
    {
        [Key]
        public int Id { get; set; }

        [Required, ForeignKey("UserData")]
        public int IdOfUser { get; set; }

        [Required]
        public int WorkExperience { get; set; }

        public virtual User UserData { get; set; }

        //public Image Img { get; set; }
    }
}
