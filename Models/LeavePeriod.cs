namespace EmployeesManagement.Models
{
    public class LeavePeriod : UserActivity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public bool Closed { get; set; }

        public bool Locked { get; set; }
    }
}
