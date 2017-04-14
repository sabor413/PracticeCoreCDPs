using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PracticeCoreCDPs.Areas.AbsFactory.Core;
using PracticeCoreCDPs.Core;

namespace PracticeCoreCDPs.Areas.AbsFactory.Controllers
{
    [Area("AbsFactory")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ExecuteQuery(string factorytype, string query)
        {
            IDatabaseFactory factory = null;

            // using .NET Reflection to grab the factory from a configuration setting
            string appfactorytype = AppSettings.FactoryType;
            ObjectHandle o = Activator.CreateInstance(Assembly.GetExecutingAssembly().FullName, appfactorytype);
            factory = (IDatabaseFactory)o.Unwrap();

            #region OLD CLIENT IF STATEMENT 
            // -- if chosen from the client interface --
            //if (factorytype == "sqlclient")
            //{
            //    factory  = new SqlClientFactory();
            //}
            //else
            //{
            //    factory = new OleDbFactory();
            //}
            #endregion

            DatabaseHelper helper = new DatabaseHelper(factory);
            query = query.ToLower();
            if (query.StartsWith("select"))
            {
                DbDataReader reader = helper.ExecuteSelect(query);
                return View("ShowTable", reader);
            }
            else
            {
                int i = helper.ExecuteAction(query);
                return View("ShowResult", i);
            }
        }
    }
}
