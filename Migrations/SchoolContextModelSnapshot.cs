﻿// <auto-generated />
using System;
using Labb2_Advanced_LINQ.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Labb2AdvancedLINQ.Migrations
{
    [DbContext(typeof(SchoolContext))]
    partial class SchoolContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Labb2_Advanced_LINQ.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseId"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CourseId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            CourseId = 1,
                            Name = "SUT22"
                        });
                });

            modelBuilder.Entity("Labb2_Advanced_LINQ.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("StudentId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            Name = "Patrik Skattberg",
                            TeacherId = 1
                        },
                        new
                        {
                            StudentId = 2,
                            Name = "Leo Fridh",
                            TeacherId = 2
                        },
                        new
                        {
                            StudentId = 3,
                            Name = "Tim Nilsson",
                            TeacherId = 3
                        },
                        new
                        {
                            StudentId = 4,
                            Name = "Sebastian Gamboa",
                            TeacherId = 4
                        },
                        new
                        {
                            StudentId = 5,
                            Name = "Theo Esberg",
                            TeacherId = 3
                        },
                        new
                        {
                            StudentId = 6,
                            Name = "Petter Nomijah",
                            TeacherId = 1
                        });
                });

            modelBuilder.Entity("Labb2_Advanced_LINQ.Models.Subject", b =>
                {
                    b.Property<int>("SubjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubjectId"));

                    b.Property<int?>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TeachersTeacherId")
                        .HasColumnType("int");

                    b.HasKey("SubjectId");

                    b.HasIndex("CourseId");

                    b.HasIndex("TeachersTeacherId");

                    b.ToTable("Subjects");

                    b.HasData(
                        new
                        {
                            SubjectId = 1,
                            Name = "Advanced.NET"
                        },
                        new
                        {
                            SubjectId = 2,
                            Name = "Frontend Webdev"
                        },
                        new
                        {
                            SubjectId = 3,
                            Name = "Database"
                        },
                        new
                        {
                            SubjectId = 4,
                            Name = "Math"
                        },
                        new
                        {
                            SubjectId = 5,
                            Name = "Programmering 1"
                        });
                });

            modelBuilder.Entity("Labb2_Advanced_LINQ.Models.Teacher", b =>
                {
                    b.Property<int>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeacherId"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeacherId");

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            TeacherId = 1,
                            Name = "Anas"
                        },
                        new
                        {
                            TeacherId = 2,
                            Name = "Reidar"
                        },
                        new
                        {
                            TeacherId = 3,
                            Name = "Tobias"
                        },
                        new
                        {
                            TeacherId = 4,
                            Name = "Kristian"
                        });
                });

            modelBuilder.Entity("StudentSubject", b =>
                {
                    b.Property<int>("StudentsStudentId")
                        .HasColumnType("int");

                    b.Property<int>("SubjectsSubjectId")
                        .HasColumnType("int");

                    b.HasKey("StudentsStudentId", "SubjectsSubjectId");

                    b.HasIndex("SubjectsSubjectId");

                    b.ToTable("StudentSubject");
                });

            modelBuilder.Entity("Labb2_Advanced_LINQ.Models.Student", b =>
                {
                    b.HasOne("Labb2_Advanced_LINQ.Models.Teacher", "Teacher")
                        .WithMany("Students")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("Labb2_Advanced_LINQ.Models.Subject", b =>
                {
                    b.HasOne("Labb2_Advanced_LINQ.Models.Course", null)
                        .WithMany("Subjects")
                        .HasForeignKey("CourseId");

                    b.HasOne("Labb2_Advanced_LINQ.Models.Teacher", "Teachers")
                        .WithMany("Subjects")
                        .HasForeignKey("TeachersTeacherId");

                    b.Navigation("Teachers");
                });

            modelBuilder.Entity("StudentSubject", b =>
                {
                    b.HasOne("Labb2_Advanced_LINQ.Models.Student", null)
                        .WithMany()
                        .HasForeignKey("StudentsStudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Labb2_Advanced_LINQ.Models.Subject", null)
                        .WithMany()
                        .HasForeignKey("SubjectsSubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Labb2_Advanced_LINQ.Models.Course", b =>
                {
                    b.Navigation("Subjects");
                });

            modelBuilder.Entity("Labb2_Advanced_LINQ.Models.Teacher", b =>
                {
                    b.Navigation("Students");

                    b.Navigation("Subjects");
                });
#pragma warning restore 612, 618
        }
    }
}
