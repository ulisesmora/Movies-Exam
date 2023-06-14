namespace Movies_Exam.Model
{
    public class Genre
    {
        public Guid GenreId { get; set; }
        public string Name { get; set; }

        public ICollection<VisualContentGenre> GenreLink { get; set; }
    }
}
