using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonClasses
{
    public class GenerateInput
    {
        static Random random = new Random();

        public static void Generate(out List<Client> clients, out List<Manufacture> manufactures)
        {
            Generate(out clients, out manufactures, random.Next(3, 10));
        }

        public static void Generate(out List<Client> clients, out List<Manufacture> manufactures, int numberOfClient)
        {
            clients = new List<Client>();
            manufactures = new List<Manufacture>();
            

            int nummberOfManufactures = random.Next(numberOfClient, numberOfClient + 10);

            int sumOfNeeds = 0;
            int sumOfProductionCapacity = 0;

            for (int i = 0; i < numberOfClient; i++)
            {
                var client = new Client
                {
                    Needs = random.Next(1, 21)
                };
                clients.Add(client);
                sumOfNeeds += client.Needs;
            }

            for (int i = 0; i < nummberOfManufactures; i++)
            {
                var manufacture = new Manufacture
                {
                    OrganisationCost = random.Next(1, 21),
                    ProductionCapacity = random.Next(1, 21)
                };
                sumOfProductionCapacity += manufacture.ProductionCapacity;
                manufactures.Add(manufacture);
            }
            int desiredDifference = (int)(sumOfNeeds / 3.0);
            while (sumOfProductionCapacity <= sumOfNeeds + desiredDifference)
            {
                var manufacture = new Manufacture
                {
                    OrganisationCost = random.Next(1, 21),
                    ProductionCapacity = random.Next(1, 21)
                };
                sumOfProductionCapacity += manufacture.ProductionCapacity;
                manufactures.Add(manufacture);
            }

            for (int i = 0; i < manufactures.Count ; i++)
            {
                var manufacture = manufactures[i];
                for(int j = 0; j < clients.Count; j++)
                {
                    int cost = random.Next(1, 15);
                    var client = clients[j];
                    client.ManufactureDeliveryCost.Add(manufacture, cost);
                    manufacture.ClientsDeliveryCost.Add(client, cost);
                }
            }
        }
    }
}
