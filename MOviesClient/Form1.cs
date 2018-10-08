using MOviesClient.MovieServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoviesClient
{
    public partial class Form1 : Form
    {
        MovieServiceClient service = new MovieServiceClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtGetMovieList_Click(object sender, EventArgs e)
        {
            tbMovieList.Text = "";
            var movies = service.GetMovies();
            foreach (var movie in movies)
            {
                tbMovieList.Text += movie.Title + " released on " + movie.ReleaseDate +
                    " in Genre " + movie.Genre + "\r\n";
            }
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            Movie m = new Movie();
            m.Title = tbTitle.Text;
            m.Genre = tbGenre.Text;
            m.ReleaseDate = dtpReleaseDate.Value;
            service.CreateMovie(m);
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            Movie m = GetMovieValues();
            Movie movie = service.GetMovieByTitle(m.Title);
            movie.Genre = m.Genre;
            movie.ReleaseDate = m.ReleaseDate;
            service.UpdateMovie(movie);
        }

        private Movie GetMovieValues()
        {
            Movie m = new Movie();
            m.Title = tbTitle.Text;
            m.Genre = tbGenre.Text;
            m.ReleaseDate = dtpReleaseDate.Value;
            return m;
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            Movie m = GetMovieValues();
            service.DeleteMovieByTitle(m.Title);
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbMovieList_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
