using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Movies_Exam.Application.Dtos;
using Movies_Exam.Model;
using Movies_Exam.Persistence;
using System.Net;

namespace Movies_Exam.Application.Querys
{
    public class GetVisualContentById
    {
        public class Query : IRequest<VisualContentDto> { 
            public Guid Id { get; set; }
        }
        public class Handler : IRequestHandler<Query, VisualContentDto>
        {
            private readonly MoviesContext _context;
            private readonly IMapper _mapper;

            public Handler(MoviesContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<VisualContentDto> Handle(Query request, CancellationToken cancellationToken)
            {
                var visualcontent = await _context.VisualContent.
                    Include(x => x.TypeContent)
                    .Include(x => x.Stadistics)
                    .Include(x => x.GenreLink)
                .ThenInclude(y => y.Genre)
                    .Include(x => x.StaffLink)
                .ThenInclude(y => y.Staff)
                    .Include(x => x.LanguageLink)
                .ThenInclude(y => y.Language)
                    .FirstOrDefaultAsync(x => x.VisualContentId == request.Id);
                if (visualcontent == null)
                {

                    throw new Exception("Can´t Find VisualContent");
                }

                var visualDto = _mapper.Map<VisualContent, VisualContentDto>(visualcontent);
                return visualDto;
            }
        }
    }
}
