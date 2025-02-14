using Foody.EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.BussinessLayer.Abstract
{
    public interface IAddressService : IGenericServices<Address>
    {
        public void TDelete(Address id)
        {
            throw new NotImplementedException();
        }

        public List<Address> TGetAll()
        {
            throw new NotImplementedException();
        }

        public Address TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TInsert(Address entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Address entity)
        {
            throw new NotImplementedException();
        }
    }
}
