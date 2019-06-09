using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonClasses
{
    public class TransportTask
    {
        private List<Route> routes = new List<Route>();
        private List<Manufacture> manufactures;
        private List<int> a = new List<int>();
        private List<int> b = new List<int>();
        private int[,] matrix;
        private int n, m; //count clients count manufacturer

        public TransportTask(List<Manufacture> manufactures)
        {
            this.manufactures = manufactures;
        }
        public int CalculateCost()
        {
            int clientNeeds;
            int manufacturersCapacity;
            int cost = 0;
            bool differenceCapacity = false;
            const int M = int.MaxValue;
            clientNeeds = manufactures.FirstOrDefault().ClientsDeliveryCost.Sum(c => c.Key.Needs);
            manufacturersCapacity = manufactures.Sum(c => c.ProductionCapacity);
            n = manufactures.FirstOrDefault().ClientsDeliveryCost.Count();
            m = manufactures.Count();
            b = manufactures.Select(c => c.ProductionCapacity).ToList();
            a = manufactures.FirstOrDefault().ClientsDeliveryCost.Select(c => c.Key.Needs).ToList();
            if (clientNeeds < manufacturersCapacity)
            {
                n++;
                differenceCapacity = true;
                a.Add(manufacturersCapacity - clientNeeds);   
            }

           //initialise matrix
            matrix = new int[n,m];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (differenceCapacity && j == n - 1)
                    {
                        matrix[j, i] = int.MaxValue-100000;
                    }
                    else
                    {
                        matrix[j, i] = manufactures[i].ClientsDeliveryCost.ElementAt(j).Value;
                    }
                }
            }
           for(int k=0;k<n+m-1;k++)
            {
                FindMin();
            }

            
           
            //Console.WriteLine(matrix[4, 3]);


            return cost = CalculteCostForFindingRoutes();
        }
        private void FindMin()
        {
            int indexManufacturer = 0;
            int indexClient = 0;
            int min = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                        indexManufacturer = j;
                        indexClient = i;
                    }
                }
            }
            int value =0;
            if(a[indexClient] > b[indexManufacturer])
            {
                value = b[indexManufacturer];
                a[indexClient] -= b[indexManufacturer];
                b[indexManufacturer] = 0;
                this.DeleteRowOrColl(coll:indexManufacturer);
            }
            else
            {
                value = a[indexClient];
                b[indexManufacturer] -= a[indexClient];
                a[indexClient] = 0;
                this.DeleteRowOrColl(row: indexClient);
            }
            var client = manufactures.FirstOrDefault().ClientsDeliveryCost.Count > indexClient ? manufactures.FirstOrDefault().ClientsDeliveryCost.ElementAt(indexClient).Key : null;
            Route route = new Route {
                Manufacture = manufactures[indexManufacturer],
                Client = client,
                Value = value
            };

            routes.Add(route);
        }
        private void DeleteRowOrColl(int row = -1,int coll = -1)
        {
            if(row != -1)
            {
                for(int j = 0; j < m; j++)
                {
                    matrix[row, j] = int.MaxValue;
                }
            }
            if(coll != -1)
            {
                for(int i = 0; i < n; i++)
                {
                    matrix[i, coll] = int.MaxValue;
                }
            }
        }
        private int CalculteCostForFindingRoutes()
        {
            int cost = 0;
            foreach(var route in routes)
            {
                


                if (route.Client != null)
                {
                    cost += route.Value * route.Manufacture.ClientsDeliveryCost[route.Client];
                }
            }
            foreach(var manufacturer in manufactures)
            {
                cost += manufacturer.OrganisationCost;
            }


            return cost;
        }
    }
}
