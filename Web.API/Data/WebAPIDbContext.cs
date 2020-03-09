using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.API.Entities;

namespace Web.API.Data
{
    public class WebAPIDbContext : DbContext
    {
        public WebAPIDbContext(DbContextOptions<WebAPIDbContext> options) : base(options)
        {

        }
        public DbSet<Storage> Storages { get; set; }
        public DbSet<Upload> Uploads{ get; set; }
        public DbSet<Download> Downloads { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Storage>().Property(x => x.Pru).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Storage>().Property(x => x.Pruspec).IsRequired();
            modelBuilder.Entity<Storage>().Property(x => x.Prunum).IsRequired();
            modelBuilder.Entity<Upload>().Property(x => x.Id).IsRequired();
            modelBuilder.Entity<Upload>().Property(x => x.Date).IsRequired();
            modelBuilder.Entity<Upload>().Property(x => x.Remark).HasMaxLength(100);
            modelBuilder.Entity<Download>().Property(x => x.Id).IsRequired();
            modelBuilder.Entity<Download>().Property(x => x.Date).IsRequired();
            modelBuilder.Entity<Download>().Property(x => x.Remark).HasMaxLength(100);
            modelBuilder.Entity<Storage>().HasData(
               new Storage
               {
                   Pru = "产品1",
                   Pruspec = "规格1",
                   Prunum = 1
               },
               new Storage
               {
                   Pru = "产品2",
                   Pruspec = "规格2",
                   Prunum = 2
               },
               new Storage
               {
                   Pru = "产品3",
                   Pruspec = "规格3",
                   Prunum = 3
               },
                new Storage
                {
                    Pru = "产品4",
                    Pruspec = "规格4",
                    Prunum = 4
                },
               new Storage
               {
                   Pru = "产品5",
                   Pruspec = "规格5",
                   Prunum = 5
               },
               new Storage
               {
                   Pru = "产品6",
                   Pruspec = "规格6",
                   Prunum = 6
               }

               );
        }


    }
}
