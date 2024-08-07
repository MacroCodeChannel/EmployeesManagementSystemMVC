using System.ComponentModel;

namespace EmployeesManagement.Models
{
    public class WorkFlowUserGroup
    {
        // Leave Applications//Imprest Application/Salary Advance Request
        public int Id { get; set; }

        public string Code { get; set; }

        public string Description { get; set; }

        public int? DepartmentId { get;set; }
        public Department Department { get; set; }

        public int? DocumentTypeId { get; set; }
        public SystemCodeDetail DocumentType { get; set; }

    }
    public class WorkFlowUserGroupMember
    {
        //Define Workflow Matrix
        public int Id { get; set; }
        public int WorkFlowUserGroupId { get; set; }
        public WorkFlowUserGroup WorkFlowUserGroup { get; set; }

        [DisplayName("Document Sender")]
        public string SenderId { get; set; }
        public ApplicationUser Sender { get; set; }

        [DisplayName("Document Approver")]
        public string ApproverId { get; set; }
        public ApplicationUser Approver { get; set; }
        public int SequenceNo { get; set; }

    }
}
