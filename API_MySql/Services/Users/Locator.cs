using API_Attempt.Services.Users.Configuration;
using API_Attempt.Services.Users.Service;
using AutoMapper;

namespace API_Attempt.Services.Users
{
    public static class Locator
    {
        private static UsersDbContext _usersDbContext = null;

        public static UsersDbContext GetUsersDbContext()
        {
            if (Locator._usersDbContext == null)
            {
                Locator._usersDbContext = new UsersDbContext();
            }
            return Locator._usersDbContext;
        }

        private static IMapper _mapperConfig;

        public static void ConfigureMapper()
        {
            _mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<UsersMapper>();
            }).CreateMapper();
        }

        public static IMapper Mapper
        {
            get
            {
                if(_mapperConfig == null) ConfigureMapper();
                return _mapperConfig;
            }
        }

        public static UsersService GetUsersService()
        {
            return new UsersService();
        }
    }
}