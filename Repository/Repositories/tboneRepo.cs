using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel1;

namespace Repository.Repositories
{
    public class tboneRepo : Repository<tbOne>
    {
        public tboneRepo(DBOneEntities e) : base(e)
        {
            
        }
    }
}
