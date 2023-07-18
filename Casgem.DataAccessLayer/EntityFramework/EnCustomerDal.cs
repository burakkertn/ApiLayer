using Casgem.DataAccessLayer.Abstract;
using Casgem.DataAccessLayer.Concrete;
using Casgem.DataAccessLayer.Repositories;
using Casgem.EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casgem.DataAccessLayer.EntityFramework
{
    public class EnCustomerDal : GenericRepository<Product>, IProductDal
    {
        public EnCustomerDal(Context context) : base(context)
        {

        }
    }
}
