using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CommonClasses;
using GeneticAlgorithm;
using ExpensiveAlgorithm;
using FrequencySearch;
using System.Threading;

namespace Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            //Expensive();
            //Genetic();
            while (true)
            {
                List<Client> clients;
                List<Manufacture> manufactures;

                // f.ReadFromFile(out clients, out manufactures);
                GenerateInput.Generate(out clients, out manufactures);
                Expensive(manufactures, clients);
                var result = Frequancy(manufactures);
                Console.WriteLine("Frequancy: " + result.Adaptability);
                var result2 = Genetic(manufactures);
                Console.WriteLine("Genertic: " + result2.Adaptability);

                var result3 = Expensive(manufactures, clients);
                Console.WriteLine("Greedy: " + result3);

                Console.WriteLine("------------------------");
                Thread.Sleep(3000);
            }

            Console.ReadKey();
        }

        static int Expensive(List<Manufacture> manufactures, List<Client> clients)
        {
            Expensive algorithm = new Expensive();
            return algorithm.Solver(manufactures, clients);

        }

        static Unit Genetic(List<Manufacture> manufactures)
        {
           // FileInput f = new FileInput("test.txt");
            

            return Executing.Solve(manufactures);
        }

        static Unit Frequancy(List<Manufacture> manufactures)
        {
            manufactures = ProbabilityComputerer.Compute(manufactures);

            return FrequancySearch.FindMostFrequance(manufactures);
        }
    }
}
