using ExerciseDemo.Application.Common.Responses;
using ExerciseDemo.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using MediatR;
using ExerciseDemo.Application.Queries;
namespace ExerciseDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController: ControllerBase
    {
        private readonly IMediator mediator;
        public ProductController (IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpPost]
        [Route("/api/get-history-not-ok")]
        [ProducesResponseType(typeof(ApiResponse<List<Product>?>), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetHistoryTicketNotok([FromBody] GetHistoryTicketNotokQueryRequest request)
            => Ok(await mediator.Send(request));




    }
}
