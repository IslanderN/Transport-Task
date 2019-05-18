using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CommonClasses;
using GeneticAlgorithm;

namespace Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.ReadKey();
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
