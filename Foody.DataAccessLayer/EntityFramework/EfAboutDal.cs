using Foody.DataAccessLayer.Abstract;
using Foody.DataAccessLayer.Context;
using Foody.DataAccessLayer.Repositories;
using Foody.EntitiyLayer.Concrete;

namespace Foody.DataAccessLayer.EntityFramework
{
    class EfAboutDal : GenericRepository<About>,IAboutDal
    {
        public EfAboutDal(FoodyContext context) : base(context)
        {

        }
    }
}
