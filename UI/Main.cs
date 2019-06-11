using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonClasses;
using ExpensiveAlgorithm;

namespace UI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.CustomInitializeComponet();

        }
        const int CountElementInMatrix = 3;
        private int realCountManufacurerInMatrix = CountElementInMatrix;
        private int realCountClientInMatrix  = CountElementInMatrix;
        private bool IsRandom = false;
        static Random random = new Random();
        // private int indexTab = 0;

        public void CustomInitializeComponet()
        {
            for (int i = CountElementInMatrix; i< 8; i++) {
                CountManufacturerComboBox.Items.Add(i);
                CountClientComboBox.Items.Add(i);
            }
            this.CountManufacturerComboBox.Text = CountManufacturerComboBox.Items[0].ToString();
            this.CountClientComboBox.Text = this.CountClientComboBox.Items[0].ToString();
    
            this.GenerateManufacturerCosts();
            this.GenerateDataGridView();
        }
        private void GenerateDataGridView(int countManufacturers = CountElementInMatrix, int countClients = CountElementInMatrix)
        {
            this.dataGridView.Columns.Clear();

            if (this.realCountManufacurerInMatrix != countManufacturers)
            {
                countManufacturers = realCountManufacurerInMatrix;
            }

            if (this.realCountClientInMatrix != countClients)
            {
                countClients = realCountClientInMatrix;
            }

            for (int i = 0; i < countManufacturers; i++)
            {
                var column = new DataGridViewColumn();
                column.HeaderText = "B"+(i+1).ToString(); //текст в шапке
                column.Width = 50; //ширина колонки
     
                column.Name = "B" + (i + 1).ToString(); //текстовое имя колонки, его можно использовать вместо обращений по индексу
                column.CellTemplate = new DataGridViewTextBoxCell();
                dataGridView.Columns.Add(column);
               
            }
            var columnClientNeeds = new DataGridViewColumn();
            columnClientNeeds.HeaderText = "Ai"; //текст в шапке
            columnClientNeeds.Width = 50; //ширина колонки

            columnClientNeeds.Name = "ClientNeeds"; //текстовое имя колонки, его можно использовать вместо обращений по индексу
            columnClientNeeds.CellTemplate = new DataGridViewTextBoxCell();
            dataGridView.Columns.Add(columnClientNeeds);
            dataGridView.RowHeadersWidth = 50;
            for (int i = 0; i < countClients; i++)
            {
                //for(int j)
                dataGridView.Rows.Add();
                dataGridView.Rows[i].HeaderCell.Value = "A"+(i+1).ToString();
            }
            dataGridView.Rows.Add();
            dataGridView.Rows[dataGridView.Rows.Count-1].HeaderCell.Value = "Bj";

            if (IsRandom)
            {
                int clienstNeeds = 0;
                int powerNeeds;
                for (int i = 0; i < realCountClientInMatrix; i++)
                {
                    powerNeeds = random.Next(10, 20);
                    clienstNeeds += powerNeeds;
                    this.dataGridView[realCountManufacurerInMatrix, i].Value = powerNeeds;
                }
                int powerManufacurer = 0;
                int averageManufacturePower = clienstNeeds / realCountManufacurerInMatrix;

                for (int i = 0; i < realCountManufacurerInMatrix; i++)
                {
                    for(int j = 0; j < realCountClientInMatrix; j++)
                    {
                        this.dataGridView[i, j].Value = random.Next(10, 30);
                        //this.dataGridView[i, j].Value = random.Next(averageManufacturePower - averageManufacturePower/2, averageManufacturePower + averageManufacturePower);
                    }

                    if (i + 1 == realCountManufacurerInMatrix)
                    {
                        //do
                        //{

                        //powerNeeds = random.Next(10, 40);
                        var randomValue = random.Next((int)(0.5 * averageManufacturePower), averageManufacturePower);
                        var diffValue = clienstNeeds - powerManufacurer;
                        if (diffValue < 0) diffValue *= -1;
                        powerNeeds = diffValue + randomValue;
                        //} while (powerNeeds+powerManufacurer < clienstNeeds);
                    }
                    else
                    {
                        //powerNeeds = random.Next(10, 40);
                        powerNeeds = random.Next((int)(0.75 * averageManufacturePower), 2 * averageManufacturePower);

                        powerManufacurer += powerNeeds;



                    }
                   // powerNeeds = random.Next(10, 30);
                    this.dataGridView[i, realCountClientInMatrix].Value = powerNeeds;
                    //clienstNeeds -= powerNeeds;


                }
                
            }
            this.groupBox.Controls.Add(dataGridView);
            
        }
        private void GenerateManufacturerCosts(int countManufacturers = CountElementInMatrix)
        {

            if (this.realCountManufacurerInMatrix != countManufacturers)
            {
                countManufacturers = realCountManufacurerInMatrix;
            }
            //this.realCountManufacurerInMatrix = CountElementInMatrix;
            this.groupBox.Controls.Clear();
            Label text = new Label();
            text.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            text.Text = "Вартість розміщення виробництва";
            text.Location = new System.Drawing.Point(2, 12);
            text.Name = "LabelTextManufacturerCost";
             text.Size = new System.Drawing.Size(544, 30);
            this.groupBox.Controls.Add(text);
            for (int i = 0; i < countManufacturers; i++)
            {
                Label label = new Label();
                label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                label.Location = new System.Drawing.Point(2 + i * (71 + 10), 42);
                label.Name = "LabelManufacturerCost" + i.ToString();
                label.Text = "B" + (i + 1).ToString()+"=";
                label.Size = new System.Drawing.Size(44, 34);
               this.groupBox.Controls.Add(label);
                TextBox textBox = new TextBox();
                textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                textBox.Location = new System.Drawing.Point(47+i*(71+10), 42);
                textBox.Name = "TextBox" + i.ToString();
                if (IsRandom)
                {
                    textBox.Text = random.Next(10, 50).ToString();
                }
              //  textBox.Text = "B"+(i+1).ToString();
                textBox.Size = new System.Drawing.Size(40, 34);
                textBox.TabIndex = i+1;
                this.groupBox.Controls.Add(textBox);

            }
        }

        private void CountClientComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            int countClient;
            countClient = int.Parse(this.CountClientComboBox.SelectedItem.ToString());
            this.realCountClientInMatrix = countClient;
            this.GenerateDataGridView(countClients:countClient);

        }

        private void CountManufacturerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int countManufacturer;
            countManufacturer = int.Parse(this.CountManufacturerComboBox.SelectedItem.ToString());
            this.realCountManufacurerInMatrix = countManufacturer;
            this.GenerateManufacturerCosts(countManufacturer);
            this.GenerateDataGridView(countManufacturers: countManufacturer);
        }

        private void GreedyAlgorithm_Click(object sender, EventArgs e)
        {
            if (this.Validation())
            {
                this.PrepareData();

                Expensive algorithm = new Expensive();
                GreedyResult.Text = algorithm.Solver(manufactures, clients).ToString();
            }

        }
        private void GeneticAlgorithm_Click(object sender, EventArgs e)
        {
            if (this.Validation())
            {
                this.PrepareData(); 
                var result = GeneticAlgorithm.Executing.Solve(this.manufactures);
                GeneticResult.Text = result.Adaptability.ToString();
            }

        }
        private void FrequancyAlgorithm_Click(object sender, EventArgs e)
        {
            if (this.Validation())
            {
                this.PrepareData();
                manufactures = GeneticAlgorithm.ProbabilityComputerer.Compute(manufactures);
                var result = FrequencySearch.FrequancySearch.FindMostFrequance(this.manufactures);
                FrequancyResult.Text = result.Adaptability.ToString();
            }

        }
        private List<Client> clients;
        private List<Manufacture> manufactures;
        private bool Validation()
        {
            bool error = false;
            int number;

            for (int i = 0; i < realCountManufacurerInMatrix; i++)
            {
                if (string.IsNullOrEmpty(((TextBox)groupBox.Controls["TextBox" + i.ToString()]).Text) ||
                    !int.TryParse(((TextBox)groupBox.Controls["TextBox" + i.ToString()]).Text.ToString(), out number))
                {
                    error = true;
                }

                if (this.dataGridView[i, realCountClientInMatrix].Value == null ||
                    !int.TryParse(this.dataGridView[i,realCountClientInMatrix].Value.ToString(),out number))
                {
                    error = true;
                }
                
                for(int j = 0; j < realCountClientInMatrix; j++)
                {
                    if(this.dataGridView[i,j].Value == null || 
                        !int.TryParse(this.dataGridView[i, j].Value.ToString(),out number))
                    {
                        error = true;
                    }
                }
            }

            for (int i = 0; i < realCountClientInMatrix; i++)
            {
                if (this.dataGridView[realCountManufacurerInMatrix, i].Value == null
                    || !int.TryParse(this.dataGridView[realCountManufacurerInMatrix, i].Value.ToString(), out number))
                {
                    error = true;
                }
            }

            return !error;
        }

        private void PrepareData()
        {
            clients = new List<Client>();
            manufactures = new List<Manufacture>();

            int numberOfClient = this.realCountClientInMatrix;
            int nummberOfManufactures = this.realCountManufacurerInMatrix;

            int sumOfNeeds = 0;
            int sumOfProductionCapacity = 0;

            for (int i = 0; i < numberOfClient; i++)
            {
                if (this.dataGridView[nummberOfManufactures, i].Value != null)
                {
                    var client = new Client
                    {
                        Needs = int.Parse(this.dataGridView[nummberOfManufactures, i].Value.ToString())
                    };
                    clients.Add(client);
                    sumOfNeeds += client.Needs;
                }
            }

            for (int i = 0; i < nummberOfManufactures; i++)
            {
                var manufacture = new Manufacture
                {
                    OrganisationCost = int.Parse(((TextBox)groupBox.Controls["TextBox" + i.ToString()]).Text),
                    ProductionCapacity = int.Parse(this.dataGridView[i, numberOfClient].Value.ToString())
                };
                sumOfProductionCapacity += manufacture.ProductionCapacity;
                manufactures.Add(manufacture);
            }


            for (int i = 0; i < manufactures.Count; i++)
            {
                var manufacture = manufactures[i];
                for (int j = 0; j < clients.Count; j++)
                {
                    int cost = int.Parse(dataGridView[i,j].Value.ToString());
                    var client = clients[j];
                    client.ManufactureDeliveryCost.Add(manufacture, cost);
                    manufacture.ClientsDeliveryCost.Add(client, cost);
                }
            }
        }

        private void GenerateRandomButton_Click(object sender, EventArgs e)
        {
            IsRandom = true;
            this.GenerateManufacturerCosts();
            this.GenerateDataGridView();
            IsRandom = false;
        }

        private void GraphGenerateButton_Click(object sender, EventArgs e)
        {
            Form graph = new Graphs();
            graph.Show();
        }
    }
}
