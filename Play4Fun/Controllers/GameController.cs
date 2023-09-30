using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Any;
using Play4Fun.Models.Responses;
using Play4Fun.Repository;
using Play4Fun.Services;
using Play4Fun.Services.Dtos;
using Play4Fun.Utils;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Play4Fun.Controllers
{
    [Route("api/game")]
    [ApiController]
    public class GameController : ControllerBase
    {
        GameService service;
        Mapper mapper;
        public GameController(ApiDbContext db)
        {
            service = new GameService(db);
            mapper = Mappers.InitializeAutomapper();
        }

        // GET api/game
        [HttpGet]
        public List<GameResponse> Game()
        {
            List<GameDto> games = service.GetAllPlayable();
            return mapper.Map<List<GameDto>, List<GameResponse>>(games);
        }
    }
}
