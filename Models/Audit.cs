namespace EmployeesManagement.Models
{
    public class Audit
    {
        public int Id { get; set; }

        public string UserId { get; set; }
        public ApplicationUser User { get; set; } 

        public string AuditType { get; set; }

        public string TableName { get; set; }
        public DateTime DateTime { get; set; }

        public string? OldValues { get; set; }

        public string? NewValues { get; set; }

        public string? AffectedColumns { get; set; }

        public string PrimaryKey { get; set; }
    }
    public enum AuditType
    {
        None = 0,
        Create = 1,
        Update = 2,
        Delete = 3,
        Login = 4,
    }
}
