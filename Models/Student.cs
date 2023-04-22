using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_Advanced_LINQ.Models
{
    internal class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public List<Subject> Subjects { get; set; }
    }
}
