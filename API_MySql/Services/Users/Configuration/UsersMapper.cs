using API_Attempt.Services.Users.Entity;
using API_Attempt.Services.Users.Model;

namespace API_Attempt.Services.Users.Configuration
{
    public class UsersMapper : AutoMapper.Profile
    {
        public UsersMapper()
        {
            CreateMap<UsersModel, UsersEntity>();
            CreateMap<UsersEntity, UsersModel>();
        }
    }
}