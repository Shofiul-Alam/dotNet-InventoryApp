using System.Threading.Tasks;
using Inventory.API.Data;
using Inventory.API.Dtos;
using Inventory.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Inventory.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController: ControllerBase
    {
        public IAuthRepository _repo { get; set; }
        public AuthController(IAuthRepository repo)
        {
            _repo = repo;

        }

        [HttpPost("register")]

        public async Task<IActionResult> register(UserForRegisterDto userForRegisterDto)
        {
            //validate request 

            userForRegisterDto.Username = userForRegisterDto.Username.ToLower();

            if(await _repo.userExists(userForRegisterDto.Username))
                return BadRequest("Username already exists");

            var userToCreate = new User
            {
                Username = userForRegisterDto.Username
            };

            var createdUser = await _repo.Register(userToCreate, userForRegisterDto.Password);

            return StatusCode(201);

        }
    }
}