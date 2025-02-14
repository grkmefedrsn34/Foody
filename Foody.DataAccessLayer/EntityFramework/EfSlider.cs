using Foody.DataAccessLayer.Abstract;
using Foody.DataAccessLayer.Context;
using Foody.DataAccessLayer.Repositories;
using Foody.EntitiyLayer.Concrete;



namespace Foody.DataAccessLayer.EntityFramework
{
    public class EfSlider : GenericRepository<Slider> , ISliderDal
    {
        public EfSlider(FoodyContext context) : base(context)
        {
        }
    }
}
