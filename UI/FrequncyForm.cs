using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    using CommonClasses;
    using FrequencySearch;
    using GeneticAlgorithm;


    public partial class FrequncyForm : Form
    {
        private int clientCount;
        private int taskTimesCount;

        public FrequncyForm()
        {
            InitializeComponent();
        }

        private void DrawGraph_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                this.Chart.Series["Frequancy"].Points.Clear();
                List<Client> clients = new List<Client>();
                List<Manufacture> manufactures = new List<Manufacture>();

                GenerateInput.Generate(out clients, out manufactures);
                manufactures = ProbabilityComputerer.Compute(manufactures);

                List<int> timesOfTask = new List<int>();

                for (int i = 10; i <= 100; i+=10)
                {
                    timesOfTask.Clear();
                    for (int j = 0; j < taskTimesCount; j++)
                    {
                        var unit = FrequancySearch.FindMostFrequance(manufactures, 100, i);
                        timesOfTask.Add(unit.Adaptability);
                    }
                    this.Chart.Series["Frequancy"].Points.AddXY(i, timesOfTask.Average());
                }
            }
            else
            {
                MessageBox.Show("Перевірте введені дані");
            }
        }

        private bool Validate()
        {
            if (!int.TryParse(this.textBox1.Text, out clientCount)) return false;
            if (!int.TryParse(this.textBox2.Text, out taskTimesCount)) return false;

            return true;
        }

    }
}
