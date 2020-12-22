using DT = DataModel1;
using DM = DomainModel;
using System.Collections.Generic;
using System;
using System.Linq;

namespace Repository.Repositories
{
    /// <summary>
    /// In repo class we define all the crud operations of the repective table
    /// Create record/Addrecord/Addrecords,
    /// Read record/Getrecord/Getrecords
    /// Delete record, 
    /// Update record
    /// </summary>
    public class tboneRepo : Repository<DT.tbOne>
    {
        public tboneRepo(DT.DBOneEntities e) : base(e)
        {

        }

        public bool AddRecord(DM.tbOne DMObj)
        {
            var DTObj = new DT.tbOne()
            {
                College = DMObj.College,
                Name = DMObj.Name
            };
            base.AddOne(DTObj);
            return true;
        }

        public List<DM.tbOne> GetTRecordsByIDs(List<int> IDs)
        {
            List<DM.tbOne> list = new List<DM.tbOne>();

            try
            {
                var tbOneRecords = base.GetTRecords();
                return tbOneRecords.Where(m => IDs.Contains(m.ID))
                     .Select(m => new DM.tbOne()
                     {
                         College = m.College,
                         Name = m.Name,
                         No = m.ID
                     }).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
