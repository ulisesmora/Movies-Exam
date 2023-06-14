using System.Reflection.Metadata;

namespace Movies_Exam.Model
{
    public class TypeContent
    {
        public Guid TypeContentId { get; set; }
        public string NameContent { get; set; }
        public ICollection<VisualContent> VisualContent { get; set; }
    }
}
