using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm
{
    using CommonClasses;

    public class IncubationNewUnit
    {
        static Random random = new Random();
        public static List<Unit> CreateNewPopulation(List<Unit> oldPopulation)
        {
            int sizeOfOldPopulation = oldPopulation.Count;
            var newPopulation = IncubateNewUnits(oldPopulation);

            //Sort and take first 
            newPopulation = newPopulation.OrderBy(u => u.Adaptability).Take(sizeOfOldPopulation).ToList();
            return newPopulation;

        }

        private static List<Unit> IncubateNewUnits(List<Unit> parents)
        {
            foreach (var unit in parents)
            {
                Unit secondParent = parents[random.Next(parents.Count)];
                Unit child = Crossing(unit, secondParent);
                if (child != null)
                {
                    parents.Add(child);
                }
            }
            return parents;
        }

        private static Unit Crossing(Unit firstParent, Unit secondParent)
        {
            int chromosomeLenght = firstParent.Organisated.Count;
            int separetionPoint = random.Next(chromosomeLenght);

            Unit child = new Unit();

            for (int i = 0; i < separetionPoint; i++)
            {
                var gen = firstParent.Organisated.ElementAt(i);

                child.Organisated.Add(gen.Key, gen.Value);
            }
            for (int i = separetionPoint; i < chromosomeLenght; i++)
            {
                var gen = secondParent.Organisated.ElementAt(i);

                child.Organisated.Add(gen.Key, gen.Value);
            }

            if (child.Mutation((1.0 / child.Organisated.Count), random))
            {
                return child;
            }
            else
            {
                return null;
            }

        }
    }
}
