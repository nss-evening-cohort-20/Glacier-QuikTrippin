using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glacier_QuikTrippin
{
    internal class Employee : IEmployee
    {
        public string Name => throw new NotImplementedException();

        public int Id => throw new NotImplementedException();

        public double rate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double sales { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string role => throw new NotImplementedException();

        string IEmployee.role { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Add(IEmployee employee)
        {
            throw new NotImplementedException();
        }

        public void Delete(IEmployee employee)
        {
            throw new NotImplementedException();
        }

        public void Update(IEmployee employee)
        {
            throw new NotImplementedException();
        }
    }
}
