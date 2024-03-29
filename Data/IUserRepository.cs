using System.Threading.Tasks;
using shoppinglistapi.Models;

namespace shoppinglistapi.Data
{
    public interface IUserRepository
    {
         void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T: class;
        Task<bool> SaveAll();
        Task<User> GetUser(int id);
        Task<User> CreateUserAsync(User user);
        Task<ShoppingList> CreateShoppingListAsync(ShoppingList shoppingList, int userId);
    }
}