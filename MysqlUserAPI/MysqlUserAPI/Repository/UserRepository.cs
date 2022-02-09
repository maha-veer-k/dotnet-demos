using Microsoft.EntityFrameworkCore;
using MysqlUserAPI.Data;
using MysqlUserAPI.Model;

namespace MysqlUserAPI.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly UserDbContext _context;

        public UserRepository(UserDbContext context)
        {
            _context = context;
        }

        public async Task<List<UserModel>> GetAsync()
        {
            var users = await _context.Users.ToListAsync();
            return users;
        }
    }
}
