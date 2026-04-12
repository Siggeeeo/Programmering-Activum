namespace PRG1_MAUI_ERP_Activum.View;

public partial class PerDiemPage : ContentPage
{
	public PerDiemPage()
	{
		InitializeComponent();
	}

	private void OnCalculatePerDiemClicked(object sender, EventArgs e)
	{
		DateTime departure = DepartureDatePicker.Date ?? DateTime.Today;
		DateTime returnDate = ReturnDatePicker.Date ?? DateTime.Today;

		if (returnDate < departure)
		{
			ResultLabel.Text = "Hemkomst kan inte vara innan avresa.";
			return;
		}

		int totalDays = (returnDate - departure).Days + 1;

		int fullDays = totalDays;
		int halfDays = 0;

		if (HalfDayCheckBox.IsChecked == true)
		{
			fullDays -= 1;
			halfDays = 1;
		}

		double perDiemSum = (fullDays * 240) + (halfDays * 120);

		double expenses = 0;
		if (!string.IsNullOrEmpty(ExpensesEntry.Text))
		{
			double.TryParse(ExpensesEntry.Text, out expenses);
		}
		double totalSum = perDiemSum + expenses;

		ResultLabel.Text = $"Sammanfattning för resan:\n" + 
			$"Heldagar ({fullDays} st): {fullDays * 240} kr\n" +
			$"Halvdagar ({halfDays} st): {halfDays * 120} kr\n" +
			$"Utlägg: {expenses} kr\n\n" +
			$"Totalt att få ut: {totalSum} kr";
    }
}