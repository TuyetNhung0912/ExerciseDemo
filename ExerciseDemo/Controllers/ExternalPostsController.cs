using ExerciseDemo.Application.Common.Responses;
using ExerciseDemo.Application.DTOs.Posts;
using ExerciseDemo.Application.Queries;
using ExerciseDemo.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace ExerciseDemo.Controllers
{
    [ApiController]
    [Route("api/external-posts")]
    public class ExternalPostsController: ControllerBase
    {
        private readonly IMediator mediator;
        public ExternalPostsController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpGet("{id:int}")]
        [ProducesResponseType(typeof(ApiResponse<ExternalPostDto>), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetPost(int id, CancellationToken cancellationToken)
            => Ok( await mediator.Send(new GetExternalPostQueryRequest{ PostId = id },cancellationToken));

    }
}
