using Microsoft.EntityFrameworkCore;
using Reppair_App.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reppair_App
{
    public class VehicleContext : DbContext
    {
        public VehicleContext(DbContextOptions options): base(options)
        {
        }

        public DbSet<Battery> Batteries { get; set; }
        public DbSet<Engine> Engines { get; set; }
        public DbSet<Tire> Tires { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{

        //    //cia mes konfiguruojame sarysi many to many Studentas turi daug paskaitu
        //    modelBuilder.Entity<StudentLecture>()
        //        .HasKey(sl => new { sl.StudentId, sl.LectureId }); // sujungta su dviem raktais

        //    modelBuilder.Entity<StudentLecture>()                  //joininam lenteles
        //        .HasOne(sl => sl.Student)                          // Studenta jungiam prie paskaitos
        //        .WithMany(b => b.StudentLectures)                  // prie bendros lentos jungiam studenta
        //        .HasForeignKey(sl => sl.StudentId);                // pagal student id

        //    modelBuilder.Entity<StudentLecture>()                  // join lenta
        //        .HasOne(dl => dl.Lecture)                          // Paskaita joininam prie Studento
        //        .WithMany(c => c.StudentLectures)                  // prie bendros lentos jungiam kategorija
        //        .HasForeignKey(sl => sl.LectureId);                // pagal Paskaitos id
        //}


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer($"Server=localhost;Database=Reppair_App;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }
    }
}
