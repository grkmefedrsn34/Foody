using Foody.DataAccessLayer.Abstract;
using Foody.DataAccessLayer.Context;
using Foody.DataAccessLayer.Repositories;
using Foody.EntitiyLayer.Concrete;

namespace Foody.DataAccessLayer.EntityFramework
{
    public class EfReviewDal : GenericRepository<Review>, IReviewDal
    {
        public EfReviewDal(FoodyContext context) : base(context)
        {
        }
    }
}
