using PRG1_MAUI_ERP_Activum.ViewModels;

namespace PRG1_MAUI_ERP_Activum.View;

public partial class InsurancePage : ContentPage
{
	public InsuranceViewModel _viewModel;

		public InsurancePage()
	{
		InitializeComponent();

		_viewModel = new InsuranceViewModel();
		BindingContext = _viewModel;

	}

	private void OnSearchTextChanged(object sender, TextChangedEventArgs e)
	{
		_viewModel.SearchInsurance(e.NewTextValue);
	}
}