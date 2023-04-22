using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Labb2_Advanced_LINQ.Models
{
    internal class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }

        public List<Subject> Subjects { get; set; }
    }
}
