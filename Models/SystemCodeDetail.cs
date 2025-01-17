using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EmployeesManagement.Models
{
    public class SystemCodeDetail: UserActivity
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("System Code")]

        public int SystemCodeId { get; set; }

        public SystemCode SystemCode { get; set; }

        [DisplayName("Code")]
        public string Code { get; set; }



        [DisplayName("Description")]
        public string Description { get; set; }


        [DisplayName("Order No")]
        public int? OrderNo { get; set; }
    }
}
