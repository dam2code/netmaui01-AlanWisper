﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maui_app9.Views
{
    public partial class MovieDetailPage : ContentPage
    {
        public MovieDetailPage()
        {
            BindingContext = App.MainViewModel.SelectedMovie;
            InitializeComponent();
        }
    }
}
