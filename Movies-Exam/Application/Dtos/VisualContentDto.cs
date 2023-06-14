using Movies_Exam.Model;

namespace Movies_Exam.Application.Dtos
{
    public class VisualContentDto
    {
        public Guid VisualContentId { get; set; }
        public string Name { get; set; }
        public string Synopsis { get; set; }
        public string Country { get; set; }
        public string Image { get; set; }
        public int RealeseYear { get; set; }
        public float? Rating { get; set; }
        public TypeContentDto TypeContent { get; set; }

        public StadisticsDto Stadistics { get; set; }
        
        public ICollection<VisualContentGenreDto> GenreLink { get; set; }
        public ICollection<VisualContentLanguageDto> LanguageLink { get; set; }
        public ICollection<VisualContentStaffDto> StaffLink { get; set; }
    }
}
