using DemoKodlama.io.Business.Abstract;
using DemoKodlama.io.DataAccess.Abstract;
using DemoKodlama.io.DataAccess.Concrete;
using DemoKodlama.io.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKodlama.io.Business.Concrete
{
    public class CourseManager:ICourseManager
    {
        private readonly ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public List<Course> GetAll()
        {
           
            return _courseDal.GetAll();
        }
        public void Add(Course course)
        {
            _courseDal.Add(course);
        }
        public void Delete(Course course)
        {
            _courseDal.Delete(course);
        }

        public void Update(Course Course)
        {
            _courseDal.Update(Course);
        }
    }
}
