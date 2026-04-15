
using System.Collections.ObjectModel;

namespace PRG1_MAUI_ERP_Activum.View;

public partial class CustomersPage : ContentPage
{
	public ObservableCollection<Customer> Customers { get; set; }

	public CustomersPage()
	{
		InitializeComponent();

		Customers = new ObservableCollection<Customer>
		{
			new Customer {Name = "Försäkringar AB", Email = "svenskaforsakringar@email.se"},
			new Customer {Name = "Peters Bygg och Kakel", Email = "Peter@bygg.se " }
		};
		CustomerListView.ItemsSource = Customers;
	}




	private void OnAddCustomerClicked(object sender, EventArgs e)
	{
		if (!string.IsNullOrWhiteSpace(CustomerNameEntry.Text) && !string.IsNullOrWhiteSpace(CustomerEmailEntry.Text))
		{
			Customers.Add(new Customer
			{
				Name = CustomerNameEntry.Text,
				Email = CustomerEmailEntry.Text
			});

			CustomerNameEntry.Text = string.Empty;
			CustomerEmailEntry.Text = string.Empty;

			CustomerNameEntry.Focus();
		}
	}
}

public  class Customer
{
	public string Name { get; set; }
	public string Email { get; set; }
}