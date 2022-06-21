using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Course : IEntity
    {
        public int Id { get; set; }
        public int InstructorId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Semester { get; set; }
        public string Description { get; set; }

    }
}
