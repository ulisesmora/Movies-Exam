using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Movies_Exam.Application.Dtos;
using Movies_Exam.Model;
using Movies_Exam.Persistence;

namespace Movies_Exam.Application.Querys
{
    public class GetStadistics
    {
        public class Query : IRequest<List<StadisticsDto>> { }
        public class Handler : IRequestHandler<Query, List<StadisticsDto>>
        {
            private readonly MoviesContext _context;
            private readonly IMapper _mapper;

            public Handler(MoviesContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<List<StadisticsDto>> Handle(Query request, CancellationToken cancellationToken)
            {
                var stadistics = await _context.Stadistics.ToListAsync();

                var stadisticsDto = _mapper.Map<List<Stadistics>, List<StadisticsDto>>(stadistics);
                return stadisticsDto;


            }
        }
    }
}
