using Bitspco.Framework.Net.Data;
using ERP.PMS.Common.Intefaces;
using ERP.PMS.Data.Contexts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ERP.PMS.Data
{
    public class DataAdapter : BaseDataAdapter<PMSDbContext>, IDataAdapter, IDisposable
    {
        public DataAdapter(PMSDbContext pmsDbContext) : base(pmsDbContext)
        {
        }
        public void Dispose()
        {
            MainContext?.Dispose();
        }
    }
}
