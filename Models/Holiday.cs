using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EmployeesManagement.Models
{
    public class Holiday :UserActivity
    {

        [DisplayName("No")]
        public int Id { get; set; }


        [DisplayName("Holiday Name")]
        public string Title { get; set; }



        [DisplayName("Start Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime StartDate { get; set; }


        [DisplayName("End Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime EndDate { get; set; }


        [DisplayName("Description")]
        public string Description { get; set; }
    }
}
