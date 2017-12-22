using DataModel1;
using DataModel2;
using System;
using UoW;
using DM = DomainModel;

namespace Console.UOW
{
    class Program
    {
        static void Main(string[] args)
        {

            DM.tbOne obj1 = new DM.tbOne()
            {
                Name = "name1",
                College = "KMIT",
                No = 12
            };

            DM.tbone2 obj2 = new DM.tbone2()
            {
                name2 = "name2",
                college2 = "KMIT2",
                no2 = 23
            };

            using (UnitOfWork u = new UnitOfWork())
            {
                u.tb1.AddOne(new DataModel1.tbOne()
                {
                    No = obj1.No,
                    Name = obj1.Name,
                    College = obj1.College
                });

                u.tb2.AddOne(new DataModel2.tbone()
                {
                    no2 = obj2.no2,
                    name2 = obj2.name2,
                    college2 = obj2.college2
                });

                u.SaveChanges();

            }

            //using ( var x = new DBOneEntities())
            //{
            //    x.tbOnes.Add(new DataModel1.tbOne()
            //    {
            //        No = obj1.No,
            //        Name = obj1.Name,
            //        College = obj1.College
            //    });

            //    x.SaveChanges();
            //}

            //using (var x = new DBTwoEntities())
            //{
            //    x.tbones.Add(new DataModel2.tbone()
            //    {
            //        no2 = obj2.no2,
            //        name2 = obj2.name2,
            //        college2 = obj2.college2
            //    });

            //    x.SaveChanges();
            //}






        }
    }
}
