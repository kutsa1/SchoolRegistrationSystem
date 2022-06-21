using Core.Entities;

namespace Entities.Concrete
{

    public class Student : IEntity
    {


        public int Id { get; set; }
        public int UserId { get; set; }
        public string StudentNo { get; set; }
      
    }
}