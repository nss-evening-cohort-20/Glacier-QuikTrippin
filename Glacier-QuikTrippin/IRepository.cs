using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glacier_QuikTrippin
{
    public interface IRepository<T>
    {
        T Get(int id);
        IList<T> GetAll();
        void Add(T item);
        void Update(T item);
        void Delete(T item);

    }
}
