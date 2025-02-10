﻿using Microsoft.Maui;
using Microsoft.Maui.Controls;
using System.Diagnostics;

namespace MauiCode;

public partial class MainPage : ContentPage
{
    string _fileName = Path.Combine(FileSystem.AppDataDirectory, "notes.txt");
    public MainPage()
    {
        InitializeComponent();

        if (File.Exists(_fileName))
        {
            editor.Text = File.ReadAllText(_fileName);
        }
        var notesHeading = new Label() { Text = "Notes", HorizontalOptions = LayoutOptions.Center, FontAttributes = FontAttributes.Bold };

        editor = new Editor() { Placeholder = "Enter your note", HeightRequest = 100 };
        editor.Text = File.Exists(_fileName) ? File.ReadAllText(_fileName) : string.Empty;

        var buttonsGrid = new Grid() { HeightRequest = 40.0 };
        buttonsGrid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1.0, GridUnitType.Auto) });
        buttonsGrid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(30.0, GridUnitType.Absolute) });
        buttonsGrid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1.0, GridUnitType.Auto) });

        var saveButton = new Button() { WidthRequest = 100, Text = "Save" };
        saveButton.Clicked += OnSaveButtonClicked;
        Grid.SetColumn(saveButton, 0);
        buttonsGrid.Children.Add(saveButton);

        var deleteButton = new Button() { WidthRequest = 100, Text = "Delete" };
        deleteButton.Clicked += OnDeleteButtonClicked;
        Grid.SetColumn(deleteButton, 2);
        buttonsGrid.Children.Add(deleteButton);

        var stackLayout = new VerticalStackLayout
        {
            Padding = new Thickness(30, 60, 30, 30),
            Children = { notesHeading, editor, buttonsGrid }
        };

        this.Content = stackLayout;
    }
}