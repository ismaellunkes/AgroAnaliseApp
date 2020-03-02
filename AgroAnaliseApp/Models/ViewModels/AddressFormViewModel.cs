using System.Collections.Generic;

namespace AgroAnaliseApp.Models.ViewModels
{
    public class AddressFormViewModel
    {
        public Address Address { get; set; }
        public ICollection<City>Citys { get; set; }
    }
}
