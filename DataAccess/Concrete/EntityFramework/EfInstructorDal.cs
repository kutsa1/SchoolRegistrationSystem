using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfInstructorDal : EfEntityRepositoryBase<Instructor, VisualProgramingProjectContext>, IInstructorDal
    {
        public List<InstructorDto> GetAllTeacherDto()
        {
            using (VisualProgramingProjectContext context = new VisualProgramingProjectContext())
            {
                var result = from instructor in context.Instructors
                             join user in context.Users
                             on instructor.UserId equals user.Id
                             select new InstructorDto()
                             {
                                 Name = user.FirstName,
                                 LastName = user.LastName,
                                 Address = user.Address,
                                 Birthday = user.Birthday,
                                 Salary = instructor.Salary,
                                 Title = instructor.Title,
                                 Email = user.Email,
                                 Gender = user.Gender,
                                 Id = user.Id,
                                 NationalityId = user.NationalityId,
                                 PhoneNumber = user.Phone


                             };
                return result.ToList();


            }
        }
    }
}
