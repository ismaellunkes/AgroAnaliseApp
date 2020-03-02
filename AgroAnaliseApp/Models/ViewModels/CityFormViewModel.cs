using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgroAnaliseApp.Models.ViewModels
{
    public class CityFormViewModel
    {
        public City City { get; set; }
        public ICollection<State> States { get; set; }
    }
}
