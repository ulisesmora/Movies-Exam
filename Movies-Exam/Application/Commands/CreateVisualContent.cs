using FluentValidation;
using MediatR;
using Movies_Exam.Model;
using Movies_Exam.Persistence;

namespace Movies_Exam.Application.Commands
{
    public class CreateVisualContent
    {
        public class Create : IRequest
        {
            public string Name { get; set; }
            public string Synopsis { get; set; }
            public string Country { get; set; }
            public string Image { get; set; }
            public int RealeseYear { get; set; }
            public float? Rating { get; set; }
            public Guid TypeContentId { get; set; }
            public List<Guid> LanguageList { get; set; }
            public List<Guid> GenreList { get; set; }

        }

        public class CreateValidation : AbstractValidator<Create>
        {
            public CreateValidation()
            {
                RuleFor(x => x.Name).NotEmpty();
                RuleFor(x => x.Synopsis).NotEmpty();
                RuleFor(x => x.Country).NotEmpty();
                RuleFor(x => x.Image).NotEmpty();
                RuleFor(x => x.RealeseYear).NotEmpty();
                RuleFor(x => x.Rating).NotEmpty();
                RuleFor(x => x.TypeContentId).NotEmpty();
                RuleFor(x => x.LanguageList).NotEmpty();
                RuleFor(x => x.GenreList).NotEmpty();
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
                Guid visualId = Guid.NewGuid();
                Guid stadisticId = Guid.NewGuid();

                var visualcontent = new VisualContent
                {
                    VisualContentId = visualId,
                    Name = request.Name,
                    Synopsis = request.Synopsis,
                    Country = request.Country,
                    Image = request.Image,
                    RealeseYear = request.RealeseYear,
                    Rating = request.Rating,
                    TypeContentId = request.TypeContentId,
                    StadisticId = stadisticId,
                    
                };

                _context.VisualContent.Add(visualcontent);

                List<VisualContent> visual = new List<VisualContent>();
                visual.Add(visualcontent);

                 var stadistic = new Stadistics
                {
                    StadisticsId = stadisticId,
                    Views = 0,
                    VisualContent = visual,
                };

                _context.Stadistics.Add(stadistic);

                foreach (var id in request.GenreList)
                {
                    var genreList = new VisualContentGenre
                    {
                        VisualContentId = visualId,
                        GenreId = id
                    };
                    _context.VisualContentGenre.Add(genreList);


                }

                foreach (var id in request.LanguageList)
                {
                    var languageList = new VisualContentLanguage
                    {
                        VisualContentId = visualId,
                        LanguageId = id
                    };
                    _context.VisualContentLanguage.Add(languageList);


                }



                var newRole = await _context.SaveChangesAsync();
                if (newRole > 0)
                {
                    return Unit.Value;
                }
                throw new Exception("Can´t Insert New Visual Content");
            }
        }
    }
}
