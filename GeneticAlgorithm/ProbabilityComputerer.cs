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
           
            

            foreach(var m in manufactures)
            {
                var deliverSum = m.ClientsDeliveryCost.Sum(c => c.Value);
                var clientNeedsSum = m.ClientsDeliveryCost.Sum(c => c.Key.Needs);

                double probably = 0;

                probably += ((double)m.ProductionCapacity) / (3.0 * powersSum);
                probably += ((double)(organisationCostSum - m.OrganisationCost)) / (3.0 * organisationCostSum);

                double deliverPart = 0;
                foreach(var c in m.ClientsDeliveryCost)
                {
                    deliverPart += ((double)c.Key.Needs) / (2.0 * clientNeedsSum);

                    deliverPart += ((double)(deliverSum - c.Value)) / (2.0 * deliverSum);
                }

                probably += ((double)deliverPart) / (3.0 * manufactures.FirstOrDefault().ClientsDeliveryCost.Count());

                m.ProbabilityOfOrganisate = probably;
            }

            return manufactures;
        }

    }
}
