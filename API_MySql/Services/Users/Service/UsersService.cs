using API_Attempt.Services.Users.Data;
using API_Attempt.Services.Users.Entity;
using API_Attempt.Services.Users.Model;

namespace API_Attempt.Services.Users.Service
{
    public class UsersService
    {
        private UsersDao _usersDao = null;
        public UsersModel GetUsers(int id)
        {
            var Users = this._usersDao.GetUsers(id);

            return Locator.Mapper.Map<UsersModel>(Users);
        }

        public UsersService()
        {
            this._usersDao = new UsersDao();
        }

        public void AddUsers(UsersModel model)
        {
            UsersEntity newUsers = Locator.Mapper.Map<UsersEntity>(model);

            this._usersDao.AddUsers(newUsers);
        }

        public void UpdateUsers(UsersModel model)
        {
            UsersEntity newUsers = Locator.Mapper.Map<UsersEntity>(model);

            this._usersDao.UpdateUsers(newUsers);
        }

        public void RemoveUsers(UsersModel model)
        {
            UsersEntity DlUsers = Locator.Mapper.Map<UsersEntity>(model);

            this._usersDao.RemoveUsers(DlUsers);
        }
    }
}