using Labb2_Advanced_LINQ.Data;
using Labb2_Advanced_LINQ.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_Advanced_LINQ.Controllers
{
    internal class UIControllers
    {
        public static void getMathTeacher()
        {
            using var context = new SchoolContext();

            var mathTeacher = context.Teachers.Where(t => t.Subjects.Any(s => s.Name == "Math")).ToList();

            foreach (var item in mathTeacher)
            {
                Console.WriteLine($"This teacher teaches math: {item.Name}");
            }

        }

        public static void studentsWithTeachers()
        {
            using var context = new SchoolContext();
            var studentAndTeacher = (from s in context.Students
                                     join t in context.Teachers
                                     on s.TeacherId equals t.TeacherId
                                     select new
                                     {
                                         student = s.Name,
                                         teacher = t.Name
                                     });

            foreach (var item in studentAndTeacher)
            {
                Console.WriteLine($"Student: {item.student} and teacher : {item.teacher}");
            }
        }

        public static void contiansProgram()
        {
            using var context = new SchoolContext();

            var subjectP = context.Subjects.Where(x => x.Name.Contains("Programmering 1"));

            foreach (var item in subjectP)
            {
                Console.WriteLine($"The courseplan does contain {item.Name}");
            }
        }

        public static void fromAnasToReidar()
        {
            using var context = new SchoolContext();

            var changes = context.Students.FirstOrDefault(s => s.TeacherId == 1);
            changes.TeacherId = 2;
            context.SaveChanges();

            Console.WriteLine("One students teacher has been changed from Anas to Reidar");
        }

        public static void updateSubject()
        {
            using var context = new SchoolContext();
            var change = context.Subjects.Single(x => x.Name == "Programmering 2");
            change.Name = "OOP";
            context.SaveChanges();
            Console.WriteLine("Subject name Programmering 1 has been changed to OOP");
        }

    }
}
