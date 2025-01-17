using System.ComponentModel;

namespace EmployeesManagement.Models
{
    public class City
    {
        public int Id { get; set; }


        [DisplayName("City Code")]
        public string Code { get; set; }


        [DisplayName("City Name")]
        public string Name { get; set; }


        [DisplayName("Country Name")]
        public int CountryId { get; set; }

        public Country Country { get; set; }
    }
}
