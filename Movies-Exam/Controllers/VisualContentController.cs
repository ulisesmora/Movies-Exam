using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Movies_Exam.Application.Commands;
using Movies_Exam.Application.Dtos;
using Movies_Exam.Application.Querys;
using Movies_Exam.Model;

namespace Movies_Exam.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VisualContentController : ControllerBase
    {
        private readonly IMediator _mediator;

        public VisualContentController(IMediator mediator)
        {
            _mediator = mediator;
        }

         [HttpPost]
         public async Task<ActionResult<Unit>> CreateNewVisualContent(CreateVisualContent.Create data)
         {
             return await _mediator.Send(data);
         }

        [HttpGet("{id}")]
        public async Task<ActionResult<VisualContentDto>> GetVisualContentById(Guid id)
        {
            return await _mediator.Send(new GetVisualContentById.Query { Id = id });
        }

        [HttpGet]
        public async Task<ActionResult<List<VisualContentDto>>> GetVisualContent()
        {
            return await _mediator.Send(new GetVisualContent.Query());
        }


        [HttpGet("popular")]
        public async Task<ActionResult<List<VisualContentDto>>> GetPopularVisualContent()
        {
            return await _mediator.Send(new GetPopularVisualContent.Query());
        }

        [HttpGet("search/{parameter}")]
        public async Task<ActionResult<List<VisualContentDto>>> SearchVisualContent(string parameter)
        {
            return await _mediator.Send(new SearchVisualContentByName.Query { searchTerm = parameter});
        }


    }
}
