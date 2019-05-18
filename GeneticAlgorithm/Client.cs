using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm
{
    public class Client
    {
        public int Needs { get; set; }

        public Dictionary<Manufacture, int> ManufactureDeliveryCost { get; set; }

        public Client()
        {
            ManufactureDeliveryCost = new Dictionary<Manufacture, int>();
        }
    }
}
