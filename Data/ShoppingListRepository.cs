using System.Threading.Tasks;
using shoppinglistapi.Models;

namespace shoppinglistapi.Data
{
    public class ShoppingListRepository : IShoppingListRepository
    {
        private readonly DataContext _dataContext;
        private readonly IUserRepository _userRepository;
        public ShoppingListRepository(DataContext dataContext, IUserRepository userRepository)
        {
            _userRepository = userRepository;
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

        public async Task<ShoppingList> CreateShoppingListAsync(ShoppingList shoppingList, int userId)
        {
            var user = await _userRepository.GetUser(userId);
            user.ShoppingLists.Add(shoppingList);
            await SaveAll();

            return shoppingList;
        }
    }
}