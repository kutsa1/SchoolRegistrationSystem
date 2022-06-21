using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfStudentDal : EfEntityRepositoryBase<Student, VisualProgramingProjectContext>, IStudentDal
    {
        public List<StudentDto> GetAllStudentDto()
        {
            using (VisualProgramingProjectContext context = new VisualProgramingProjectContext())
            {
                var result = from student in context.Students
                             join user in context.Users
                             on student.UserId equals user.Id
                             select new StudentDto()
                             {
                                 FirstName = user.FirstName,
                                 StudentNo = student.StudentNo,
                                 LastName = user.LastName,
                                 Address = user.Address,
                                 Birthday = user.Birthday,
                                 Email = user.Email,
                                 Gender = user.Gender,
                                 Id = user.Id,
                                 NationalityId = user.NationalityId,
                                 Phone = user.Phone
      
                                 
                             };
                return result.ToList();


            }


        }

    }
}