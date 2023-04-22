using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_Advanced_LINQ.Models
{
    internal class Subject
    {
        public int SubjectId { get; set; }
        public string Name { get; set; }

        public Teacher Teachers { get; set; }
        public List<Student> Students { get; set; }
    }
}
