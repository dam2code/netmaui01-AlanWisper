namespace Maui_app
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            //comentario
            InitializeComponent();
            Routing.RegisterRoute("astronomicalbodydetails", typeof(AstronomicalBodyPage));
        }
    }
}
