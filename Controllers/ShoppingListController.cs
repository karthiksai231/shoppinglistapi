using System;
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
        private readonly IUserRepository _userRepository;
        public ShoppingListController(IUserRepository userRepository)
        {
            _userRepository = userRepository;

        }
        [HttpPost("create")]
        public async Task<IActionResult> Create(ShoppingListDto shoppingListDto)
        {
            var shoppingListToCreate = new ShoppingList
            {
                Name = shoppingListDto.Name,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            };

            var createdUser = await _userRepository.CreateShoppingListAsync(shoppingListToCreate, 1);
            return Ok();
        }
    }
}