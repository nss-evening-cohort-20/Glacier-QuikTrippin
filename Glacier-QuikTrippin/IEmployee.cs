using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glacier_QuikTrippin
{
    internal interface IEmployee
    {
        string Name { get; }
        int Id { get; }

        string role { get; set; }
        double rate { get; set; }
        double sales { get; set; }

        void Add(IEmployee employee);
        void Update(IEmployee employee);
        void Delete(IEmployee employee);
    }
}