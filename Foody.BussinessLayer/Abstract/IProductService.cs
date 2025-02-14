using Foody.EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.BussinessLayer.Abstract
{
    public interface IProductService : IGenericServices<Product>
    {
        public void TDelete(Product id)
        {
            throw new NotImplementedException();
        }

        public List<Product> TGetAll()
        {
            throw new NotImplementedException();
        }

        public Product TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TInsert(Product entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
