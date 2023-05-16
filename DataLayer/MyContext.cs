using EntityLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class MyContext:DbContext
    {
        public MyContext(DbContextOptions<MyContext> options)
            :base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Deneme1> Deneme1 { get; set; }
        public DbSet<Deneme2> Deneme2 { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Deneme2>(b =>
            {
                b.ToTable("Deneme2Table");
                b.Property(x => x.Id).ValueGeneratedOnAdd().UseIdentityColumn(20, 3);
            });
        }
    }
}
