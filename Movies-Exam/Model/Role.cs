namespace Movies_Exam.Model
{
    public class Role
    {
        public Guid RoleId { get; set; }
        public string RoleName { get; set; }

        public ICollection<VisualContentStaff> StaffLink { get; set; }

    }
}
