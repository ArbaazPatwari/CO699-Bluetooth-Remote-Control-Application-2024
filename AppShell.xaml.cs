using Bluetooth_Remote_Control_App.Views;

namespace Bluetooth_Remote_Control_App
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // Key and value pair for the app shell to launch these pages
            Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
            Routing.RegisterRoute(nameof(DeviceList), typeof(DeviceList));
            Routing.RegisterRoute(nameof(Settings), typeof(Settings));
        }
    }
}
