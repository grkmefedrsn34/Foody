using Foody.DataAccessLayer.Abstract;
using Foody.DataAccessLayer.Context;
using Foody.DataAccessLayer.Repositories;
using Foody.EntitiyLayer.Concrete;

namespace Foody.DataAccessLayer.EntityFramework
{
    class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        public EfCategoryDal(FoodyContext context) : base(context)
        {
        }
    }
}
