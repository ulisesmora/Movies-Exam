using Movies_Exam.Model;

namespace Movies_Exam.Application.Dtos
{
    public class VisualContentLanguageDto
    {
        public Guid VisualContentLanguageId { get; set; }
        public Guid VisualContentId { get; set; }
        public Guid LanguageId { get; set; }


        public LanguageDto Language { get; set; }
    }
}
