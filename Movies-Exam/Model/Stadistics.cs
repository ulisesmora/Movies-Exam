namespace Movies_Exam.Model
{
    public class Stadistics
    {
        public Guid StadisticsId { get; set; }
        public int Views { get; set; }

        public ICollection<VisualContent> VisualContent { get; set; }
    }
}
