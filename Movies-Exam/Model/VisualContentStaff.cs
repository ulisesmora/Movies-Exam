namespace Movies_Exam.Model
{
    public class VisualContentStaff
    {

        public Guid VisualContentStaffId { get; set; }
        public Guid VisualContentId { get; set; }
        public Guid StaffId { get; set; }

        public Guid RoleId { get; set; }
        public Role Role { get; set; }
        public VisualContent VisualContent { get; set; }
        public Staff Staff { get; set; }

    }
}
