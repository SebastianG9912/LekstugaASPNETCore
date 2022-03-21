using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmptyASPNETCore.Models;
using Microsoft.EntityFrameworkCore;

namespace EmptyASPNETCore.Data
{
    public class BirthdayDbContext : DbContext
    {
        public DbSet<Birthday> Birthdays { get; set; }

        public BirthdayDbContext(){}
        public BirthdayDbContext(DbContextOptions<BirthdayDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
