using DataModel1;
using DataModel2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class tbone2Repo : Repository<tbone>
    {
        public tbone2Repo(DBTwoEntities e):base(e)
        {

        }

    }

}
