﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonClasses;

namespace ExpensiveAlgorithm
{
    public class ExpensiveManufacturer : Manufacture
    {
        //public int Id { get; private set; }

        public int CapacityFree { get; set; }
        public int IsOrganisated { get; set; }

        public ExpensiveManufacturer() : base() { }
        public ExpensiveManufacturer(Manufacture manufacture) : base()
        {
            this.id = manufacture.Id;

            // this.IsOrganisated = manufacture.IsOrganisated;
            this.OrganisationCost = manufacture.OrganisationCost;
            this.ProbabilityOfOrganisate = manufacture.ProbabilityOfOrganisate;
            this.ProductionCapacity = manufacture.ProductionCapacity;
            this.CapacityFree = manufacture.ProductionCapacity;
            this.ClientsDeliveryCost = manufacture.ClientsDeliveryCost;
        }



    }
}
