using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonClasses;

namespace ExpensiveAlgorithm
{
    public class Expensive
    {
        public Expensive()
        {
           // Console.WriteLine("HEllo world");
        }

        public List<ExpensiveManufacturer> SetManufacturePriority(List<Manufacture> manufactures)
        {
            Dictionary<ExpensiveManufacturer, int> manufacturerPriority = new Dictionary<ExpensiveManufacturer, int>();

            foreach(var manufacturer in manufactures)
            {
                int cost = manufacturer.OrganisationCost;
                cost += manufacturer.ClientsDeliveryCost.Sum(c => c.Value);
                ExpensiveManufacturer newManucturer = new ExpensiveManufacturer(manufacturer);
                newManucturer.CapacityFree = newManucturer.ProductionCapacity;

                manufacturerPriority.Add(newManucturer, cost);
            }
           // var resultManufacturerds = manufacturerPriority.OrderBy(a => a.Value).Select(a => a.Value).ToList();

            var resultManufacturers = manufacturerPriority.OrderBy(a => a.Value).Select(a => a.Key).ToList();

            return resultManufacturers;
        }

        public int Solver(List<Manufacture> manufactures, List<Client> clients)
        {
            //FileInput f = new FileInput("input.txt");
            //List<Client> clients;
            //List<Manufacture> manufactures;
            List<ExpensiveManufacturer> expensiveManufacturers;
            int clientNeeds;
            int manufacturerNeeds = 0;

            //f.ReadFromFile(out clients, out manufactures);

           

            expensiveManufacturers = SetManufacturePriority(manufactures);

            clientNeeds = clients.Sum(a => a.Needs);


            int i = 0;
            while (manufacturerNeeds <= clientNeeds && i < expensiveManufacturers.Count())
            {
                //Console.WriteLine(manufacturerNeeds);
                manufacturerNeeds += expensiveManufacturers[i].ProductionCapacity;
                expensiveManufacturers[i].IsOrganisated = 1;
                i++;
            }

            int sum = 0;
            foreach (var el in expensiveManufacturers)
            {
               
                sum += el.ProductionCapacity;
            }
            expensiveManufacturers = expensiveManufacturers.Where(a => a.IsOrganisated == 1).ToList();
            TransportTask transportTask = new TransportTask(expensiveManufacturers.Cast<Manufacture>().ToList());
            int cost = transportTask.CalculateCost();
            return cost;
        }
    }
}
