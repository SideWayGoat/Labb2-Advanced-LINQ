using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Labb2_Advanced_LINQ.Models
{
    internal class Teacher
    {
        public int TeacherId { get; set; }
        public string Name { get; set; }


        public List<Subject> Subjects { get; set; }

        public List<Student> Students { get; set; }
    }
}
