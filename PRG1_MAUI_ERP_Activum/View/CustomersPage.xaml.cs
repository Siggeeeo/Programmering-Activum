using PRG1_MAUI_ERP_Activum.Models;
using PRG1_MAUI_ERP_Activum.ViewModels;

namespace PRG1_MAUI_ERP_Activum.View;

public partial class CustomersPage : ContentPage
{
    private CustomerViewModel _viewModel;

    public CustomersPage()
    {
        InitializeComponent();

        _viewModel = new CustomerViewModel();
        BindingContext = _viewModel;
        CustomerListView.ItemsSource = _viewModel.Customers;
    }

    private void OnAddCustomerClicked(object sender, EventArgs e)
    {

        string customerName = customerNameEntry.Text;
        string customerEmail = customerEmailEntry.Text;
        if (!string.IsNullOrWhiteSpace(customerName) &&  !string.IsNullOrWhiteSpace(customerEmail))

        {
            _viewModel.AddCustomer(new Customer
            {
                FirstName = customerName,
                Email = customerEmail,
                CustomerType = "Företag"
            });

            customerNameEntry.Text = string.Empty;
            customerEmailEntry.Text = string.Empty;
            customerNameEntry.Focus();
            
        }
    }
}

