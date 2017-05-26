using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Data.Common;

namespace IpVault.Helpers
{
    public class DataLibrary : DbContext
    {
        public DataLibrary() : base("VaultConnection")
        {
            ((IObjectContextAdapter)this).ObjectContext.CommandTimeout = 300;
        }

        public string IpPost(string IpProvider, string IpAddress, string AttachedSite)
        {
            if (Database.Connection.State == System.Data.ConnectionState.Closed) this.Database.Connection.Open();

            DbCommand cmd = Database.Connection.CreateCommand();
            cmd.CommandText = "Ip_Info_Insert";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@IpProvider", IpProvider));
            cmd.Parameters.Add(new SqlParameter("@IpAddress", IpAddress));
            cmd.Parameters.Add(new SqlParameter("@AttachedSite", AttachedSite));

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Dispose();
                this.Database.Connection.Close();
            }
            return true.ToString();
        }
    }
}