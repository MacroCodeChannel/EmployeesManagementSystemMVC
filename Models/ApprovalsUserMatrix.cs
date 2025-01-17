using System.ComponentModel;

namespace EmployeesManagement.Models
{
    public class ApprovalsUserMatrix :UserActivity
    {
        public int Id { get; set; }


        [DisplayName("User Name")]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        [DisplayName("Document Type")]
        public int DocumentTypeId { get; set; }
        public SystemCodeDetail DocumentType { get; set; }


        [DisplayName("Workflow User Group")]
        public int WorkflowUserGroupId { get; set; }
        public WorkFlowUserGroup WorkflowUserGroup { get; set; }


        [DisplayName("Is Active")]
        public bool Active { get; set; }
    }
}
