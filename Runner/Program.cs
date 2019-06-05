using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CommonClasses;
using GeneticAlgorithm;
using ExpensiveAlgorithm;

namespace Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            Expensive();

            Console.ReadKey();
        }

        static void Expensive()
        {
            FileInput f = new FileInput("input.txt");
            List<Client> clients;
            List<Manufacture> manufactures;
            List<ExpensiveManufacturer> expensiveManufacturers;
            int clientNeeds;
            int manufacturerNeeds = 0;

            f.ReadFromFile(out clients, out manufactures);

            Expensive algorithm = new Expensive();
            
            expensiveManufacturers = algorithm.SetManufacturePriority(manufactures);

            clientNeeds = clients.Sum(a => a.Needs);

            int i = 0;
            while (manufacturerNeeds <= clientNeeds && i<expensiveManufacturers.Count())
            {
                Console.WriteLine(manufacturerNeeds);
                manufacturerNeeds += expensiveManufacturers[i].ProductionCapacity;
                expensiveManufacturers[i].IsOrganisated = 1;
                i++;
            }

            int sum = 0;
            foreach(var el in expensiveManufacturers)
            {
                Console.WriteLine(el.ProductionCapacity.ToString());
                sum += el.ProductionCapacity;
            }
            expensiveManufacturers = expensiveManufacturers.Where(a => a.IsOrganisated == 1).ToList();
            TransportTask transportTask = new TransportTask(expensiveManufacturers.Cast<Manufacture>().ToList());
            int cost = transportTask.CalculateCost();
            Console.WriteLine(sum);
            Console.WriteLine(clientNeeds);

        }

        static void Genetic()
        {
            FileInput f = new FileInput("test.txt");
            List<Client> clients;
            List<Manufacture> manufactures;

            f.ReadFromFile(out clients, out manufactures);

            manufactures = ProbabilityComputerer.Compute(manufactures);
        }
    }
}
