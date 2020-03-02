using AgroAnaliseApp.Services;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgroAnaliseApp.Models
{
    public enum State : int
    {
        SC = 0,
        RS = 1,
        PR = 2,
        SP = 3,
        MT = 4,
        BH = 5
    }

}
