namespace Maui_app9
{
    public partial class App : Application
    {
        public static ViewModels.MovieListViewModel? MainViewModel { get; private set; }

        public App()
        {
            InitializeComponent();

        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = new Window(new AppShell());

            MainViewModel = new();
            MainViewModel.RefreshMovies().ContinueWith((s) => { });

            return window;
        }
    }
}
