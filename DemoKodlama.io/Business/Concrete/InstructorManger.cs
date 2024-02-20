using DemoKodlama.io.Business.Abstract;
using DemoKodlama.io.DataAccess.Abstract;
using DemoKodlama.io.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKodlama.io.Business.Concrete
{
    public class InstructorManger:IInstructorManager
    {
        private readonly IInstructorDal _InstructorDal;

        public InstructorManger(IInstructorDal InstructorDal)
        {
            _InstructorDal = InstructorDal;
        }

        public List<Instructor> GetAll()
        {

            return _InstructorDal.GetAll();
        }
        public void Add(Instructor Instructor)
        {
            _InstructorDal.Add(Instructor);
        }
        public void Delete(Instructor Instructor)
        {
            _InstructorDal.Delete(Instructor);
        }

        public void Update(Instructor Instructor)
        {
            _InstructorDal.Update(Instructor);
        }
    }
}
