using Movies_Exam.Model;

namespace Movies_Exam.Application.Dtos
{
    public class VisualContentStaffDto
    {
        public Guid VisualContentStaffId { get; set; }
        public Guid VisualContentId { get; set; }
        public Guid StaffId { get; set; }

        public Guid RoleId { get; set; }


        public StaffDto Staff { get; set; }
    }
}
