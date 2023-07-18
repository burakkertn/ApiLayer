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
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _CustomerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _CustomerDal = customerDal;
        }

        public void TDelete(Customer t)
        {
           _CustomerDal.Delete(t);
        }

        public Customer TGetByID(int id)
        {
          return _CustomerDal.GetByID(id);  
        }

        public List<Customer> TGetList()
        {
           return _CustomerDal.GetList();   
        }

        public void TInsert(Customer t)
        {
          _CustomerDal.Insert(t);
        }

        public void TUpdate(Customer t)
        {
            _CustomerDal.Update(t);
        }
    }
}
