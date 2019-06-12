using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonClasses
{
    public class Manufacture
    {
        static int staticId = 0;

        protected int id = -1;
        public int Id { get
            {
                if (id == -1)
                {
                    id = staticId++;
                }
                return id;
            }
        }

        public int ProductionCapacity { get; set; }
        public int OrganisationCost { get; set; }

        public Dictionary<Client, int> ClientsDeliveryCost { get; set; }

        public double ProbabilityOfOrganisate { get; set; }

        public Manufacture()
        {
            ClientsDeliveryCost = new Dictionary<Client, int>();
            _ = Id;
        }
    }
}
