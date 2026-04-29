namespace PRG1_MAUI_ERP_Activum
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();


            Routing.RegisterRoute("ToolsPage", typeof(View.ToolsPage));
            Routing.RegisterRoute("CalculatorPage", typeof(View.CalculatorPage));
            Routing.RegisterRoute("SalaryPage", typeof(View.SalaryPage));
            Routing.RegisterRoute("PerDiemPage", typeof(View.PerDiemPage));
            Routing.RegisterRoute("AboutPage", typeof(View.AboutPage));
            Routing.RegisterRoute("SupportPage", typeof(View.SupportPage));

        }
    }
}
                