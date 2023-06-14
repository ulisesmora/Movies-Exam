using Movies_Exam.Model;

namespace Movies_Exam.Application.Dtos
{
    public class VisualContentGenreDto
    {
        public Guid VisualContentGenreId { get; set; }
        public Guid VisualContentId { get; set; }
        public Guid GenreId { get; set; }

        public GenreDto Genre { get; set; }
    }
}
