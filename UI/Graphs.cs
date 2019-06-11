using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

using CommonClasses;
using GeneticAlgorithm;
using FrequencySearch;
using ExpensiveAlgorithm;
using System.Windows.Forms.DataVisualization.Charting;

namespace UI
{
    public partial class Graphs : Form
    {
        private int stepOfSizeGraph;
        private int firstSize;
        private int lastSize;

        private int numberOfTestForOneStep;
        private CancellationTokenSource cts;
        private CancellationToken cancellationToken;


        string geneticName = "Genetic";
        string greedyName = "Greedy";
        string frequancyName = "Frequancy";

        public Graphs()
        {
            //Image image = 

            InitializeComponent();

            this.DrawSizeGraphCancel.Enabled = false;
            this.LoadingBox.Hide();
            DrawLoading();

            //stepOfSizeGraph = 1;
            //firstSize = 3;
            //lastSize = 200;
            //numberOfTestForOneStep = 2;

            //GenerateGraph();

            //var series = this.SizeGraph.Series;
            //series.Where(s=>s.)
        }

        private async void DrawSizeGraph_Click(object sender, EventArgs e)
        {
            if (TryValidateInput())
            {
                cts = new CancellationTokenSource();
                cancellationToken = cts.Token;
                this.DrawSizeGraph.Enabled = false;
                this.DrawSizeGraphCancel.Enabled = true;

                this.LoadingBox.Show();
                //var generateTask = Task<GenerateDataPoint>.Run(() => GenerateGraph());
                //var task = await Task.Factory.StartNew<GenerateDataPoint>(() => GenerateGraph());
                GenerateDataPoint dataPoint = null;
                
                    dataPoint = await Task.Factory.StartNew<GenerateDataPoint>(() => GenerateGraph(cancellationToken), cancellationToken);

                    if (dataPoint != null)
                    {
                        AfterGenerateWorkComplete(dataPoint);
                    }
                
                //task.ContinueWith(async(dataPoint) => AfterGenerateWorkComplete(dataPoint.Result));
                LoadingBox.Hide();
                this.DrawSizeGraphCancel.Enabled = false;
                this.DrawSizeGraph.Enabled = true;
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
        private void DrawSizeGraphCancel_Click(object sender, EventArgs e)
        {
            cts.Cancel();

            this.DrawSizeGraphCancel.Enabled = false;
            this.DrawSizeGraph.Enabled = true;
        }

        private void DrawLoading()
        {
            var graphics = LoadingBox.CreateGraphics();
            // Create font and brush.
            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            // Create point for upper-left corner of drawing.
            float x = 150.0F;
            float y = 50.0F;

            // Set format of string.
            StringFormat drawFormat = new StringFormat();
            drawFormat.FormatFlags = StringFormatFlags.DirectionVertical;

            // Draw string to screen.
            graphics.DrawString("Loading", drawFont, drawBrush, new PointF(x, y));

        }

        private bool TryValidateInput()
        {
            bool incorrectInput = false;

            if (!int.TryParse(this.FirstInputTextBox.Text, out firstSize)) incorrectInput = true;
            else
            {
                if (firstSize <= 0) incorrectInput = true;
            }

            if (!int.TryParse(this.LastInputTextBox.Text, out lastSize)) incorrectInput = true;
            else
            {
                if (lastSize <= 0) incorrectInput = true;
            }

            if (!int.TryParse(this.StepInputTextBox.Text, out stepOfSizeGraph)) incorrectInput = true;
            else
            {
                if (stepOfSizeGraph <= 0) incorrectInput = true;
            }

            if (!int.TryParse(this.NumberOfTestInputTextBox.Text, out numberOfTestForOneStep)) incorrectInput = true;
            else
            {
                if (numberOfTestForOneStep <= 0) incorrectInput = true;
            }

            return !incorrectInput;
        }

        private void AfterGenerateWorkComplete(GenerateDataPoint dataPoint)
        {

            this.SizeGraph.Series[geneticName].Points.Clear();
            this.SizeGraph.Series[greedyName].Points.Clear();
            this.SizeGraph.Series[frequancyName].Points.Clear();
            foreach (var p in dataPoint.GeneticData)
            {
                this.SizeGraph.Series[geneticName].Points.AddXY(p.X, p.Y);
            }
            foreach (var p in dataPoint.GreedyData)
            {
                this.SizeGraph.Series[greedyName].Points.AddXY(p.X, p.Y);
            }
            foreach (var p in dataPoint.FrequancyData)
            {
                this.SizeGraph.Series[frequancyName].Points.AddXY(p.X, p.Y);
            }
            //this.SizeGraph.Series[greedyName].Points.AddXY(clientCount, greedyResult.Average());
            //this.SizeGraph.Series[frequancyName].Points.AddXY(clientCount, frequancyResult.Average());
            
        }

        #region GenereteSizeGraph
        private GenerateDataPoint GenerateGraph(CancellationToken token)
        {
            GenerateDataPoint dataPoint = new GenerateDataPoint();
            for (int i = firstSize; i <= lastSize; i += stepOfSizeGraph)
            {
                try
                {
                    token.ThrowIfCancellationRequested();
                }
                catch
                {
                    return null;
                }
                PointXYGenerate(dataPoint, i);
            }
            return dataPoint;
        }


        private void PointXYGenerate(GenerateDataPoint dataPoint, int clientCount)
        {
            List<Manufacture> manufactures;
            List<Client> clients;
            GenerateInput.Generate(out clients, out manufactures, clientCount);

            List<int> geneticResult = new List<int>();
            List<int> greedyResult = new List<int>();
            List<int> frequancyResult = new List<int>();

            for (int j = 0; j < numberOfTestForOneStep; j++)
            {
                geneticResult.Add(GenerateGenetic(manufactures));
                greedyResult.Add(GenerateGreedy(manufactures, clients));
                frequancyResult.Add(GenerateFrequancy(manufactures));
            }
            dataPoint.GeneticData.Add(new DoublePoint(clientCount, geneticResult.Average()));
            dataPoint.GreedyData.Add(new DoublePoint(clientCount, greedyResult.Average()));
            dataPoint.FrequancyData.Add(new DoublePoint(clientCount, frequancyResult.Average()));
            //this.SizeGraph.Series[geneticName].Points.AddXY(clientCount, geneticResult.Average());
            //this.SizeGraph.Series[greedyName].Points.AddXY(clientCount, greedyResult.Average());
            //this.SizeGraph.Series[frequancyName].Points.AddXY(clientCount, frequancyResult.Average());

        }


        private int GenerateGenetic(List<Manufacture> manufactures)
        {
            var result = Executing.Solve(manufactures);
            return result.Adaptability;
        }
        private int GenerateGreedy(List<Manufacture> manufactures, List<Client> clients)
        {
            Expensive algorithm = new Expensive();
            return algorithm.Solver(manufactures, clients);

        }
        private int GenerateFrequancy(List<Manufacture> manufactures)
        {
            manufactures = ProbabilityComputerer.Compute(manufactures);

            var result = FrequancySearch.FindMostFrequance(manufactures);
            return result.Adaptability;
        }
        #endregion



    }
}
