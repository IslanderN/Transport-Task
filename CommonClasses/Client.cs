using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonClasses
{
    public class Client
    {
        static int staticId = 0;

        public int Id { get; private set; }
        public int Needs { get; set; }

        public Dictionary<Manufacture, int> ManufactureDeliveryCost { get; set; }

        public Client()
        {
            ManufactureDeliveryCost = new Dictionary<Manufacture, int>();

            Id = staticId++;
        }
    }
}
