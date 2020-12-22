using DataModel1;
using DataModel2;
using Repository.Repositories;
using System;
using System.Transactions;

namespace UoW
{
    /// <summary>
    /// In this UoW class you are essentially adding another layer of security 
    /// that if any two tables are linked to each other 
    /// then if you do operations on those tables we are making sure that either the transaction is done completely
    /// or not done at all
    /// this will make sure that there is data consistency
    /// </summary>
    public class UnitOfWork : IDisposable
    {
        public DBOneEntities DB1Context;

        public tboneRepo tb1{ get; set; }
        public tbTwoRepo tb2{ get; set; }
        public UnitOfWork()
        {
            this.DB1Context = new DBOneEntities();
            tb1 = new tboneRepo(DB1Context);
            tb2 = new tbTwoRepo(DB1Context);

        }
        public int SaveChanges()
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DB1Context.SaveChanges();// here we are saving to the database
                    scope.Complete();
                }
                return 0;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Dispose()
        {
            DB1Context.Dispose();
        }
    }
}
