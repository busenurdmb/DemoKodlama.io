// See https://aka.ms/new-console-template for more information
using DemoKodlama.io.Business.Concrete;
using DemoKodlama.io.DataAccess.Concrete;
using DemoKodlama.io.Entities.Concrete;

//Console.WriteLine("Hello, World!");

CategoryManager ca = new(new CategoryDal());
List<Category> category = ca.GetAll();
CourseManager c = new(new CourseDal());


List<Course> courses = c.GetAll();

foreach (Category categorys in category)
{

    Console.WriteLine($"Category Id: {categorys.Id}, Name: {categorys.Name}");
}

//var delet=c.GetAll().FirstOrDefault
//    ();
//c.Delete(delet);
// c.Add(new Course() { Id = 4, Name = "deneme",InstructerID=1 });


foreach (Course course in courses)
{
    
    Console.WriteLine($"Course: {course.Name}");
}
