using Movies_Exam.Model;

namespace Movies_Exam.Application.Dtos
{
    public class StaffDto
    {
        public Guid StaffId { get; set; }
        public string Name { get; set; }
        public DateTime BornhDate { get; set; }
    }
}
