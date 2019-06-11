using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace UI
{
    class GenerateDataPoint
    {
        public List<DoublePoint> GeneticData { get; set; }
        public List<DoublePoint> GreedyData { get; set; }
        public List<DoublePoint> FrequancyData { get; set; }

        public GenerateDataPoint()
        {
            GeneticData = new List<DoublePoint>();
            GreedyData = new List<DoublePoint>();
            FrequancyData = new List<DoublePoint>();
        }
    }
    
    class DoublePoint
    {
        public double X { get; set; }
        public double Y { get; set; }
        public DoublePoint(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}
