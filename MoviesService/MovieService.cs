using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MoviesService
{
    public class MovieService : IMovieService
    {
        private MoviesEntitie context = new MoviesEntitie();
        public int CreateMovie(Movie movie)
        {
            int rval = -1;
            try
            {
                context.Movies.Add(movie);
                context.SaveChanges();
                rval = movie.ID;
            }
            catch (Exception) {; }
            return rval;
        }

        public bool DeleteMovie(int id)
        {
            bool rval = true;
            try
            {
                var movie = context.Movies.Where(x => x.ID == id).FirstOrDefault(); 
                if (movie != null)
                {
                    context.Movies.Remove(movie);
                    context.SaveChanges();
                }
                
            }
            catch (Exception)
            {
                rval = false;
            }
            return rval;
        }

        public Movie GetMovie(int Id)
        {
            return context.Movies.Where(x => x.ID == Id).FirstOrDefault();
        }

        public List<Movie> GetMovies()
        {
            return context.Movies.ToList();
        }

        public bool UpdateMovie(Movie movie)
        {
            bool rval = true;
            try
            {
                var m = context.Movies.Where(x => x.ID == movie.ID).FirstOrDefault();
                if (m != null)
                {
                    context.Entry(m).CurrentValues.SetValues(movie);
                    context.SaveChanges();
                    rval = true;
                }
                else
                    rval = false;
            }
            catch (Exception)
            {
                rval = false;
            }
            return rval;
        }

        public Movie GetMovieByTitle(string title)
        {
            return context.Movies.Where(x => x.Title.Equals(title)).FirstOrDefault();

        }

        public bool DeleteMovieByTitle(string title)
        {
            bool rval = true;
            try
            {
                var m = context.Movies.Where(x => x.Title.Equals(title)).FirstOrDefault();
                if (m != null)
                {
                    context.Movies.Remove(m);
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                rval = false;
            }
            return rval;
        }
    }

}
