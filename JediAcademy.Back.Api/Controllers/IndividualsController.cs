using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using JediAcademy.Back.Application.Queries;

namespace JediAcademy.Back.Api.Controllers
{
    [ApiController]
    [Route("api/individuals")]
    public class IndividualsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public IndividualsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var jedi = await _mediator.Send(new GetStudents.Query());
            if (jedi.IsSuccess)
            {
                return Ok(jedi.Result);
            }
            return jedi.Result != null ?
                NotFound(jedi.Message) :
                StatusCode(500, jedi.Message);
        }
    }


}
