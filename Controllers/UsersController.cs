using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using shoppinglistapi.Data;
using shoppinglistapi.Dto;
using shoppinglistapi.Models;

namespace shoppinglistapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        [HttpPost("create")]
        public async Task<IActionResult> CreateUser(UserForRegistrationDto userForRegistrationDto)
        {
            var userToCreate = new User
            {
                Name = userForRegistrationDto.Name
            };

            var createdUser = await _userRepository.CreateUserAsync(userToCreate);

            return Ok();
        }
    }
}