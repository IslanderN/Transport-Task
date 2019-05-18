using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CommonClasses;

namespace GeneticAlgorithm
{
    public class ProbabilityComputerer
    {
        public static List<Manufacture> Compute(List<Manufacture> manufactures)
        {
            var powersSum = manufactures.Sum(m => m.ProductionCapacity);
            var organisationCostSum = manufactures.Sum(m => m.OrganisationCost);
            var deliverSum = manufactures.FirstOrDefault().ClientsDeliveryCost.Sum(c => c.Value);
            var clientNeedsSum = manufactures.FirstOrDefault().ClientsDeliveryCost.Sum(c => c.Key.Needs);

            foreach(var m in manufactures)
            {
                double probably = 0;

                probably += m.ProductionCapacity / (3.0 * powersSum);
                probably += (organisationCostSum - m.OrganisationCost) / (3.0 * organisationCostSum);

                double deliverPart = 0;
                foreach(var c in m.ClientsDeliveryCost)
                {
                    deliverPart += c.Key.Needs / (2.0 * clientNeedsSum);

                    deliverPart += (deliverSum - c.Value) / (2.0 * deliverSum);
                }

                probably += deliverPart / (3.0 * manufactures.FirstOrDefault().ClientsDeliveryCost.Count());

                m.ProbabilityOfOrganisate = probably;
            }

            return manufactures;
        }
    }
}
