using PartsClient.Data;
using PartsClient.ViewModels;
namespace Maui_app.Pages;

public partial class PartsPage : ContentPage
{
	public PartsPage()
	{
        InitializeComponent();
        BindingContext = new PartsViewModel();
    }
}