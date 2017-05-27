using System;
using System.Diagnostics;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Http;
using MySql.Data.MySqlClient;

namespace API_Attempt
{
    public class Global : HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);


        }

        public string IsPostBack { get; set; }

        private void CheckMysqlConnection()
        {
            // Connection String
            string connectionString =
                @"Data Source=localhost; Port=53306; Database=users; User ID=root; Password=HI123";
            using (MySqlConnection cn = new MySqlConnection(connectionString))
            {
                cn.Open();
                Response.Write("MySql Connection Successful");
            }
        }
    }
}