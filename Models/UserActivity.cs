namespace EmployeesManagement.Models
{
    public class UserActivity
    {
        public string? CreatedById { get; set; }
        public DateTime CreatedOn { get; set; }

        public string? ModifiedById { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
