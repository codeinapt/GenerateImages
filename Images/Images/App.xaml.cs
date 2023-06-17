using Images.Views;

namespace Images;


public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new DashboardView();
    }
}
