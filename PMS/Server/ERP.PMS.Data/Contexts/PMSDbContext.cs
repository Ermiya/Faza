using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bitspco.Framework.Domain.Entities;
using ERP.PMS.Common.Entities;

namespace ERP.PMS.Data.Contexts
{
    public class PMSDbContext : DbContext
    {
        public PMSDbContext() : base("data source=(localdb)\\MSSQLLocalDB;initial catalog=PMS;integrated security=SSPI;MultipleActiveResultSets=True;App=EntityFramework") { }

        public DbSet<Job> Jobs { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Dependant> Dependants { get; set; }
        public DbSet<JobApplicant> Applicants { get; set; }
        public DbSet<Personnel> Staffs { get; set; }
        public DbSet<PersonnelStatus> Statuses { get; set; }
        public DbSet<SalaryContract> SalaryContracts { get; set; }
        public DbSet<SalaryContractItem> ContractItems { get; set; }
        public DbSet<SalaryDescription> Descriptions { get; set; }
        public DbSet<TimePerformance> Performances { get; set; }
        public DbSet<TimePerformanceItem> ContractsItems { get; set; }
        public DbSet<WorkExperience> Experiences { get; set; }

        public PMSDbContext(string connectionString) : base(DbProviderFactories.GetFactory("System.Data.SqlClient").CreateConnection(), true)
        {
            Database.Connection.ConnectionString = connectionString;
            Configuration.ProxyCreationEnabled = true;
        }

        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.AddFromAssembly(typeof(Entity).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
