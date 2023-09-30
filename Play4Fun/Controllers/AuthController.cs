using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Play4Fun.Models.Requests;
using Play4Fun.Models.Responses;
using Play4Fun.Repository;
using Play4Fun.Repository.Entities;
using Play4Fun.Services.Dtos;
using Play4Fun.Services.Impl;
using Play4Fun.Utils;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Play4Fun.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        JwtHelper jwt;
        AuthService service;
        Mapper mapper;
        public AuthController(ApiDbContext db, IConfiguration configuration)
        {
            jwt = new JwtHelper(configuration);
            service = new AuthService(db, configuration, jwt);
            mapper = Mappers.InitializeAutomapper();
        }

        // POST api/auth/login
        [AllowAnonymous]
        [HttpPost]
        [Route("login")]
        public IActionResult Login([FromBody] LoginRequest req)
        {
            var isRequestValid = new LoginRequestValidator().Validate(req);


            if (!isRequestValid.IsValid)
            {
                return BadRequest(mapper.Map<IList<ErrorResponse>>(isRequestValid.Errors));
            }

            PlayerDto? player = service.IsCredentialOk(req.Username.ToLower(), req.Password);
            if (player == null)
            {
                return Unauthorized();
            }

            string accessToken = jwt.GenerateAccessToken(player.Username);
            string refreshCode = jwt.GenerateRefreshToken(player.Username);
            return Ok(new LoginResponse(accessToken, refreshCode));
        }
        // POST api/auth/register
        [HttpPost]
        [Route("register")]
        public IActionResult Register([FromBody] RegisterRequest req)
        {
            var isRequestValid = new RegisterRequestValidator().Validate(req);
            if (!isRequestValid.IsValid)
            {
                return BadRequest(mapper.Map<IList<ErrorResponse>>(isRequestValid.Errors));
            }

            service.Create(mapper.Map<CreatePlayerDto>(req));

            return Ok();
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
