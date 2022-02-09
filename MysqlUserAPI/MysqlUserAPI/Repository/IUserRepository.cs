using MysqlUserAPI.Model;

namespace MysqlUserAPI.Repository
{
    public interface IUserRepository
    {
        Task<List<UserModel>> GetAsync();
    }
}
