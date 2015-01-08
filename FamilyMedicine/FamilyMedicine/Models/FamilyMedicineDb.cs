using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FamilyMedicine.Models
{
    public class FamilyMedicineDb: DbContext
    {
        public FamilyMedicineDb()
            : base("DefaultConnection")
        {
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<FamilyMedicineDb>());

        }
        public DbSet<Patient> Patients { get; set; }
    }
    
}