using VRCPS.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace VRCPS.Context
{
    public class PersistenceSystemContext : DbContext
    {
        public PersistenceSystemContext ():base("PersistenceSystemContext")
        {

        }

        public DbSet<BasicDataSet> BasicDataSets { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}