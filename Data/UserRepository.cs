using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using shoppinglistapi.Models;

namespace shoppinglistapi.Data
{
    public class UserRepository : IUserRepository
    {
        public DataContext _dataContext { get; set; }
        public UserRepository(DataContext dataContext)
        {
            _dataContext = dataContext;

        }
        public void Add<T>(T entity) where T : class
        {
            _dataContext.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _dataContext.Remove(entity);
        }

        public async Task<User> GetUser(int id)
        {
            var user = await _dataContext.User.FirstOrDefaultAsync(u => u.Id == id);

            return user;
        }

        public async Task<bool> SaveAll()
        {
            return await _dataContext.SaveChangesAsync() > 0;
        }

        public async Task<User> CreateUserAsync(User user)
        {
            await _dataContext.User.AddAsync(user);
            await _dataContext.SaveChangesAsync();

            return user;
        }
    }
}