using GlobalAccelerexTaskApi.Handler;
using GlobalAccelerexTaskApi.models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GlobalAccelerexTaskApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OpeningHoursController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OpeningHoursController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("new")]
        public ActionResult<List<Response>> PostWorkingDays([FromBody] Dictionary<string, List<RequestType>> keyValues)
        {

            var res = _mediator.Send(new InputHandler.Command { InputRequest = keyValues });
            return Ok(res);
        }
    }
}
