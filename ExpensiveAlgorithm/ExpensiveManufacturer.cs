using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonClasses;

namespace ExpensiveAlgorithm
{
   public class ExpensiveManufacturer:Manufacture
    {
        public int CapacityFree { get; set; }

        public ExpensiveManufacturer():base(){}
        public ExpensiveManufacturer(Manufacture manufacture) : base() {
            this.IsOrganisated = manufacture.IsOrganisated;
            this.OrganisationCost = manufacture.OrganisationCost;
            this.ProbabilityOfOrganisate = manufacture.ProbabilityOfOrganisate;
            this.ProductionCapacity = manufacture.ProductionCapacity;
            this.CapacityFree = manufacture.ProductionCapacity;
            this.ClientsDeliveryCost = manufacture.ClientsDeliveryCost;
        }



    }
}
