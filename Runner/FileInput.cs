using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using CommonClasses;

namespace Runner
{
    class FileInput
    {
        private string filename;
        public FileInput(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException($"File {filename} wasn't found");
            }
            this.filename = filename;
        }

        public void ReadFromFile(out List<Client> clients, out List<Manufacture> manufactures)
        {
            int numberOfManufactures;
            int numberOfClient;

            clients = new List<Client>();
            manufactures = new List<Manufacture>();

            using(StreamReader sr = new StreamReader(filename))
            {
                var numbers = SplitString(sr);
                numberOfManufactures = int.Parse(numbers[0]);
                numberOfClient = int.Parse(numbers[1]);

                var powers = SplitString(sr);
                var orgCost = SplitString(sr);
                for(int i = 0; i < numberOfManufactures; i++)
                {
                    var manufacture = new Manufacture
                    {
                        ProductionCapacity = int.Parse(powers[i]),
                        OrganisationCost = int.Parse(orgCost[i])
                    };
                    manufactures.Add(manufacture);
                }
                var needs = SplitString(sr);
                foreach(var n in needs)
                {
                    var client = new Client
                    {
                        Needs = int.Parse(n)
                    };
                    clients.Add(client);
                }

                for (int i = 0; i < numberOfClient * numberOfManufactures; i++)
                {
                    var deliverCosts = SplitString(sr);

                    int manufactureIndex = int.Parse(deliverCosts[0]) - 1;
                    int clientIndex = int.Parse(deliverCosts[1]) - 1;
                    int cost = int.Parse(deliverCosts[2]);

                    var client = clients[clientIndex];
                    var manufacure = manufactures[manufactureIndex];

                    client.ManufactureDeliveryCost.Add(manufacure, cost);
                    manufacure.ClientsDeliveryCost.Add(client, cost);
                }

            }
        }
        private string[] SplitString(StreamReader sr)
        {
            var line = sr.ReadLine();
            return line.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
