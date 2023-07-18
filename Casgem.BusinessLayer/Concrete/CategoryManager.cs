using Casgem.BusinessLayer.Abstract;
using Casgem.DataAccessLayer.Abstract;
using Casgem.EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casgem.BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _CategoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _CategoryDal = categoryDal;
        }

        public void TDelete(Category t)
        {
         _CategoryDal.Delete(t);
        }

        public Category TGetByID(int id)
        {
           return _CategoryDal.GetByID(id); 
        }

        public List<Category> TGetList()
        {
          return _CategoryDal.GetList();
        }

        public void TInsert(Category t)
        {
            _CategoryDal.Insert(t);
        }

        public void TUpdate(Category t)
        {
           _CategoryDal.Update(t);
        }
    }
}
