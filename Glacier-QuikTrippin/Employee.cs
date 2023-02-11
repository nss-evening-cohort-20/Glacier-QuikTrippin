using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glacier_QuikTrippin
{
    internal class Employee : IEmployee
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Role { get; set; }
        public double Rate { get; set; }
        public double Sales { get; set; }

        public Employee(int id, string name, string role, double rate, double sales) 
        {
            Id= id;
            Name= name;
            Role= role;
            Rate= rate;
            Sales= sales;
        }

    }
}
