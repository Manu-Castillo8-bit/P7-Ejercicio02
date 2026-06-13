using Microsoft.Extensions.DependencyInjection;

namespace Ejercicio02
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new ContentPageDemostracion();
        }

        /*protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }*/
    }
}