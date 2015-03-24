using GesturePhysioWebClient.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesturePhysioWebClient.DAL
{
    class PatientContext : DbContext
    {

        public PatientContext() : base("PatientContext")
        {

        }
        
        public DbSet<Item> Items { get; set; }
       

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }



    }
}
