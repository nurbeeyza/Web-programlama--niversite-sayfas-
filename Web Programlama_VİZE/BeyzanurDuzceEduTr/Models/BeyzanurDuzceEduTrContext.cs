using BeyzanurDuzceEduTr.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeyzanurDuzceEduTr.Models
{
    public class BeyzanurDuzceEduTrContext : DbContext
    {
        public BeyzanurDuzceEduTrContext(DbContextOptions<BeyzanurDuzceEduTrContext> options)
            : base(options)
        { 
        

        }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Announcement> Announcements { get; set; }
    }
}
