using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace UI
{
    using CommonClasses;
    public partial class AlgorithmForm : Form
    {
        private TransportTaskResult result;
        private List<Manufacture> manufactures;
        private List<Client> clients;

        public AlgorithmForm
            (
            string algorithmName,
            List<Manufacture> manufactures, 
            List<Client> clients, 
            Func<List<Manufacture>, List<Client>, TransportTaskResult> algorithmFunc
            )
        {
            this.manufactures = manufactures;
            this.clients = clients;


            InitializeComponent();

            // fill origin matrix
            GenerateManufacturerCosts(true);
            GenerateDataGridView(this.OriginMatrix);
            FillUpDataGridView(this.OriginMatrix, true);

            
            this.Text = algorithmName;

            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            result = algorithmFunc(manufactures, clients);
            stopwatch.Stop();

            this.TimeWork.Text = stopwatch.ElapsedMilliseconds.ToString();
            this.FunctionResult.Text = result.Cost.ToString();

            // fill new matrix
            GenerateManufacturerCosts(false);
            GenerateDataGridView(this.ResultMatrix);
            FillUpDataGridView(this.ResultMatrix, false);





        }

        private void GenerateDataGridView(DataGridView matrix)
        {
            var countManufacturers = manufactures.Count;
            var countClients = clients.Count;
            for (int i = 0; i < countManufacturers; i++)
            {
                var column = new DataGridViewColumn();
                column.HeaderText = "B" + (i + 1).ToString(); //текст в шапке
                column.Width = 50; //ширина колонки

                column.Name = "B" + (i + 1).ToString(); //текстовое имя колонки, его можно использовать вместо обращений по индексу
                column.CellTemplate = new DataGridViewTextBoxCell();
                matrix.Columns.Add(column);

            }
            var columnClientNeeds = new DataGridViewColumn();
            columnClientNeeds.HeaderText = "Ki"; //текст в шапке
            columnClientNeeds.Width = 50; //ширина колонки

            columnClientNeeds.Name = "ClientNeeds"; //текстовое имя колонки, его можно использовать вместо обращений по индексу
            columnClientNeeds.CellTemplate = new DataGridViewTextBoxCell();
            matrix.Columns.Add(columnClientNeeds);
            matrix.RowHeadersWidth = 50;
            for (int i = 0; i < countClients; i++)
            {
                //for(int j)
                matrix.Rows.Add();
                matrix.Rows[i].HeaderCell.Value = "K" + (i + 1).ToString();
            }
            matrix.Rows.Add();
            matrix.Rows[matrix.Rows.Count - 1].HeaderCell.Value = "Bj";
        }

        private void GenerateManufacturerCosts(bool isOrigin)
        {
            var countManufacturers = manufactures.Count;

            Label text = new Label();
            text.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            text.Text = "Вартість розміщення виробництва";

            Point textLocation;
            if (isOrigin)
            {
                textLocation = new Point(2, 12);
            }
            else
            {
                textLocation = new Point(2, 395);
            }

            text.Location = textLocation;
            text.Name = "LabelTextManufacturerCost";
            text.Size = new System.Drawing.Size(544, 30);
            this.Controls.Add(text);
            for (int i = 0; i < countManufacturers; i++)
            {
                Label label = new Label();
                label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

                Point labelLocation;
                if (isOrigin)
                {
                    labelLocation = new Point(2 + i * (81), 42);
                }
                else
                {
                    labelLocation = new Point(2 + i * (81), 425);
                }

                label.Location = labelLocation;
                label.Name = "LabelManufacturerCost" + i.ToString();
                label.Text = "B" + (i + 1).ToString() + "=";
                label.Size = new System.Drawing.Size(44, 34);
                this.Controls.Add(label);
                TextBox textBox = new TextBox();
                textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

                Point textBoxLocation;
                if (isOrigin)
                {
                    textBoxLocation = new Point(47 + i * (81), 42);
                }
                else
                {
                    textBoxLocation = new Point(47 + i * (81), 425);
                }

                textBox.Location = textBoxLocation;
                textBox.Name = "TextBox" + i.ToString();
                textBox.ReadOnly = true;

                textBox.Text = manufactures[i].OrganisationCost.ToString();

                //  textBox.Text = "B"+(i+1).ToString();
                textBox.Size = new System.Drawing.Size(40, 34);
                textBox.TabIndex = i + 1;
                this.Controls.Add(textBox);

            }
        }

        private void FillUpDataGridView(DataGridView matrix, bool isOrigin)
        {
            for (int i = 0; i < clients.Count; i++)
            {
                matrix[manufactures.Count, i].Value = clients[i].Needs;
                matrix[manufactures.Count, i].ReadOnly = true;
            }

            for (int i = 0; i < manufactures.Count; i++)
            {
                for (int j = 0; j < clients.Count; j++)
                {
                    int value = 0;
                    if (isOrigin)
                    {
                        value = manufactures[i].ClientsDeliveryCost[clients[j]];
                    }
                    else
                    {

                        var routeValue = result.ResultRoute
                            .Where(r => r.Manufacture.Id == manufactures[i].Id)
                            .Where(r => r.Client.Id == clients[j].Id)
                            .FirstOrDefault();

                        if (routeValue != null)
                        {
                            value = routeValue.Value;
                        }
                    }

                    matrix[i, j].Value = value;
                    matrix[i, j].ReadOnly = true;
                    //this.dataGridView[i, j].Value = random.Next(averageManufacturePower - averageManufacturePower/2, averageManufacturePower + averageManufacturePower);
                }


                // powerNeeds = random.Next(10, 30);
                matrix[i, clients.Count].Value = manufactures[i].ProductionCapacity;
                matrix[i, clients.Count].ReadOnly = true;
                //clienstNeeds -= powerNeeds;


            }
            matrix[manufactures.Count, clients.Count].ReadOnly = true;
        }
    }
}
