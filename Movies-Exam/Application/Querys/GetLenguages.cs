using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Movies_Exam.Application.Dtos;
using Movies_Exam.Model;
using Movies_Exam.Persistence;

namespace Movies_Exam.Application.Querys
{
    public class GetLenguages
    {
        public class Query : IRequest<List<LanguageDto>> { }
        public class Handler : IRequestHandler<Query, List<LanguageDto>>
        {
            private readonly MoviesContext _context;
            private readonly IMapper _mapper;

            public Handler(MoviesContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<List<LanguageDto>> Handle(Query request, CancellationToken cancellationToken)
            {
                var languages = await _context.Language.ToListAsync();

                var languagesDto = _mapper.Map<List<Language>, List<LanguageDto>>(languages);
                return languagesDto;


            }
        }
    }
}
