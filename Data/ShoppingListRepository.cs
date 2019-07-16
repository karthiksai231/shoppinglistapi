using System.Threading.Tasks;
using shoppinglistapi.Models;

namespace shoppinglistapi.Data
{
    public class ShoppingListRepository : IShoppingListRepository
    {
        private readonly DataContext _dataContext;
        public ShoppingListRepository(DataContext dataContext)
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

        public async Task<bool> SaveAll()
        {
            return await _dataContext.SaveChangesAsync() > 0;
        }

        public async Task<ShoppingList> CreateShoppingListAsync(ShoppingList shoppingList)
        {
            // var user = await _dataContext.GetUser(userId);
            await _dataContext.ShoppingList.AddAsync(shoppingList);
            await _dataContext.SaveChangesAsync();

            return shoppingList;
        }
    }
}