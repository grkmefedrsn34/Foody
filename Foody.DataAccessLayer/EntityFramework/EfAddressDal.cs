using Foody.DataAccessLayer.Abstract;
using Foody.DataAccessLayer.Context;
using Foody.DataAccessLayer.Repositories;
using Foody.EntitiyLayer.Concrete;


namespace Foody.DataAccessLayer.EntityFramework
{
    class EfAddressDal:GenericRepository<Address>, IAddressDal
    {
        public EfAddressDal(FoodyContext context) : base(context)
        {

        }
    }
}
