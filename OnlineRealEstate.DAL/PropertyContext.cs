using OnlineRealEstate.Entity;
using System.Data.Entity;

namespace OnlineRealEstate.DAL
{
    class PropertyContext:DbContext
    {
        public PropertyContext() : base("RealEstate")
        {

        }
        public DbSet<User> User { get; set; }

        public DbSet<Property> Property { get; set; }

    }
}
