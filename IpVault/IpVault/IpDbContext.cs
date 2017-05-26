using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using IpVault.Entities;
using System.Configuration;
using System.Collections.Specialized;

namespace IpVault
{
    public class IpDbContext : DbContext
    {
        public IpDbContext() : base(GeneratedConString())
        {
            Database.SetInitializer<IpDbContext>(null);
        }

        public virtual DbSet<IpEntity> StoredIp { get; set; }

        public List<IpEntity> GetStoredIp()
        {
            return StoredIp.Where(x => x.IpAddress != null).ToList();
        }

        protected static string GeneratedConString()
        {
            NameValueCollection appConfig = ConfigurationManager.AppSettings;

            string dbname = appConfig["DB_NAME"];
            // once connected to a different DB values below will change.
            // uncomment when connect to prod DB.
            // =========================================================
            // string username = appConfig["DB_USERNAME"];
            // string passowrd = appConfig["DB_PASSWORD"];
            // string port = appConfig["DB_PORT"];

            // string cs = 'server=' + hostname + ';user=' + username + ';database=' + dbname + ';port=' + port + ';password=' + password ';';

            // return cs;

            return dbname;
        }
    }
}