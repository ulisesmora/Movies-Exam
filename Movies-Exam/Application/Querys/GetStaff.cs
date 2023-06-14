using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Movies_Exam.Application.Dtos;
using Movies_Exam.Model;
using Movies_Exam.Persistence;

namespace Movies_Exam.Application.Querys
{
    public class GetStaff
    {
        public class Query : IRequest<List<StaffDto>> { }
        public class Handler : IRequestHandler<Query, List<StaffDto>>
        {
            private readonly MoviesContext _context;
            private readonly IMapper _mapper;

            public Handler(MoviesContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<List<StaffDto>> Handle(Query request, CancellationToken cancellationToken)
            {
                var staff = await _context.Staff.ToListAsync();

                var staffDto = _mapper.Map<List<Staff>, List<StaffDto>>(staff);
                return staffDto;


            }
        }
    }
}
