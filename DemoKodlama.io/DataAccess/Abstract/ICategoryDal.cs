using DemoKodlama.io.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKodlama.io.DataAccess.Abstract
{
    public interface ICategoryDal
    {
        public List<Category> GetAll();
        public void Add(Category category);
        public void Update(Category category);
        public void Delete(Category category);
    }
}
