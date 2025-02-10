using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maui_app
{
    [QueryProperty(nameof(AstroName), "astroName")]
    public AstronomicalBodiesPage()
    {
        InitializeComponent();

        btnComet.Clicked += async (s, e) => await Shell.Current.GoToAsync("astronomicalbodydetails?astroName=comet");
        btnEarth.Clicked += async (s, e) => await Shell.Current.GoToAsync("astronomicalbodydetails?astroName=earth");
        btnMoon.Clicked += async (s, e) => await Shell.Current.GoToAsync("astronomicalbodydetails?astroName=moon");
        btnSun.Clicked += async (s, e) => await Shell.Current.GoToAsync("astronomicalbodydetails?astroName=sun");

        string astroName;
        public string AstroName
    {
        get => astroName;
        set
        {
            astroName = value;

            // this is a custom function to update the UI immediately
            UpdateAstroBodyUI(astroName);
        }
    }
}


