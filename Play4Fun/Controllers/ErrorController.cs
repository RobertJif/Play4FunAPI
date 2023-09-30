using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Play4Fun.Models.Requests;
using Play4Fun.Models.Responses;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Play4Fun.Controllers
{
    [Route("/error")]
    [ApiController]
    public class ErrorController : ControllerBase
    {

        // GET error handler
        [HttpPost]
        [HttpGet]
        [HttpPut]
        [HttpDelete]
        public IActionResult Error()
        {
            Exception? exception = HttpContext.Features.Get<IExceptionHandlerFeature>()?.Error;

            return Problem(detail: exception?.Message, title: exception?.Message, statusCode: 500);
        }
    }
}
