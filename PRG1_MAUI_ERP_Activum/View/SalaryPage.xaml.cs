namespace PRG1_MAUI_ERP_Activum.View;

public partial class SalaryPage : ContentPage
{
	public SalaryPage()
	{
		InitializeComponent();
	}


	private void OnCalculateSalaryClicked(object sender, EventArgs e)
	{
		double.TryParse(SalesEntry.Text, out double sales);
		int.TryParse(MonthsEntry.Text, out int months);

		if (months < 0 || months > 11) 
		{
			ResultLabel.Text = "Antal månader måste vara mellan 0 och 11";
			return;
		}

		double grundlon = 26000;
		double provision = sales * 0.12;
		double manadslon = grundlon + provision;

		double totalIntjanat = manadslon * months;
		double semesterlon = totalIntjanat * 0.12;

		double bruttoTotal = manadslon + semesterlon;
		double skatt = bruttoTotal * 0.32;
		double netto = bruttoTotal - skatt;

		ResultLabel.Text = $@"Lönespecifikation:

			Grundlön: {grundlon:N0} Kr
Provision (12%): {provision:N0} kr
Semesterlön ({months} mån): {semesterlon} kr

Brutto Totalt: {bruttoTotal:N0} kr
Skatt (32%): -{skatt:N0} kr";
	}
}

