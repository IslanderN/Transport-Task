using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CommonClasses;

namespace GeneticAlgorithm
{
    public static class UnitGenerator
    {
        private static Random random;
        static UnitGenerator()
        {
            random = new Random();
        }
        public static Unit CreateNewUnit(List<Manufacture> manufactures)
        {
            var needsSum = manufactures.FirstOrDefault().ClientsDeliveryCost.Sum(c => c.Key.Needs);
            Unit unit = new Unit();

            bool isUnitSurvived = false;
            while (!isUnitSurvived)
            {
                unit = Generate(manufactures);
                isUnitSurvived = unit.IsUnitSurvive();
            }

            return unit;
        }
        private static Unit Generate(List<Manufacture> manufactures)
        {
            Unit unit = new Unit();
            foreach (var m in manufactures)
            {
                double result = random.NextDouble();
                int isOrganisated;
                if (m.ProbabilityOfOrganisate > result)
                {
                    isOrganisated = 1;
                }
                else
                {
                    isOrganisated = 0;
                }
                unit.Organisated.Add(m, isOrganisated);
            }
            return unit;
        }

        public static List<Unit> GenerateMany(List<Manufacture> manufactures, int number)
        {
            List<Unit> listOfUnits = new List<Unit>();
            for(int i = 0; i < number; i++)
            {
                listOfUnits.Add(CreateNewUnit(manufactures));
            }

            return listOfUnits;
        }
    }
}
