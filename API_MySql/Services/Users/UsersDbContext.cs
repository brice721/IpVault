using System.Data;
using System.Data.Entity;
using MySql.Data.MySqlClient;
using API_Attempt.Services.Users.Entity;
using MySql.Data.Entity;

namespace API_Attempt.Services.Users
{
    public class UsersDbContext : DbContext
    {
        public UsersDbContext() : base("DefaultConnection")
        {
            Database.SetInitializer<UsersDbContext>(null);
        }

        public virtual DbSet<UsersEntity> Users { get; set; }

        public DataSet GetUsers()
        {
            return new DataSet();
        }
    }
}