
namespace MauiAppEvento
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Alterar a página inicial do App

            MainPage = new NavigationPage(new Views.CadastroEvento());
        }

        // Alterar o tamanho da janela do App
        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 800;

            return window;
        }
    }
}
