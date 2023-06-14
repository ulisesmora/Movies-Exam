namespace Movies_Exam.Model
{
    public class VisualContentLanguage
    {
        public Guid VisualContentLanguageId { get; set; }
        public Guid VisualContentId { get; set; }
        public Guid LanguageId { get; set; }
        public VisualContent VisualContent { get; set; }
        public Language Language { get; set; }
    }
}
