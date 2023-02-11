using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glacier_QuikTrippin
{
    internal interface IEmployee
    {
        string Name { get; set; }
        int Id { get; set; }

        string Role { get; set; }
        double Rate { get; set; }
        double Sales { get; set; }

    }
}