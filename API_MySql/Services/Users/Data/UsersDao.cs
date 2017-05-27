using API_Attempt.Services;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API_Attempt.Services.Users.Entity;

namespace API_Attempt.Services.Users.Data
{
    public class UsersDao
    {
        public void AddUsers(UsersEntity entity)
        {
            Locator.GetUsersDbContext().Users.Add(entity);
            Locator.GetUsersDbContext().SaveChanges();
        }

        public void UpdateUsers(UsersEntity entity)
        {
            Locator.GetUsersDbContext().Entry(entity).State = System.Data.Entity.EntityState.Modified;
            Locator.GetUsersDbContext().SaveChanges();
        }

        public void RemoveUsers(UsersEntity entity)
        {
            Locator.GetUsersDbContext().Entry(entity).State = System.Data.Entity.EntityState.Deleted;
            Locator.GetUsersDbContext().SaveChanges();
        }

        public UsersEntity GetUsers(int id)
        {
            return Locator.GetUsersDbContext().Users.Find(id);
        }
    }
}