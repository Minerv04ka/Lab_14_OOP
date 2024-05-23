using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_14
{
    public partial class fCity : Form
    {
        public City TheCity;
        public fCity(City c)
        {
            TheCity = c;
            InitializeComponent();
        }
        private void bOk_Click(object sender, EventArgs e)
        {
            TheCity.Name = tbName.Text.Trim();
            TheCity.Country = tbCountry.Text.Trim();
            TheCity.Region = tbRegion.Text.Trim();
            TheCity.Population = int.Parse(tbPopulation.Text.Trim());
            TheCity.YearIncome = double.Parse(tbIncome.Text.Trim());
            TheCity.Area = double.Parse(tbArea.Text.Trim());
            TheCity.HasPort = cbHasPort.Checked;
            TheCity.HasAirport = cbHasAirport.Checked;

            DialogResult = DialogResult.OK;
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void fCity_Load(object sender, EventArgs e)
        {
            if (TheCity != null)
            {
                tbName.Text = TheCity.Name;
                tbCountry.Text = TheCity.Country;
                tbRegion.Text = TheCity.Region;
                tbPopulation.Text = TheCity.Population.ToString();
                tbIncome.Text = TheCity.YearIncome.ToString("0.00");
                tbArea.Text = TheCity.Area.ToString("0.000");
                cbHasPort.Checked = TheCity.HasPort;
                cbHasAirport.Checked = TheCity.HasAirport;
            }
        }
    }
}
