using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Movies_Exam.Application.Dtos;
using Movies_Exam.Model;
using Movies_Exam.Persistence;

namespace Movies_Exam.Application.Querys
{
    public class GetGenre
    {
        public class Query : IRequest<List<GenreDto>> { }
        public class Handler : IRequestHandler<Query, List<GenreDto>>
        {
            private readonly MoviesContext _context;
            private readonly IMapper _mapper;

            public Handler(MoviesContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;   
            }

            public async Task<List<GenreDto>> Handle(Query request, CancellationToken cancellationToken)
            {
                var genres = await _context.Genre.ToListAsync();

                var genresDto = _mapper.Map<List<Genre>, List<GenreDto>>(genres);
                return genresDto;


            }
        }

    }
}
