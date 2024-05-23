namespace Lab_14
{
	public partial class fMain : Form
	{
		public fMain()
		{
			InitializeComponent();
		}

		private void bAdd_Click(object sender, EventArgs e)
		{
			City city = new City();
			fCity fc = new fCity(city);
			if (fc.ShowDialog() == DialogResult.OK)
			{
				tInfo.Text += string.Format("{0}, {1}, {2}. ���������: {3}. г���� �����: {4:0.00} ���. �����: {5:0.000} ��. ��. [{6} | {7}] | г���� ����� �� ��������: {8:0.00} ���\r\n", city.Name, city.Country, city.Region, city.Population, city.YearIncome, city.Area, city.HasPort ? "� ����" : "���� �����",
			city.HasAirport ? "� ��������" : "���� ���������", city.GetYearIncomePerInhabitant());

			}
		}

		private void bClose_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("��������� ������ ����������?", "��������� ������", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) Application.Exit();
		}

		private void bClear_Click(object sender, EventArgs e)
		{
			tInfo.Text = "";
		}

		private void fMain_Load(object sender, EventArgs e)
		{

		}
	}
}
