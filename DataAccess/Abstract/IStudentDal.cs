using Core.DataAccess;
using Entities.Concrete;
using Entities.Dto;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    public interface IStudentDal:IEntityRepository<Student>
    {
        public List<StudentDto> GetAllStudentDto();
    }
}