using DataModel1;
using DataModel2;
using Repository.Repositories;
using System;
using System.Transactions;

namespace UoW
{
    public class UnitOfWork : IDisposable
    {
        public DBOneEntities DM1Context;
        public DBTwoEntities DM2Context;

        public  tboneRepo tb1{ get; set; }
        public tbone2Repo tb2 { get; set; }
        public UnitOfWork()
        {
            this.DM1Context = new DBOneEntities();
            this.DM2Context = new DBTwoEntities();
            tb1 = new tboneRepo(DM1Context);
            tb2 = new tbone2Repo(DM2Context);
        }
        public int SaveChanges()
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DM1Context.SaveChanges();
                    DM2Context.SaveChanges();
                    scope.Complete();
                }
                return 0;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
           
        }
        public void Dispose()
        {
            DM1Context.Dispose();
            DM2Context.Dispose();
        }
    }
}
