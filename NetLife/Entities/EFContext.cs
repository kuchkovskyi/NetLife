using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetLife.Entities
{
    public class EFContext:DbContext
    {
        public EFContext() : base("ConnString")
        {

        }

        public DbSet<User> Users { get; set; }

        public DbSet<New> News { get; set; }
    }
}
