using Microsoft.AspNetCore.Mvc;
using Play4Fun.Models.Responses;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Play4Fun.Controllers
{
    [Route("api/game")]
    [ApiController]
    public class GameController : ControllerBase
    {

        // GET api/game
        [HttpGet]
        public List<GameResponse> Game()
        {

            List<GameResponse> response = new List<GameResponse>();
            response.Add(new GameResponse
            {
                Id = 1,
                Code = "TIC_TAC_TOE",
                DescriptionHTML = "Game in which two players take turns in drawing either an <b style='color: var(--color-success-200)'>O</b> or an <b style='color: var(--color-error-200)'>X</b> in one square of a grid consisting of nine squares",
                GameImagePath = "/public/images/game/tic-tac-toe.png",
                Name = "TicTacToe",
                PlayerCount = 1
            });

            return response;
        }
    }
}
