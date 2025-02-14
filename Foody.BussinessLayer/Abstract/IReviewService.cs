using Foody.EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.BussinessLayer.Abstract
{
    public interface IReviewService : IGenericServices<Review>
    {
        public void TDelete(Review id)
        {
            throw new NotImplementedException();
        }

        public List<Review> TGetAll()
        {
            throw new NotImplementedException();
        }

        public Review TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TInsert(Review entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Review entity)
        {
            throw new NotImplementedException();
        }
    }
}
