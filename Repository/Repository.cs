using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    /// <summary>
    /// This is a generic class for all the repository classes which inherits this
    /// Just to reduce the redundancy of the code and include all the common code
    /// All the repo classes can just inherit the generic interface (here it is : IEntity) 
    /// and implement it in all the repository classes
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Repository<T> : IEntity<T> where T : class
    {
        private DbContext ct;

        public Repository(DbContext ct)
        {
            this.ct = ct;
        }
        public void AddOne(T rec)
        {
            try
            {
                // note here the Set() method returns the instance of the gievn entity type
                // and upon that instance we are adding a record
                ct.Set<T>().Add(rec);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public List<T> GetTRecords()
        {
            List<T> listByIDs = new List<T>();

            try
            {
                using (ct)
                {

                    return ct.Set<T>().ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }


        }


    }
}
