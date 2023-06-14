using FluentValidation;
using MediatR;
using Movies_Exam.Model;
using Movies_Exam.Persistence;

namespace Movies_Exam.Application.Commands
{
    public class CreateLanguage
    {
        public class Create : IRequest
        {
            public string Name { get; set; }
            public string Code { get; set; }

        }

        public class CreateValidation : AbstractValidator<Create>
        {
            public CreateValidation()
            {
                RuleFor(x => x.Name).NotEmpty();
                RuleFor(x => x.Code).NotEmpty();
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
                var language = new Language
                {
                    Name = request.Name,
                    Code = request.Code,
                };

                _context.Language.Add(language);
                var newLanguage = await _context.SaveChangesAsync();
                if (newLanguage > 0)
                {
                    return Unit.Value;
                }
                throw new Exception("Can´t Insert New Language");
            }
        }
    }
}
