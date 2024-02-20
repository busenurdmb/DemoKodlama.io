using DemoKodlama.io.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKodlama.io.Entities.Concrete
{
    public class Instructor:IEntity
    {
       public string Name { get; set; }

        public List<Course> Courses { get; set; }
    }
}
