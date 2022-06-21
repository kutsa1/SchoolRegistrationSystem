using Core.Entities;

namespace Entities.Concrete
{
    public class Instructor : IEntity
    {
        public int Id { get; set; }
        public decimal Salary { get; set; }
        public string Title { get; set; }
        public int UserId { get; set; }
    }
}
