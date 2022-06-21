using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto
{
    public class CourseDto
    {
        public int Id { get; set; }
        public int InstructorId { get; set; }
        public string InstructorName { get; set; }

        public string InstructorLastName { get; set; }
        public decimal Price { get; set; }
        public string Semester { get; set; }
        public string Description { get; set; }
        public string CourseName { get; set; }
    }
}
