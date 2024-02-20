using DemoKodlama.io.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKodlama.io.Entities.Concrete
{
    public class Course:IEntity
    {
        public string Name { get; set; }
        public string CoverImage { get; set; }
        public string Descriptiono { get; set; }
        public int CoursePrice { get; set; }
        public int InstructerID { get; set; }   
        public Instructor Instructor { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }


    }
}
