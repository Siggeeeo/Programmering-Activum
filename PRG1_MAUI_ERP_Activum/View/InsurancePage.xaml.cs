using PRG1_MAUI_ERP_Activum.ViewModels;

namespace PRG1_MAUI_ERP_Activum.View;

public partial class InsurancePage : ContentPage
{
	public InsuranceViewModel viewModel;

		public InsurancePage()
	{
		InitializeComponent();

		viewModel = new InsuranceViewModel();
		BindingContext = viewModel;

	}

	private void OnSearchTextChanged(object sender, TextChangedEventArgs e)
	{
		viewModel.SearchInsurance(e.NewTextValue);
	}
}