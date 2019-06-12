using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CommonClasses;

namespace GeneticAlgorithm
{
    public class Executing
    {
        const int POPULATION_SIZE = 20;
        const int TIMES_DIFF_ZERO = 20;

        public static Unit Solve(List<Manufacture> manufactures)
        {
            manufactures = ProbabilityComputerer.Compute(manufactures);

            var population = UnitGenerator.GenerateMany(manufactures, POPULATION_SIZE);


            var newPopulation = IncubationNewUnit.CreateNewPopulation(population);
            int timeWhenDifferenceIsZero = 0;

            while (timeWhenDifferenceIsZero < TIMES_DIFF_ZERO)
            {
                population = newPopulation;
                newPopulation = IncubationNewUnit.CreateNewPopulation(population);
                if (DifferenceBetweenPopulation(population, newPopulation) == 0)
                {
                    timeWhenDifferenceIsZero++;
                }
                else
                {
                    timeWhenDifferenceIsZero = 0;
                }
            }
            return newPopulation.OrderBy(u => u.Adaptability).FirstOrDefault();
        }

        private static int DifferenceBetweenPopulation(List<Unit> firstPopulation, List<Unit> secondPopulation)
        {
            int difference = 0;
            foreach (var unit in firstPopulation)
            {
                if (!secondPopulation.Contains(unit, new UnitEqualityComparer()))
                {
                    difference++;
                }
            }
            return difference;
        }

    }
}
