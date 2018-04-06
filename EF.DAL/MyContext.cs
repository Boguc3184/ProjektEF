using EF.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace EF.DAL
{
    public class MyContext: DbContext
    {
        public MyContext()
            :base("MyDB") //wroc do klasy bazowej z ktorej dziedziczymy
        {

        }

        public DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); //base. wywyolaj mi logike z klasy bazowej
            modelBuilder.Conventions.Remove(new PluralizingTableNameConvention());
        }

    }
}
