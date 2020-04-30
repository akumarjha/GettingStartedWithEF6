using NinjaDomain.Classes;
using System;
using NinjaDomain.DataModel;
using System.Collections;
using System.Collections.Generic;

namespace EF6ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            InsertNinja();
            Console.ReadLine();
        }
        private static void InsertNinja()
        {
            var ninja1 = new Ninja
            {
                Name = "Ashutosh1",
                ServedInOniwaban = false,
                DateOfBirth = new DateTime(1992, 09, 24),
                ClanId =1
            };
            var ninja2 = new Ninja
            {
                Name = "Ashish",
                ServedInOniwaban = false,
                DateOfBirth = new DateTime(1992, 09, 24),
                ClanId = 1
            };
            var ninja3 = new Ninja
            {
                Name = "Rohit",
                ServedInOniwaban = false,
                DateOfBirth = new DateTime(1992, 09, 24),
                ClanId = 1
            };
            using (var context = new NinjaContext())
            {
                context.Database.Log = Console.WriteLine;
                context.Ninjas.AddRange(new List<Ninja> {ninja1,ninja2,ninja3 });
                context.SaveChanges();
            }
        }
    }
}
