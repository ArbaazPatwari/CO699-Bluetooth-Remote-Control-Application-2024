using Bluetooth_Remote_Control_App.Views;

namespace Bluetooth_Remote_Control_App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }
    }
}
