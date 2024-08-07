namespace EmployeesManagement.Models
{
    public class ApprovalsUserMatrix :UserActivity
    {
        public int Id { get; set; }

        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        public int DocumentTypeId { get; set; }
        public SystemCodeDetail DocumentType { get; set; }

        public int WorkflowUserGroupId { get; set; }
        public WorkFlowUserGroup WorkflowUserGroup { get; set; }

        public bool Active { get; set; }
    }
}
