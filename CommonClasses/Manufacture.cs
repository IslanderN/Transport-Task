using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonClasses
{
    public class Manufacture
    {
        public int ProductionCapacity { get; set; }
        public int OrganisationCost { get; set; }

        public Dictionary<Client, int> ClientsDeliveryCost { get; set; }

        public double ProbabilityOfOrganisate { get; set; }
        public int IsOrganisated { get; set; }

        public Manufacture()
        {
            ClientsDeliveryCost = new Dictionary<Client, int>();
        }
    }
}
