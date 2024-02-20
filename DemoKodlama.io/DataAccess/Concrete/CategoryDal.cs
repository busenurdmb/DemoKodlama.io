using DemoKodlama.io.DataAccess.Abstract;
using DemoKodlama.io.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKodlama.io.DataAccess.Concrete
{
    public class CategoryDal : ICategoryDal
    {
        List<Category> categories;
        public CategoryDal()
        {
            Category category=new Category();
            category.Name = "C#";
            category.Id = 1;


            Category category2 = new Category();
            category2.Name = "java";
            category2.Id = 2;

            Category category3 = new Category();
            category3.Name = "python";
            category3.Id = 3;

            categories=new List<Category> { category, category2,category3 };
        }
        public void Add(Category category)
        {
            categories.Add(category);
        }

        public void Delete(Category category)
        {
            categories.Remove(category);
        }

        public List<Category> GetAll()
        {
            return categories;
        }

        public void Update(Category category)
        {
            var value = categories.Find(c=>c.Id==category.Id);
            value.Name= category.Name;
            value.Courses= category.Courses;
            Console.WriteLine("category güncellendi");
            
        }
    }
}
