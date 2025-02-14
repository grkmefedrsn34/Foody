using Foody.BussinessLayer.Abstract;
using Foody.DataAccessLayer.Abstract;
using Foody.EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.BussinessLayer.Concrete
{
    public class AboutManger : IAboutService
    {
        private readonly IAboutDal _aboutDal;
        public AboutManger(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }
        public void TDelete(About id)
        {
            
            _aboutDal.Delete(id);
        }

        public List<About> TGetAll()
        {
            return _aboutDal.GetAll();
        }

        public About TGetById(int id)
        {
            return _aboutDal.GetById(id);
        }

        public void TInsert(About entity)
        {
            _aboutDal.Insert(entity);
        }

        public void TUpdate(About entity)
        {
            _aboutDal.Update(entity);
        }
    }
}
