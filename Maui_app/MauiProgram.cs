using System.Diagnostics;

namespace MauiXaml;

public partial class Page1 : ContentPage, IPage
{
    public Page1()
    {
        InitializeComponent();
    }

    void LoginButton_Clicked(object sender, EventArgs e)
    {
        Debug.WriteLine("Clicked !");
    }
}