using Apanvi.API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Apanvi.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
            private readonly IUserRepository _userRepository; 

            public UserController(IUserRepository userRepository)
            {
                _userRepository = userRepository;
            }
            [HttpGet]
            public IActionResult GetAllUsers() 
            {
                var users = _userRepository.GetAll();
                return Ok(users);
            }
    }
}
