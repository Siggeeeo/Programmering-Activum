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
        if (!string.IsNullOrWhiteSpace(CustomerNameEntry.Text) &&  !string.IsNullOrWhiteSpace(CustomerEmailEntry.Text))

        {
            _viewModel.AddCustomer(new Customer
            {
                FirstName = CustomerNameEntry.Text,
                Email = CustomerEmailEntry.Text,
                CustomerType = "Företag"
            });

            CustomerNameEntry.Text = string.Empty;
            CustomerEmailEntry.Text = string.Empty;
            CustomerNameEntry.Focus();
            
        }
    }
}

