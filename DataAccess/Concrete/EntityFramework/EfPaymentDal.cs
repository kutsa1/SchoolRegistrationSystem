using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfPaymentDal : EfEntityRepositoryBase<Payment, VisualProgramingProjectContext>, IPaymentDal
    {
        public List<PaymentDto> GetAllPaymentDto()
        {
            using (VisualProgramingProjectContext context = new VisualProgramingProjectContext())
            {


                var result = from payment in context.Payments
                             join user in context.Users on payment.StudentId equals user.Id
                             join course in context.Courses on payment.CourseId equals course.Id
                             select new PaymentDto
                             {
                                 Id = payment.Id,
                                 CourseName = course.Name,
                                 StudentFirstName = user.FirstName,
                                 StudentLastName = user.LastName,
                                 Amount = payment.Amount,
                                 Date = payment.Date,
                                 Status = payment.Status,
                                 iscash= payment.iscash,                               
                             };

                return result.ToList();



            }
        }
    }
}
