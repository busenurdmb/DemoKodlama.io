using DemoKodlama.io.DataAccess.Abstract;
using DemoKodlama.io.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKodlama.io.DataAccess.Concrete
{
    public class InstructorDal : IInstructorDal
    {
        List<Instructor> Instructors;
        public InstructorDal()
        {
            Instructor Instructor = new Instructor();
            Instructor.Name = "Engin Demiroğ";
            Instructor.Id = 1;
          


            Instructor Instructor2 = new Instructor();
            Instructor2.Name = "Halit Enes Kalaycı";
            Instructor2.Id = 2;
           

            

           Instructors = new List<Instructor> { Instructor, Instructor2 };
        }
        public void Add(Instructor Instructor)
        {
            Instructors.Add(Instructor);
        }

        public void Delete(Instructor Instructor)
        {
            Instructors.Remove(Instructor);
        }

        public List<Instructor> GetAll()
        {
            return Instructors;
        }

        public void Update(Instructor Instructor)
        {
            //var value = Instructor.Find(c => c.Id == Instructor.Id);
            //value.Name = Instructor.Name;

            Console.WriteLine("Instructor güncellendi");

        }
    }
}
