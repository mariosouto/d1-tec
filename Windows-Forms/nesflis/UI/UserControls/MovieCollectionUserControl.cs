using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Core.Entities;
using System.IO;
using System.Net;

namespace UI.UserControls
{
    public partial class MovieCollectionUserControl : UserControl
    {
        private const int POSTER_HEIGHT = 200;
        private const int POSTER_WIDTH = 200;
        private const int VERTICAL_SPACE_BETWEEN_POSTERS = 30;

        private int amountOfPostersPerRow;
        private int horizontalSpaceBetweenPosters;
        private int amountOfPostersInCurrentRow;
        private int currentAmountOfRows;

        private ICollection<Movie> movies;
        private Action<int, Dictionary<string, int>> doNavigation;

        public MovieCollectionUserControl(ICollection<Movie> movies, Action<int, Dictionary<string, int>> doNavigation)
        {
            InitializeComponent();

            this.amountOfPostersPerRow = this.Width / POSTER_WIDTH;
            this.horizontalSpaceBetweenPosters = (this.Width % POSTER_WIDTH) / (this.amountOfPostersPerRow + 1);
            this.amountOfPostersInCurrentRow = 0;
            this.currentAmountOfRows = 0;

            this.movies = movies;
            this.doNavigation = doNavigation;

            this.DrawMoviePosters();
        }

        private void DrawMoviePosters()
        {
            foreach (var movie in this.movies)
            {
                this.DrawMoviePoster(movie);
            }
        }

        private void DrawMoviePoster(Movie movie)
        {
            PictureBox pictureBox = new PictureBox();

            Tuple<int, int> posterPosition = CalculatePosterPosition();
            var xPosition = posterPosition.Item1;
            var yPosition = posterPosition.Item2;

            pictureBox.Location = new Point(xPosition, yPosition);
            pictureBox.Size = new Size(POSTER_WIDTH, POSTER_HEIGHT);
            pictureBox.Image = Image.FromStream(CreateImageStreamFromUrl(movie.PosterUrl));
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.MouseClick += new MouseEventHandler((sender, e) => this.OnClickMoviePoster(sender, e, movie));
            this.Controls.Add(pictureBox);
        }

        private void OnClickMoviePoster(object sender, EventArgs e, Movie movie)
        {
            var additionalParameters = new Dictionary<string, int>();
            additionalParameters.Add("MOVIE_CODE", movie.Code);
            this.doNavigation(UserControlRegistry.MOVIE_DETAILS_USER_CONTROL, additionalParameters);
        }

        private Tuple<int, int> CalculatePosterPosition()
        {
            int xPosition = 0;
            int yPosition = 0;

            if (ThereIsMoreSpaceForAPosterInCurrentRow())
            {
                xPosition = CalculateHorizontalPosition();
                this.amountOfPostersInCurrentRow++;
            }
            else
            {
                this.currentAmountOfRows++;
                this.amountOfPostersInCurrentRow = 1;
                xPosition = horizontalSpaceBetweenPosters;
            }

            yPosition = CalculateVerticalPosition();

            return new Tuple<int, int>(xPosition, yPosition);
        }

        private bool ThereIsMoreSpaceForAPosterInCurrentRow() => amountOfPostersInCurrentRow < amountOfPostersPerRow;

        private int CalculateHorizontalPosition()
        {
            return horizontalSpaceBetweenPosters * (amountOfPostersInCurrentRow + 1) + POSTER_WIDTH * amountOfPostersInCurrentRow;
        }

        private int CalculateVerticalPosition()
        {
            return VERTICAL_SPACE_BETWEEN_POSTERS * currentAmountOfRows + (POSTER_HEIGHT * currentAmountOfRows);
        }

        private Stream CreateImageStreamFromUrl(string url)
        {
            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            return response.GetResponseStream();
        }
    }
}
