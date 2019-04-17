using System;
using System.Windows.Forms;
using Core.Services;
using Core.Entities;
using System.Collections.Generic;

namespace UI.UserControls
{
    public partial class HomeUserControl : UserControl
    {
        private Action<int, Dictionary<string, int>> doNavigation;

        public HomeUserControl(Action<int, Dictionary<string, int>> doNavigation)
        {
            InitializeComponent();

            this.doNavigation = doNavigation;

            var movies = MovieService.FetchAllMovies();

            this.FillMovieCollection(movies);
        }

        private void genreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedGenre = this.genreComboBox.SelectedIndex;

            var movies = selectedGenre == 0 ? MovieService.FetchAllMovies() : MovieService.FetchMoviesWithGenre(selectedGenre);

            this.FillMovieCollection(movies);
        }

        private void FillMovieCollection(ICollection<Movie> movies)
        {
            var movieCollectionUserControl = new MovieCollectionUserControl(movies, this.doNavigation);
            this.panelMovies.Controls.Clear();
            this.panelMovies.Controls.Add(movieCollectionUserControl);
        }
    }
}
