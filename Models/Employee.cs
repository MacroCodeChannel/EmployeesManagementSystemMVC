using EmployeesManagement.Controllers;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

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


        [DisplayName("Employee Photo")]
        public string? Photo { get; set; }


        [DisplayName("Employment Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime? EmploymentDate { get; set; }

        public int? StatusId { get; set; }
        public SystemCodeDetail Status { get; set; }

        [DisplayName("Inactive Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime? InactiveDate { get; set; }
        public int? CauseofInactivityId { get; set; }
        public SystemCodeDetail CauseofInactivity { get; set; }


        [DisplayName("Termination Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime? TerminationDate { get; set; }
        public int? ReasonforterminationId { get; set; }
        public SystemCodeDetail Reasonfortermination { get; set; }


        [DisplayName("Bank Name")]
        public int? BankId { get; set; }
        public Bank Bank { get; set; }

        [DisplayName("Bank Account No")]
        public string? BankAccountNo { get; set; }


        [DisplayName("International Bank Account Number")]
        public string? IBAN { get; set; }


        [DisplayName("SWIFT Code")]
        public string? SWIFTCode { get; set; }

        [DisplayName("N.S.S.F Number")]
        public string? NSSFNO { get; set; }


        [DisplayName("NHIF Number")]
        public string? NHIF { get; set; }


        [DisplayName("Company Email Address")]
        public string? CompanyEmail { get; set; }


        [DisplayName("KRA PIN")]
        public string? KRAPIN { get; set; }


        [DisplayName("Passport No")]
        public string? PassportNo { get; set; }


        [DisplayName("Employment Terms")]
        public int? EmploymentTermsId { get; set; }
        public SystemCodeDetail EmploymentTerms { get; set; }

        [DisplayName("Allocated Leave Balance")]
        public Decimal? AllocatedLeaveDays { get; set; }

        [DisplayName("Leave Balance")]
        public Decimal? LeaveOutStandingBalance { get; set; }

        [DisplayName("Pays Tax")]
        public bool? PaysTax { get; set; }

        [DisplayName("Disability Type")]
        public int? DisabilityId { get; set; }
        public SystemCodeDetail Disability { get; set; }

        public string? DisabilityCertificate { get; set; }

    }
}
