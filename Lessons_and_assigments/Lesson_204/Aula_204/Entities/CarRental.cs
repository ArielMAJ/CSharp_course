using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_204.Entities
{
    internal class CarRental
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public Vehicle Vehicle { get; set; }
        public Invoice Invoice { get; set; }

        public CarRental(DateTime start, DateTime end, Vehicle vehicle)
        {
            Start = start;
            End = end;
            Vehicle = vehicle;
            Invoice = null;
        }
    }
}
