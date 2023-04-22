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
                Console.WriteLine(item.Name);
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
                Console.WriteLine(item.student);
                Console.WriteLine(item.teacher);
            }
        }

    }
}
