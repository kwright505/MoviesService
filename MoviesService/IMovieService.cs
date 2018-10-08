using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MoviesService
{
    [ServiceContract]
    public interface IMovieService
    {
        [OperationContract]
        List<Movie> GetMovies();
        [OperationContract]
        Movie GetMovie(int Id);
        [OperationContract]
        bool DeleteMovie(int id);
        [OperationContract]
        bool UpdateMovie(Movie movie);
        [OperationContract]
        int CreateMovie(Movie movie);
        [OperationContract]
        Movie GetMovieByTitle(string title);
        [OperationContract]
        bool DeleteMovieByTitle(string title);


    }
}
