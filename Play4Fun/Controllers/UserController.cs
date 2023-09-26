using Microsoft.AspNetCore.Mvc;
using Play4Fun.Models.Requests;
using Play4Fun.Models.Responses;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Play4Fun.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    { 

        // POST api/auth/login
        [HttpPost]
        [Route("login")]
        public LoginResponse Login([FromBody] LoginRequest req)
        {
            return new LoginResponse{AccessToken="akses", RefreshToken="refresh"};
        }
        // POST api/auth/register
        [HttpPost]
        [Route("register")]
        public void Register([FromBody] string value)
        {
        }
        // POST api/auth/login
        [HttpPost]
        [Route("auth")]
        public void Auth([FromBody] string value)
        {
        }
        // POST api/auth/login
        [HttpPost]
        [Route("refresh")]
        public void Refresh([FromBody] string value)
        {
        }
    }
}
