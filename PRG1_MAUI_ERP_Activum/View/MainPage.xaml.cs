namespace PRG1_MAUI_ERP_Activum.View
{

    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnNavigateToCustomers(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//CustomersPage");
        }

        private async void OnNavigateToInsurance(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//InsurancePage");
        }

        private async void OnNavigateToPerDiem(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//PerDiemPage");


        }
        private async void OnNavigateToSalary(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//SalaryPage");
        }
    }
}
