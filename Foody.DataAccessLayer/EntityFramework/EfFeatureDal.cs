using Foody.DataAccessLayer.Abstract;
using Foody.DataAccessLayer.Context;
using Foody.DataAccessLayer.Repositories;
using Foody.EntitiyLayer.Concrete;

namespace Foody.DataAccessLayer.EntityFramework
{
    class EfFeatureDal: GenericRepository<Feature>, IFeatureDal
    {
        public EfFeatureDal(FoodyContext context) : base(context)
        {
        }
    }
}
