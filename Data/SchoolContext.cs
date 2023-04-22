using Labb2_Advanced_LINQ.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_Advanced_LINQ.Data
{
    internal class SchoolContext : DbContext
    {
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Subject> Subjects { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teacher>()
                .HasData(
                new Teacher { TeacherId = 1, Name = "Anas" },
                new Teacher { TeacherId = 2, Name = "Reidar" },
                new Teacher { TeacherId = 3, Name = "Tobias" },
                new Teacher { TeacherId = 4, Name = "Kristian" });
            modelBuilder.Entity<Student>()
                .HasData(
                new Student { StudentId = 1, Name = "Patrik Skattberg", TeacherId = 1 },
                new Student { StudentId = 2, Name = "Leo Fridh", TeacherId = 2 },
                new Student { StudentId = 3, Name = "Tim Nilsson", TeacherId = 3 },
                new Student { StudentId = 4, Name = "Sebastian Gamboa", TeacherId = 4 },
                new Student { StudentId = 5, Name = "Theo Esberg", TeacherId = 3 },
                new Student { StudentId = 6, Name = "Petter Nomijah", TeacherId = 1 });
            modelBuilder.Entity<Course>()
                .HasData(
                new Course { CourseId = 1, Name = "SUT22" });
            modelBuilder.Entity<Subject>()
                .HasData(
                new Subject { SubjectId = 1, Name = "Advanced.NET" },
                new Subject { SubjectId = 2, Name = "Frontend Webdev" },
                new Subject { SubjectId = 3, Name = "Database" },
                new Subject { SubjectId = 4, Name = "Math" },
                new Subject { SubjectId = 5, Name = "Programmering 1"});

            modelBuilder.Entity<Student>()
                .HasOne(t => t.Teacher)
                .WithMany(t => t.Students);

            modelBuilder.Entity<Teacher>()
                .HasMany(s => s.Subjects);

            modelBuilder.Entity<Course>()
                .HasMany(s => s.Subjects);

            modelBuilder.Entity<Subject>()
                .HasOne(t => t.Teachers);

            modelBuilder.Entity<Subject>()
                .HasMany(s => s.Students);

            modelBuilder.Entity<Student>()
                .HasMany(s => s.Subjects);


        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = DESKTOP-0NQQOBN; Initial Catalog = AdvancedSchoolDB; Integrated Security = True; Trust Server Certificate=true;");
        }
    }
}
