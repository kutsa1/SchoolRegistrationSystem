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
    public class EfCourseDal : EfEntityRepositoryBase<Course, VisualProgramingProjectContext>, ICourseDal
    {
       public List<CourseDto> getAllCourseDto()
        {
            using (VisualProgramingProjectContext context = new VisualProgramingProjectContext())
            {
                var result = from course in context.Courses
                             join ins in context.Users
                             on course.InstructorId equals ins.Id
                             select new CourseDto()
                             {
                                 Id = course.Id,
                                 InstructorId = ins.Id,
                                 Description = course.Description,
                                 Semester = course.Semester,
                                 InstructorName = ins.FirstName,
                                 InstructorLastName = ins.LastName,
                                 Price = course.Price,
                                 CourseName = course.Name,
                                 
                             };
                return result.ToList();
            }
        }
    }
}
