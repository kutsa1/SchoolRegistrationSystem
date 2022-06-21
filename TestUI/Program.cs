using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace TestUI
{
    internal class Program
    {
        public static object EfUserDal { get; private set; }

        static void Main(string[] args)
        {
            User user = new User();
            user.Gender = true;
            user.Address = "Kfdhg";
            user.Birthday = DateTime.Now;
            user.Phone = "05340393985";
            user.Email = "kufutsal@gmail.com";
            user.FirstName = "KUFUTSAL";
            user.LastName = "GÜFÜRLEK";
            user.NationalityId = "49009905734";
            EfUserDal userDal = new EfUserDal();
            userDal.Add(user);
            var EntityUser = userDal.Get(u => u.NationalityId == user.NationalityId);

            Student student = new Student();
            student.StudentNo = "123456978";
            student.UserId = EntityUser.Id;
            new EfStudentDal().Add(student);

        }

    }

}
