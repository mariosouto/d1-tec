using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Core.Services;
using Core.Entities;

namespace UI.UserControls
{
    public partial class SearchUserControl : UserControl
    {
        private Action<int, Dictionary<string, int>> doNavigation;

        public SearchUserControl(Action<int, Dictionary<string, int>> doNavigation)
        {
            InitializeComponent();

            this.doNavigation = doNavigation;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var actorName = this.searchTextBox.Text;

            var movies = MovieService.FetchMoviesWithActor(actorName);

            this.FillMovieCollection(movies);
        }

        private void FillMovieCollection(ICollection<Movie> movies)
        {
            var movieCollectionUserControl = new MovieCollectionUserControl(movies, this.doNavigation);
            this.moviesPanel.Controls.Clear();
            this.moviesPanel.Controls.Add(movieCollectionUserControl);
        }
    }
}
