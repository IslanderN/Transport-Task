using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonClasses
{
    public class Route
    {
        public Manufacture Manufacture { get; set; }
        public Client Client { get; set; }
        public int Value { get; set; }
    }
}
