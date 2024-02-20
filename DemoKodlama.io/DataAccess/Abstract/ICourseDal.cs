using DemoKodlama.io.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKodlama.io.DataAccess.Abstract
{
    public interface ICourseDal
    {
        public List<Course> GetAll();
        public void Add(Course Course);
        public void Update(Course Course);
        public void Delete(Course Course);
    }
}
