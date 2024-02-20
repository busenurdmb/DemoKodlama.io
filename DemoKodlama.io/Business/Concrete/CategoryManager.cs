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
    public class CategoryManager:ICategoryManager
    {
        private readonly ICategoryDal _CategoryDal;

        public CategoryManager(ICategoryDal CategoryDal)
        {
            _CategoryDal = CategoryDal;
        }

        public List<Category> GetAll()
        {

            return _CategoryDal.GetAll();
        }
        public void Add(Category Category)
        {
            _CategoryDal.Add(Category);
        }
        public void Delete(Category Category)
        {
            _CategoryDal.Delete(Category);
        }
        public void Update(Category Category)
        {
            _CategoryDal.Update(Category);
        }
    }
}
