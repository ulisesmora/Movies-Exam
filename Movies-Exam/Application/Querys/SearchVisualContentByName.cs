using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Movies_Exam.Application.Dtos;
using Movies_Exam.Model;
using Movies_Exam.Persistence;

namespace Movies_Exam.Application.Querys
{
    public class SearchVisualContentByName
    {
        public class Query : IRequest<List<VisualContentDto>> { 
           public string searchTerm { get; set; }
        }
        public class Handler : IRequestHandler<Query, List<VisualContentDto>>
        {
            private readonly MoviesContext _context;
            private readonly IMapper _mapper;

            public Handler(MoviesContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<List<VisualContentDto>> Handle(Query request, CancellationToken cancellationToken)
            {
                var visualcontent = await _context.VisualContent.Where(p => p.Name.Contains(request.searchTerm)).ToListAsync();

                var visualcontentDto = _mapper.Map<List<VisualContent>, List<VisualContentDto>>(visualcontent);
                return visualcontentDto;


            }
        }
    }
}
