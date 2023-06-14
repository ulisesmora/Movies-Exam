namespace Movies_Exam.Model
{
    public class VisualContentGenre
    {
        public Guid VisualContentGenreId { get; set; }
        public Guid VisualContentId { get; set; }
        public Guid GenreId { get; set; }
        public VisualContent VisualContent { get; set; }
        public Genre Genre { get; set; }

    }
}
