using System.ComponentModel;

namespace EmployeesManagement.Models
{
    public class LeaveAdjustmentEntry : UserActivity
    {
        public int Id { get; set; }

        [DisplayName("Leave Period")]
        public int? LeavePeriodId { get; set; }
        public LeavePeriod LeavePeriod { get; set; }

        [DisplayName("Employee Name")]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        [DisplayName("No of Days")]
        public Decimal NoOfDays { get; set; }

        [DisplayName("Leave Adjustment Date")]
        public DateTime LeaveAdjustmentDate { get; set; }


        public DateTime? LeaveStartDate { get; set; }
        public DateTime? LeaveEndDate { get; set; }

        [DisplayName("Adjustment Description")]
        public string AdjustmentDescription { get; set; }

        [DisplayName("Adjustment Type")]
        public int AdjustmentTypeId { get; set; }
        public SystemCodeDetail AdjustmentType { get; set; }
    }
}
