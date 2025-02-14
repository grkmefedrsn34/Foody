using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.BussinessLayer.Abstract
{
    public interface IGenericServices <T> where T : class
    {
        void TInsert(T entity);
        void TUpdate(T entity);
        void TDelete(T id);
        List<T> TGetAll();
        T TGetById(int id);
    }
}
