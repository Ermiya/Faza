using ERP.Accounting.Common.Entities;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Accounting.Data.Contexts
{
    public class AccountingDbContext : DbContext
    {
        public virtual DbSet<Menu> Menu { get; set; }
        //public AccountingDbContext() : base("name=Default") { }
        public AccountingDbContext() : base("data source=(localdb)\\MSSQLLocalDB;initial catalog=AccountingDb;integrated security=SSPI;MultipleActiveResultSets=True;App=EntityFramework") { }
        public AccountingDbContext(string connectionString) : base(DbProviderFactories.GetFactory("System.Data.SqlClient").CreateConnection(), true)
        {
            Database.Connection.ConnectionString = connectionString;
            Configuration.ProxyCreationEnabled = true;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);
        }
    }
}
