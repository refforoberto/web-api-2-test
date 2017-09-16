using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace rest_api.Models
{
    public class apiContext: DbContext
    {
        public apiContext() : base("DefaultConnection")
        {
            Database.SetInitializer<apiContext>(new DropCreateDatabaseIfModelChanges<apiContext>());
        }

        public virtual DbSet<Usuario> Usuario { get; set; }
      


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}