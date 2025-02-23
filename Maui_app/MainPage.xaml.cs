﻿using Microsoft.Maui;
using Microsoft.Maui.Controls;
using System.Diagnostics;
using UIKit;

namespace Maui_app;

public partial class MainPage : ContentPage
{
    public CustomTipPage()
    {
        InitializeComponent();

        billInput.TextChanged += (s, e) => CalculateTip(false, false);
        roundDown.Clicked += (s, e) => CalculateTip(false, true);
        roundUp.Clicked += (s, e) => CalculateTip(true, false);

        tipPercentSlider.ValueChanged += (s, e) =>
        {
            double pct = Math.Round(e.NewValue);
            tipPercent.Text = $"{pct}%";
            CalculateTip(false, false);
        };
    }

    void CalculateTip(bool roundUp, bool roundDown)
    {
        double t;
        if (Double.TryParse(billInput.Text, out t) && t > 0)
        {
            double pct = Math.Round(tipPercentSlider.Value);
            double tip = Math.Round(t * (pct / 100.0), 2);

            double final = t + tip;

            if (roundUp)
            {
                final = Math.Ceiling(final);
                tip = final - t;
            }
            else if (roundDown)
            {
                final = Math.Floor(final);
                tip = final - t;
            }

            tipOutput.Text = tip.ToString("C");
            totalOutput.Text = final.ToString("C");
        }
    }

    void OnLight(object sender, EventArgs e)
    {
        Resources["fgColor"] = colorNavy;
        Resources["bgColor"] = colorSilver;
       
    }

    void OnDark(object sender, EventArgs e)
    {
        Resources["fgColor"] = colorNavy;
        Resources["bgColor"] = colorSilver;
        
    }
}