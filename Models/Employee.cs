using System.ComponentModel;

namespace EmployeesManagement.Models
{
    public class Employee: UserActivity
    {
        public int Id { get; set; }
        public string EmpNo { get; set; }


        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Middle Name")]
        public string MiddleName { get; set; }


        [DisplayName("Last Name")]
        public string LastName { get; set; }

        public string FullName => $"{FirstName} {MiddleName} {LastName}";

        [DisplayName("Phone Number")]
        public int PhoneNumber { get; set; }


        [DisplayName("Email Address")]

        public string EmailAddress { get; set; }

        [DisplayName("Country Name")]
        public int? CountryId { get; set; }
        public Country Country { get; set; }
        public DateTime DateOfBirth { get; set; }

        public string Address { get; set; }

        [DisplayName("Department Name")]
        public int? DepartmentId { get; set; }
        public Department Department { get; set; }

        [DisplayName("Designation Name")]
        public int? DesignationId { get; set; }
        public Designation Designation { get; set; }


        [DisplayName("Gender Name")]
        public int? GenderId { get; set; }
        public SystemCodeDetail Gender { get; set; }
    }
}
