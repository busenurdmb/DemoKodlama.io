using DemoKodlama.io.DataAccess.Abstract;
using DemoKodlama.io.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKodlama.io.DataAccess.Concrete
{
    public class CourseDal : ICourseDal
    {
        List<Course> course;
        public CourseDal()
        {
            Course Course = new Course();
            Course.Name = "(2023) Yazılım Geliştirici Yetiştirme Kampı - Python";
            Course.Id = 1;
            Course.InstructerID = 1;
            Instructor ınstructor = new Instructor { Id=Course.InstructerID};
            Course.Instructor = ınstructor;
            Course.Descriptiono = "Deneme";
            Course.CoursePrice = 0;
            Course.CategoryID = 1; // Örnek olarak CategoryID'yi 1 olarak ayarlıyoruz

            // CategoryID'si Course.CategoryID ile eşleşen bir Category nesnesi oluşturuluyor
            Category category = new Category { Id = Course.CategoryID };

            // Course nesnesine Category nesnesi atanıyor
            Course.Category = category;


            Course Course2 = new Course();
            Course2.Name = "Senior Yazılım Geliştirici Yetiştirme Kampı (.NET)";
            Course2.Id = 1;
            Course2.InstructerID = 1;
            Course2.Descriptiono = "Deneme";
            Course2.CoursePrice = 0;
            Course2.CategoryID = 1;


            Course Course3 = new Course();
            Course3.Name = "Yazılım Geliştirici Yetiştirme Kampı (C# + ANGULAR)";
            Course3.Id = 1;
            Course3.InstructerID = 2;
            Course3.Descriptiono = "Deneme";
            Course3.CoursePrice = 0;
            Course3.CategoryID = 1;

            course = new List<Course> { Course, Course2, Course3 };
        }
        public void Add(Course Course)
        {
            course.Add(Course);
        }

        public void Delete(Course Course)
        {
            course.Remove(Course);
        }

        public List<Course> GetAll()
        {
            return course;
        }

        public void Update(Course Course)
        {
            //var value = course.Find(c => c.Id == Course.Id);
            //value.Name = Course.Name;
            
            Console.WriteLine("Course güncellendi");

        }
    }
}
