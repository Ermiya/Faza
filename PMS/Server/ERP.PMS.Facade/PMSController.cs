using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bitspco.Framework.Filters;
using Bitspco.Framework.Filters.Log;
using Bitspco.Framework.Filters.Security;
using Bitspco.Framework.Filters.Security.AntiDos;
using Bitspco.Framework.Filters.Security.Authenticate;
using Bitspco.Framework.Filters.Security.IP;
using Bitspco.Framework.Filters.Security.Models;
using Bitspco.Framework.Net.Filters.Security;
using ERP.PMS.Business;
using ERP.PMS.Data;
using ERP.PMS.Data.Contexts;
using ERP.PMS.Facade.Filters;

namespace ERP.PMS.Facade
{
    public partial class PMSController
    {
        private DataAdapter adapter;
        private PMSBusiness business;


        private Authenticator auth;
        private AuthFilter authFilter = new AuthFilter();
        private LogFilter logFilter = new LogFilter(new Logger());
        private SecurityFilter securityFilter = new SecurityFilter();
        private AntiDosFilter antiDosFilter = new AntiDosFilter();
        private IPFilter ipFilter = new IPFilter();
        private FilterCollection<IFilter> filters = new FilterCollection<IFilter>();

//        private string ConnectionString => "Data Source=.;Initial Catalog=PMS;User Id=behzad_chizari;Password=123qwe$%^RTY;";
        //private string ConnectionString => "data source=.;initial catalog=PMS;persist security info=True;user id=sa;password=*UHBnji9)OKM;MultipleActiveResultSets=True;App=EntityFramework";
        private string ConnectionString => "data source=(localdb)\\MSSQLLocalDB;initial catalog=PMS;Integrated Security=SSPI;MultipleActiveResultSets=True;App=EntityFramework";
        //private const string ORGCHART_CONNECTIONSTRING = "data source=(localdb)\\MSSQLLocalDB;initial catalog=TestDb;Integrated Security=SSPI;MultipleActiveResultSets=True;App=EntityFramework";

        private PMSBusiness Business
        {
            get
            {
                if (business == null)
                {
                    business = new PMSBusiness(adapter);
                }

                return business;
            }
        }

        public PMSController()
        {
            securityFilter.Filters.Add(authFilter);
            //filters.Add(authFilter);
            filters.Add(logFilter);

            antiDosFilter.AttributeEnable = true;
            securityFilter.Filters.Add(antiDosFilter);
            securityFilter.Filters.Add(ipFilter);

            filters.Add(securityFilter);

            adapter = new DataAdapter(new PMSDbContext(ConnectionString));
        }

        public void RegisterSecurity(HttpRequest request)
        {
            securityFilter.ClientInfo = new ClientInfo().GetClientInfo(request, "");
        }

        public void RegisterAuthenticator(string token)
        {
            auth = new Authenticator() {Token = token};
            authFilter.SetAuthenticator(auth);
        }

        private T Run<T>(Func<T> func, bool saveChanges = false, object[] arguments = null)
        {
            filters.BeginExecute(frameBack: 2, arguments: arguments);
            try
            {
                return func();
            }
            finally
            {
                filters.EndExecute();
                if (saveChanges) Business.SaveChanges();
            }
        }

        //------------------------------ CRUD ------------------------------

        #region CRUD

        public IQueryable<T> Set<T>() where T : class => Business.Set<T>();
        public T GetById<T>(object id) where T : class => adapter.GetById<T>(id);
        public List<T> GetAll<T>() where T : class => adapter.GetAll<T>();
        public int Count<T>() where T : class => adapter.Count<T>();

        public T Add<T>(T entity) where T : class
        {
            try
            {
                return adapter.Insert(entity);
            }
            finally
            {
                adapter.SaveChanges();
            }
        }

        public T Change<T>(T entity) where T : class
        {
            try
            {
                return adapter.Update(entity);
            }
            finally
            {
                adapter.SaveChanges();
            }
        }

        public T Remove<T>(T entity) where T : class
        {
            try
            {
                return adapter.Delete(entity);
            }
            finally
            {
                adapter.SaveChanges();
            }
        }

        public T Remove<T>(object id) where T : class
        {
            try
            {
                return adapter.Delete(GetById<T>(id));
            }
            finally
            {
                adapter.SaveChanges();
            }
        }

        #endregion

//        [Auth("p:GetAllWorkExperience"), Log]
//        public List<WorkExperienceGetDto> GetAllWorkExperience()
//        {
//            return Mapper.Map<WorkExperienceGetDto>(GetAll<WorkExperience>());
//        }
    }
}