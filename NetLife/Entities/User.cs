using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetLife.Entities
{
    [Table("tblUsers")]
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(200)]
        public string Name { get; set; }

        public string Surname { get; set; }

        [Required]

        public int Age { get; set; }

        [Required, StringLength(10)]
        public int Gender { get; set; }

        [Required, StringLength(200)]
        public string UserName { get; set; }

        public string Password { get; set; }
    }
}
