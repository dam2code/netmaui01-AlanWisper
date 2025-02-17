﻿using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Maui_app9.ViewModels
{
    public class MovieListViewModel : ObservableObject
    {
        public ObservableCollection<MovieViewModel> Movies { get; set; }
        public ICommand DeleteMovieCommand { get; private set; }
        private MovieViewModel _selectedMovie;
        public MovieListViewModel()
        {
            Movies = [];
            DeleteMovieCommand = new Command<MovieViewModel>(DeleteMovie);
        }
        public MovieViewModel SelectedMovie
        {
            get => _selectedMovie;
            set => SetProperty(ref _selectedMovie, value);
        }
        public async Task RefreshMovies()
        {
            IEnumerable<Models.Movie> moviesData = await Models.MoviesDatabase.GetMovies();

            foreach (Models.Movie movie in moviesData)
                Movies.Add(new MovieViewModel(movie));
        }

        public void DeleteMovie(MovieViewModel movie) =>
            Movies.Remove(movie);
    }
}
