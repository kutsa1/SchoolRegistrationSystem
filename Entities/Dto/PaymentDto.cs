using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class PaymentDto
    {
        public int Id { get; set; }
        public string StudentFirstName { get; set; }
        public string StudentLastName { get; set; }
        public string CourseName { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
        public bool iscash { get; set; }



    }
}
