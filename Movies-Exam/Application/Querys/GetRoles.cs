using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Movies_Exam.Application.Dtos;
using Movies_Exam.Model;
using Movies_Exam.Persistence;

namespace Movies_Exam.Application.Querys
{
    public class GetRoles
    {
        public class Query : IRequest<List<RoleDto>> { }
        public class Handler : IRequestHandler<Query, List<RoleDto>>
        {
            private readonly MoviesContext _context;
            private readonly IMapper _mapper;

            public Handler(MoviesContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<List< RoleDto>> Handle(Query request, CancellationToken cancellationToken)
            {
                var roles = await _context.Role.ToListAsync();

                var rolesDto = _mapper.Map<List<Role>, List<RoleDto>>(roles);
                return rolesDto;


            }
        }
    }
}
