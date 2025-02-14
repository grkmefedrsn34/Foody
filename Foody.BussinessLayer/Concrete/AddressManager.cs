using Foody.DataAccessLayer.Abstract;
using Foody.EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.BussinessLayer.Concrete
{
    public class AddressManager : IAddressDal
    {
        private readonly IAddressDal _addressDal;
        public AddressManager(IAddressDal addressDal)
        {
            _addressDal = addressDal;
        } 
        public void Delete(int id)
        {
            _addressDal.Delete(id);
        }

        public List<Address> GetAll()
        {
            return _addressDal.GetAll();
        }

        public Address GetById(int id)
        {
            return _addressDal.GetById(id);
        }

        public void Insert(Address entity)
        {
            _addressDal.Insert(entity);
        }

        public void Update(Address entity)
        {
           _addressDal.Update(entity);
        }
    }
}
