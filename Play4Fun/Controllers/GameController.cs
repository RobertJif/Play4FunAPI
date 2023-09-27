using AutoMapper;
using Microsoft.AspNetCore.Mvc;
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
            List<GameDto> games = service.GetAllOptions();
            return mapper.Map<List<GameDto>, List<GameResponse>>(games);
        }
    }
}
