using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Play4Fun.Models.Requests;
using Play4Fun.Models.Responses;
using Play4Fun.Repository;
using Play4Fun.Services.Impl;
using Play4Fun.Utils;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Play4Fun.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        IConfiguration configuration;
        JwtHelper jwt;
        AuthService service;
        public AuthController(ApiDbContext db, IConfiguration configuration)
        {
            this.configuration = configuration;
            jwt = new JwtHelper(configuration);
            service = new AuthService(db, configuration);
        }

        // POST api/auth/login
        [AllowAnonymous]
        [HttpPost]
        [Route("login")]
        public IActionResult Login([FromBody] LoginRequest req)
        {
            IActionResult response = Unauthorized();

            if (req != null)
            {
                if (service.CheckCredential(req.Username, req.Password))
                {
                    var accessToken = jwt.GenerateAccessToken(req.Username);
                    return Ok(accessToken);
                }
            }

            return response;
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
