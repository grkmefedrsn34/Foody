using Foody.DataAccessLayer.Abstract;
using Foody.DataAccessLayer.Context;
using Foody.DataAccessLayer.Repositories;
using Foody.EntitiyLayer.Concrete;

namespace Foody.DataAccessLayer.EntityFramework
{
    public class EfSocialMedai :GenericRepository<SocialMedai> , ISocaialMediaDal
    {
        public EfSocialMedai(FoodyContext context) : base(context)
        {
        }
    }
}
