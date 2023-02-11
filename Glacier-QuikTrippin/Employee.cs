using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glacier_QuikTrippin
{
    internal class Employee : IEmployee
    {
        static int _id = 100;
        public string Name { get; set; }
        public int Id { get; set; }
        public int StoreId { get; set; }
        public string Role { get; set; }
        public double Rate { get; set; }
        public double Sales { get; set; }

        public Employee(int storeId, string name, string role, double rate, double sales) 
        {
            Id = _id++;
            StoreId= storeId;
            Name= name;
            Role= role;
            Rate= rate;
            Sales= sales;
        }

        public override string ToString()
        {
            return $"Employee Id: {Id} | " +
                $"Store Id: {StoreId} | " +
                $"Name: {Name} | " +
                $"Role: {Role} | " +
                $"Rate: {Rate.ToString("C", new CultureInfo("en-US"))} /Hr | " +
                $"Sales: {Sales.ToString("C", new CultureInfo("en-US"))}";
        }

    }
}
