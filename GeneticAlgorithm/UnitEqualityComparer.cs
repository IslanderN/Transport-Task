using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CommonClasses;

namespace GeneticAlgorithm
{
    public class UnitEqualityComparer : IEqualityComparer<Unit>
    {
        public bool Equals(Unit x, Unit y)
        {
            foreach(var m in x.Organisated)
            {
                if (y.Organisated[m.Key] != m.Value) return false;
            }
            return true;
        }

        public int GetHashCode(Unit obj)
        {
            string binary = "";
            foreach(var m in obj.Organisated)
            {
                binary += m.Value.ToString();
            }
            return Convert.ToInt32(binary, 2);
        }
    }
}
