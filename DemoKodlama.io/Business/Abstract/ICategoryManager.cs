using DemoKodlama.io.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKodlama.io.Business.Abstract
{
    public interface ICategoryManager
    {

        public List<Category> GetAll();
        public void Add(Category Category);
        public void Delete(Category Category);
        public void Update(Category Category);
    }
}
