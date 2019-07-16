using System.Threading.Tasks;
using shoppinglistapi.Models;

namespace shoppinglistapi.Data
{
    public interface IShoppingListRepository
    {
         void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T: class;
        Task<bool> SaveAll();
        Task<ShoppingList> CreateShoppingListAsync(ShoppingList shoppingList, int userId);
    }
}