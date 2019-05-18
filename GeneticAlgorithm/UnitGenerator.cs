using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm
{
    public static class UnitGenerator
    {
        private static Random random;
        private static UnitGenerator()
        {
            random = new Random();
        }
        public static List<Manufacture> CreateNewUnit(List<Manufacture> manufactures)
        {
            var needsSum = manufactures.FirstOrDefault().ClientsDeliveryCost.Sum(c => c.Key.Needs);

            bool isUnitSurvived = false;
            while (!isUnitSurvived)
            {
                manufactures = Generate(manufactures);
                int sum = manufactures.Sum(m => m.IsOrganisated * m.ProductionCapacity);
                if (sum < needsSum)
                {
                    isUnitSurvived = false;
                }
                else
                {
                    isUnitSurvived = true;
                }
            }

            return manufactures;
        }
        private static List<Manufacture> Generate(List<Manufacture> manufactures)
        {
            foreach(var m in manufactures)
            {
                double result = random.NextDouble();
                if (m.ProbabilityOfOrganisate > result)
                {
                    m.IsOrganisated = 1;
                }
                else
                {
                    m.IsOrganisated = 0;
                }
            }
            return manufactures;
        }

        public static 
    }
}
