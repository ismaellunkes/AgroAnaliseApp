
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgroAnaliseApp.Models
{
    public class City
    {
        
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [Display(Name = "Cidade")]
        public string Name { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [Display(Name = "UF")]
        public string UF { get; set; }

        public City() { }
        public City(int id, string name, string uf)
        {
            Id = id;
            Name = name;
            UF = uf;
        }
    }
}
