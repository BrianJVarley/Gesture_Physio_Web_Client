using GesturePhysioWebClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesturePhysioWebClient.DAL
{
    class ItemInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<PatientContext>
    {

        protected override void Seed(PatientContext context)
        {
            var items = new List<Item>
            {
            new Item{User="Carson", Gender="Male", Exercise="Aduction Flexion",Date=DateTime.Now.ToString(), Painful_Arc_Start = "90.00", Painful_Arc_End = "120", Max_Range = "162.00"},
            new Item{User="Niall", Gender="Male", Exercise="Aduction Flexion",Date=DateTime.Now.ToString(), Painful_Arc_Start = "90.00", Painful_Arc_End = "120", Max_Range = "162.00"},
            new Item{User="Sarah", Gender="Female", Exercise="Aduction Flexion",Date=DateTime.Now.ToString(), Painful_Arc_Start = "90.00", Painful_Arc_End = "120", Max_Range = "162.00"},
            new Item{User="Amy", Gender="Female", Exercise="Aduction Flexion",Date=DateTime.Now.ToString(), Painful_Arc_Start = "90.00", Painful_Arc_End = "120", Max_Range = "162.00"},

            };

            items.ForEach(s => context.Items.Add(s));
            context.SaveChanges();
           
        }


    }
}
