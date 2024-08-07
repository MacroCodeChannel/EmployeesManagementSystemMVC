using System.ComponentModel;

namespace EmployeesManagement.Models
{
    public class UserActivity
    {

        [DisplayName("Created By")]
        public string? CreatedById { get; set; }

        [DisplayName("Created By")]
        public ApplicationUser CreatedBy { get; set; }

        [DisplayName("Created On")]
        public DateTime CreatedOn { get; set; }

        [DisplayName("Modified By")]
        public string? ModifiedById { get; set; }

        [DisplayName("Modified By")]
        public ApplicationUser ModifiedBy { get; set; }

        [DisplayName("Modified On")]
        public DateTime ModifiedOn { get; set; }
    }
    public class ApprovalActivity: UserActivity
    {

        [DisplayName("Approved By")]
        public string? ApprovedById { get; set; }

        [DisplayName("Approved By")]
        public ApplicationUser ApprovedBy { get; set; }

        [DisplayName("Approved On")]
        public DateTime ApprovedOn { get; set; }
    }
}
