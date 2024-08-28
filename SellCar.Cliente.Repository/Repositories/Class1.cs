using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellCar.Cliente.Repository.Repositories
{
    interface IBaseRepository<T>
    {
        List<T> Get(T filter);
        T Update(T entity);
        T Delete (int id);
        T GetById(int id);
        T Create (T entity);

    }
}
