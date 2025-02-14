using Foody.EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.BussinessLayer.Abstract
{
    public interface IFeatureService : IGenericServices<Feature>
    {
        public void TDelete(Feature id)
        {
            throw new NotImplementedException();
        }

        public List<Feature> TGetAll()
        {
            throw new NotImplementedException();
        }

        public Feature TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TInsert(Feature entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Feature entity)
        {
            throw new NotImplementedException();
        }
    }
}
