using FluentValidation;
using MediatR;
using Movies_Exam.Model;
using Movies_Exam.Persistence;

namespace Movies_Exam.Application.Commands
{
    public class CreateTypeContent
    {
        public class Create : IRequest
        {
            public string NameContent { get; set; }

        }

        public class CreateValidation : AbstractValidator<Create>
        {
            public CreateValidation()
            {
                RuleFor(x => x.NameContent).NotEmpty();
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
                var type = new TypeContent
                {
                    NameContent = request.NameContent,
                };

                _context.TypeContent.Add(type);
                var newRole = await _context.SaveChangesAsync();
                if (newRole > 0)
                {
                    return Unit.Value;
                }
                throw new Exception("Can´t Insert New type");
            }
        }
    }
}
