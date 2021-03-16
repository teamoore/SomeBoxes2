using SomeBoxes.Model;
using System.Data.Entity;

namespace SomeBoxes.Data
{
    public class BoxDBContext : DbContext
    {
        static BoxDBContext()
        {
            Database.SetInitializer<BoxDBContext>(null);
        }

        public BoxDBContext() : base("Name=BoxDbDatabaseConnection")
        {

        }

        public DbSet<Box> Box { get; set; }
        public DbSet<BoxReady> BoxReady { get; set; }

    }
}
