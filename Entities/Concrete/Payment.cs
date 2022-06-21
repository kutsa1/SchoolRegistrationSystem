using Core.Entities;
using System;


namespace Entities.Concrete
{
    public class Payment:IEntity
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public decimal Amount { get; set; }
        public bool Status { get; set; }
        public DateTime Date { get; set; }
        public bool iscash { get; set; }

    }
}
