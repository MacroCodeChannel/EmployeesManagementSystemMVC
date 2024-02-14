using EmployeesManagement.Models;
using System.ComponentModel;

namespace EmployeesManagement.ViewModels
{
    public class ProfileViewModel
    {
        public ICollection<SystemProfile> Profiles { get; set; }

        public ICollection<int> RolesRightsIds { get; set; }
        public int[] Ids { get; set; }

        [DisplayName("Role")]   
        public string RoleId { get; set; }

        [DisplayName("System Task")]
        public int TaskId { get; set; }
    }
}
