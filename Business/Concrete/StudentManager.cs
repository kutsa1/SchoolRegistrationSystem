using System.Collections.Generic;
using Business.Abstract;
using Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace Business.Concrete
{
    public class StudentManager : IStudentService
    {
        private IStudentDal _StudentDal;

        public StudentManager()
        {
            _StudentDal = new EfStudentDal();
        }

        public DataResult<List<Student>> GetAll()
        {
            return new SuccessDataResult<List<Student>>(_StudentDal.GetAll());
        }

        public DataResult<Student> GetById(int id)
        {
            return new SuccessDataResult<Student>(_StudentDal.Get(s => s.UserId == id));
        }

        public Result Add(Student entity)
        {
          _StudentDal.Add(entity);
          
          return new SuccessResult($"{entity.StudentNo}  added to database");
        }

        public Result Delete(Student entity)
        {
            _StudentDal.Delete(entity);
          
            return new SuccessResult($"{entity.StudentNo}  deleted from database");
        }

        public Result Update(Student entity)
        {
            _StudentDal.Update(entity);
          
            return new SuccessResult($"{entity.StudentNo}  updated");
        }
    }
}