
using System.ComponentModel.DataAnnotations;

namespace AgroAnaliseApp.Models
{
    public class Address
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} required")]
        [Display(Name = "Rua/Logradouro:")]
        public string Line1 { get; set; }
        [Required(ErrorMessage = "{0} required")]
        [Display(Name = "Bairro/Distrito/Vila:")]
        public string Line2 { get; set; }
        [Required(ErrorMessage = "{0} required")]
        [Display(Name = "CEP:")]
        public string ZipCode { get; set; }
        [Required(ErrorMessage = "{0} required")]
        [Display(Name = "Coordenadas:")]
        public string Coordinates { get; set; }
        public City City { get; set; }
        public int CityId { get; set; }


        public Address() { }

        public Address(int id, string line1, string zipCode,  City city)
        {
            Id = id;
            Line1 = line1;
            ZipCode = zipCode;
            City = city;
        }

        public Address(int id, string line1, string zipCode, string coordinates, City city)
        {
            Id = id;
            Line1 = line1;
            ZipCode = zipCode;
            Coordinates = coordinates;
            City = city;
        }

        public Address(int id, string line1, string line2, string zipCode, string coordinates, City city)
        {
            Id = id;
            Line1 = line1;
            Line2 = line2;
            ZipCode = zipCode;
            Coordinates = coordinates;
            City = city;
        }
    }
}
