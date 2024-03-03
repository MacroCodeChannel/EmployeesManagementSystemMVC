using AutoMapper;
using EmployeesManagement.Models;
using EmployeesManagement.ViewModels;

namespace EmployeesManagement.Profiles
{
    public class AutomapperProfiles :Profile
    {
        public AutomapperProfiles()
        {
            CreateMap<Employee,EmployeeViewModel>().ReverseMap();   
        }
    }
}
