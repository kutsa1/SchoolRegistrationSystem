﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto
{
    public class InstructorDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string NationalityId { get; set; }
        public decimal  Salary { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address  { get; set; }
        public DateTime Birthday { get; set; }
        public bool Gender { get; set; }

    }
}
