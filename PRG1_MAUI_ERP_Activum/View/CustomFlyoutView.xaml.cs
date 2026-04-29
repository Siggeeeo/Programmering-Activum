using System.Diagnostics;
using System.Windows.Input;

namespace PRG1_MAUI_ERP_Activum.View;

public partial class CustomFlyoutView : ContentView
{
    public ICommand NavigateCommand { get; }
    public ICommand ToggleToolsCommand { get; }

    public CustomFlyoutView()
    {
        try
        {
            NavigateCommand = new Command<string>(async (page) =>
            {
                Debug.WriteLine($"[CustomFlyoutView] NavigateCommand: {page}");
                
                if (page == "CalculatorPage" || page == "SalaryPage" || page == "PerDiemPage" || page == "AboutPage" || page == "SupportPage")
                {
                    await Shell.Current.GoToAsync(page);
                }
                else
                {
                    await Shell.Current.GoToAsync($"//{page}");
                }
                Shell.Current.FlyoutIsPresented = false;
            });

            ToggleToolsCommand = new Command(() =>
            {
                Debug.WriteLine("[CustomFlyoutView] ToggleToolsCommand executed");
                if (ToolsSubMenu != null)
                {
                    ToolsSubMenu.IsVisible = !ToolsSubMenu.IsVisible;
                }
            });

            InitializeComponent();
            BindingContext = this;
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"[CustomFlyoutView] Error in constructor: {ex}");
            throw;
        }
    }
}

