using FluentValidation;
using MediatR;
using Movies_Exam.Model;
using Movies_Exam.Persistence;

namespace Movies_Exam.Application.Commands
{
    public class CreateGenre
    {
        public class Create : IRequest
        {
            public string Name { get; set; }

        }

        public class CreateValidation : AbstractValidator<Create>
        {
            public CreateValidation()
            {
                RuleFor(x => x.Name).NotEmpty();
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
                var genre = new Genre
                {
                    Name = request.Name,
                };

                _context.Genre.Add(genre);
                var newGenre = await _context.SaveChangesAsync();
                if (newGenre > 0)
                {
                    return Unit.Value;
                }
                throw new Exception("Can´t Insert New genre");
            }
        }
    }
}
