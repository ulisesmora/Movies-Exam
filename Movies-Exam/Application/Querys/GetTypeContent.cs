using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Movies_Exam.Application.Dtos;
using Movies_Exam.Model;
using Movies_Exam.Persistence;

namespace Movies_Exam.Application.Querys
{
    public class GetTypeContent
    {
        public class Query : IRequest<List<TypeContentDto>> { }
        public class Handler : IRequestHandler<Query, List<TypeContentDto>>
        {
            private readonly MoviesContext _context;
            private readonly IMapper _mapper;

            public Handler(MoviesContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<List<TypeContentDto>> Handle(Query request, CancellationToken cancellationToken)
            {
                var types = await _context.TypeContent.ToListAsync();

                var typesDto = _mapper.Map<List<TypeContent>, List<TypeContentDto>>(types);
                return typesDto;


            }
        }
    }
}
