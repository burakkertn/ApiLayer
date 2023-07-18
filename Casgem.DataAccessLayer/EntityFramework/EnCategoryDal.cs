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
    public class EnCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        public EnCategoryDal(Context context) : base(context)
        {

        }
    }
}
