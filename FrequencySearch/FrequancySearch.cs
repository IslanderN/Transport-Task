using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CommonClasses;

namespace FrequencySearch
{
    public class FrequancySearch
    {
        public static Unit FindMostFrequance(List<Manufacture> manufactures)
        {
            List<Unit> setOfUnits = UnitGenerator.GenerateMany(manufactures, 100);
            Unit result = new Unit();
            result.Organisated = new Dictionary<Manufacture, int>(setOfUnits[0].Organisated);

            ///set is organisated to 0
            ///clear values
            foreach(var key in result.Organisated.Keys.ToList())
            {
                result.Organisated[key] = 0;
            }


            setOfUnits = setOfUnits.OrderBy(u => u.Adaptability).ToList();
            setOfUnits = setOfUnits.Take(30).ToList();


            Dictionary<Manufacture, int> frequancyOfManufactureInSet = new Dictionary<Manufacture, int>(result.Organisated);
            foreach(var unit in setOfUnits)
            {
                foreach(var manufacture in unit.Organisated)
                {
                    frequancyOfManufactureInSet[manufacture.Key] += manufacture.Value;
                }
            }

            var sortedFrequancy = frequancyOfManufactureInSet.OrderByDescending(m => m.Value);

            foreach(var manufacture in sortedFrequancy)
            {
                if (!result.IsUnitSurvive())
                {
                    result.Organisated[manufacture.Key] = 1;
                }
                else
                {
                    break;
                }
            }

            return result;
        }
    }
}
