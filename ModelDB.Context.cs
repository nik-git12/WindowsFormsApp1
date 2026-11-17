using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace WindowsFormsApp1
{
    public partial class NikitaDBEntities : DbContext
    {
        private static NikitaDBEntities context;

        public static NikitaDBEntities GetContext()
        {
            if (context == null)
                context = new NikitaDBEntities();
            return context;
        }

        public NikitaDBEntities()
            : base("name=NikitaDBEntities")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
