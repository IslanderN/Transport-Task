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
    }
}
