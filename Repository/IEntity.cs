using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    interface IEntity<T>
    {
        void AddOne(T entity);
    }
}
