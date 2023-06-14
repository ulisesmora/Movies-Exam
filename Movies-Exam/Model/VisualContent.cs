namespace Movies_Exam.Model
{
    public class VisualContent
    {

        public Guid VisualContentId { get; set; }
        public string Name { get; set; }
        public string Synopsis { get; set; }
        public string Country { get; set; }
        public string Image { get; set; }
        public int RealeseYear { get; set; }
        public float? Rating { get; set; }
        public Guid TypeContentId { get; set; }
        public TypeContent TypeContent { get; set; }

        public Guid StadisticId { get; set; }
        public Stadistics Stadistics { get; set; }

        public ICollection<VisualContentGenre> GenreLink { get; set; }
        public ICollection<VisualContentLanguage> LanguageLink { get; set; }
        public ICollection<VisualContentStaff> StaffLink { get; set; }

    }
}
