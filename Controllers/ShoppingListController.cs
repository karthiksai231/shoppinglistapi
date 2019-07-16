using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using shoppinglistapi.Data;
using shoppinglistapi.Dto;
using shoppinglistapi.Models;

namespace shoppinglistapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingListController : ControllerBase
    {
        private readonly IShoppingListRepository _shoppingListRepository;
        public ShoppingListController(IShoppingListRepository shoppingListRepository)
        {
            _shoppingListRepository = shoppingListRepository;

        }
        [HttpPost("create")]
        public async Task<IActionResult> Create(ShoppingListDto shoppingListDto)
        {
            var shoppingListToCreate = new ShoppingList
            {
                Name = shoppingListDto.Name,
                
            };

            var createdUser = await _shoppingListRepository.CreateShoppingListAsync(shoppingListToCreate);
            return Ok();
        }
    }
}