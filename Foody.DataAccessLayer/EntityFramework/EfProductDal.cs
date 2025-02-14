using Foody.DataAccessLayer.Abstract;
using Foody.DataAccessLayer.Context;
using Foody.DataAccessLayer.Repositories;
using Foody.EntitiyLayer.Concrete;


namespace Foody.DataAccessLayer.EntityFramework
{
    public class EfProductDal: GenericRepository<Product>, IProduct
    {
        public EfProductDal(FoodyContext context) : base(context)
        {
        }
    }
}
