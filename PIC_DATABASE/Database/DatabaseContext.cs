using PIC_DATABASE.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIC_DATABASE.Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
    }
}
