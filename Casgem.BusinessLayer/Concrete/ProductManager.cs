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
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void TDelete(Product t)
        {
           _productDal.Delete(t);
        }

        public Product TGetByID(int id)
        {
         return _productDal.GetByID(id);
        }

        public List<Product> TGetList()
        {
          return _productDal.GetList();
        }

        public void TInsert(Product t)
        {
           _productDal.Insert(t);
        }

        public void TUpdate(Product t)
        {
           _productDal.Update(t);
        }
    }
}
