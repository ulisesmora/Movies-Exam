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
    public class StaffController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StaffController(IMediator mediator)
        {
            _mediator = mediator;
        }
        
        [HttpPost]
        public async Task<ActionResult<Unit>> CreateNewStaff(CreateStaff.Create data)
        {
            return await _mediator.Send(data);
        }

        [HttpGet]
        public async Task<ActionResult<List<StaffDto>>> GetStaff()
        {
            return await _mediator.Send(new GetStaff.Query());
        }
    }
}
