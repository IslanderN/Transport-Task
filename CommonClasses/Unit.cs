﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonClasses
{
    public class Unit
    {
        public Dictionary<Manufacture, int> Organisated { get; set; }
        public int Adaptability
        {
            get
            {
                return CalculateAdaptability();
            }
        }
        public List<Route> Routes {
            get
            {
                if (privateRoutes == null)
                {
                    CalculateAdaptability();
                }
                return privateRoutes;
            }
        }
        private List<Route> privateRoutes = new List<Route>();

        //private int adaptability = -1;

        public Unit()
        {
            Organisated = new Dictionary<Manufacture, int>();
        }

        private int CalculateAdaptability()
        {
            var selectManufacture = Organisated.Where(m => m.Value != 0).Select(m => m.Key).ToList();
            TransportTask transportTask = new TransportTask(selectManufacture);
            var result = transportTask.CalculateCost();

            privateRoutes = result.ResultRoute;

            return result.Cost;
        }

        public bool IsUnitSurvive()
        {
            int needsSum = Organisated.FirstOrDefault().Key.ClientsDeliveryCost.Sum(c => c.Key.Needs);
            int productionSum = Organisated.Sum(m => m.Value * m.Key.ProductionCapacity);

            return needsSum <= productionSum;
        }

        /// <summary>
        /// Return true if unit survie
        /// </summary>
        /// <param name="probably"></param>
        /// <param name="random"></param>
        /// <returns></returns>
        public bool Mutation(double probably, Random random)
        {
            if (random.NextDouble() > probably)
            {
                return Mutate(random);
            }
            else
            {
                return false;
            }
        }
        private bool Mutate(Random random)
        {
            int genIndex = random.Next(Organisated.Count);
            var gen = Organisated.ElementAt(genIndex);
            Organisated[gen.Key] = gen.Value == 0 ? 1 : 0;

            if (IsUnitSurvive())
            {
                //adaptability = CalculateAdaptability();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
