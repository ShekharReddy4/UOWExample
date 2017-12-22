using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class Repository<T> : IEntity<T> where T : class
    {
        private DbContext ct;

        public Repository(DbContext ct)
        {
            this.ct = ct;
        }
        public void AddOne(T rec)
        {
            ct.Set<T>().Add(rec);
        }
    }
}
