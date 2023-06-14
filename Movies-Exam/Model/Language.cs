namespace Movies_Exam.Model
{
    public class Language
    {
        public Guid LanguageId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public ICollection<VisualContentLanguage> LanguageLink { get; set; }

    }
}
