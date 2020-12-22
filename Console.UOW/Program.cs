using System;
using System.Collections.Generic;
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
            };

            DM.tbTwo obj3 = new DM.tbTwo()
            {
                namee = "Shekhar",
                College = "Somecolleege",
                tbOne = obj1
            };

            // This object is from the Domain Model which is corresponding object for the DataModel2
            // As of now I am not using this object for demonstrating the UoW
            DM.tbone2 obj2 = new DM.tbone2()
            {
                name2 = "name2",
                college2 = "KMIT2",
            };

            // UoW is mainly used to add, Delete and Update the records in the tables which are connected
            // by a constraint

            // this  try below we are trying to add a rec
            try
            {
                using (UnitOfWork u = new UnitOfWork())
                {
                    u.tb1.AddRecord(obj1);
                    u.tb2.AddRecord(obj3);
                    u.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }

            // Get the Allrecords
            try
            {
                using (UnitOfWork u = new UnitOfWork())
                {
                    var x = u.tb1.GetTRecordsByIDs(new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
                    foreach (var item in x)
                    {
                        System.Console.WriteLine(item.No);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
