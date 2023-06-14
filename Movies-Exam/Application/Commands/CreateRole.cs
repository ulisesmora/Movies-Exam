using FluentValidation;
using MediatR;
using Movies_Exam.Model;
using Movies_Exam.Persistence;

namespace Movies_Exam.Application.Commands
{
    public class CreateRole
    {
        public class Create : IRequest
        {
            public string RoleName { get; set; }

        }

        public class CreateValidation : AbstractValidator<Create>
        {
            public CreateValidation()
            {
                RuleFor(x => x.RoleName).NotEmpty();
            }
        }

        public class Creator : IRequestHandler<Create>
        {
            private readonly MoviesContext _context;

            public Creator(MoviesContext context)
            {
                _context = context;
            }
            public async Task<Unit> Handle(Create request, CancellationToken cancellationToken)
            {
                var role = new Role
                {
                    RoleName = request.RoleName
                };

                _context.Role.Add(role);
                var newRole = await _context.SaveChangesAsync();
                if (newRole > 0)
                {
                    return Unit.Value;
                }
                throw new Exception("Can´t Insert New role");
            }
        }
    }
}
