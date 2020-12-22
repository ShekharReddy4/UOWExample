using DT = DataModel1;
using DM = DomainModel;

namespace Repository.Repositories
{
    /// <summary>
    /// In repo class we define all the crud operations of the repective table
    /// Create record/Addrecord/Addrecords,
    /// Read record/Getrecord/Getrecords
    /// Delete record, 
    /// Update record
    /// </summary>
    public class tbTwoRepo : Repository<DT.tbTwo>
    {
        public tbTwoRepo(DT.DBOneEntities e) : base(e)
        {

        }

        public bool AddRecord(DM.tbTwo DMObj)
        {
            var DTObj = new DT.tbTwo()
            {
                namee = DMObj.namee,
                College = DMObj.College
            };
            base.AddOne(DTObj);
            return true;
        }
    }
}
