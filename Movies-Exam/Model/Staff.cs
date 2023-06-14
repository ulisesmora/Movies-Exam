namespace Movies_Exam.Model
{
    public class Staff
    {
        public Guid StaffId { get; set; }
        public string Name { get; set; }
        public DateTime BornhDate { get; set; }
        public ICollection<VisualContentStaff> VisualContentStaffList { get; set; }
    }
}
