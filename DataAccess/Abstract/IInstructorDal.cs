using Core.DataAccess;
using Entities.Concrete;
using Entities.Dto;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    public interface IInstructorDal : IEntityRepository<Instructor>
    {
        public List<InstructorDto> GetAllTeacherDto();
    }
}
