using DemoKodlama.io.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKodlama.io.DataAccess.Abstract
{
    public interface IInstructorDal
    {
        public List<Instructor> GetAll();
        public void Add(Instructor Instructor);
        public void Update(Instructor Instructor);
        public void Delete(Instructor Instructor);
    }
}
