using Schummato.Entities;
using Schummato.Responses;

namespace Schummato
{
    public interface IRottenTomatoesAPI
    {
        /// <summary>
        /// The movies search endpoint for plain text queries. Allows you to search for movies!
        /// </summary>
        /// <param name="query">Plain text movie search query. Should not be URL encoded yet!</param>
        /// <returns>A response containing the top 30 movie search result and a total of all results.</returns>
        MoviesWithTotalResponse PerformSearch(string query);

        /// <summary>
        /// The movies search endpoint for plain text queries. Allows you to search for movies!
        /// </summary>
        /// <param name="query">Plain text movie search query. Should not be URL encoded yet!</param>
        /// <param name="pageLimit"></param>
        /// <param name="page"></param>
        /// <returns>A response containing the search results you've limited to for the page you specified and a total of all results.</returns>
        MoviesWithTotalResponse PerformSearch(string query, int? pageLimit, int? page);

        /// <summary>
        /// Gets the top level lists available in the API. Rotten Tomatoes currently has movie lists and dvd lists available.
        /// </summary>
        /// <returns>A response containing the lists and links to the list endpoints.</returns>
        ListsReponse GetListsDirectory();

        /// <summary>
        /// Shows the movie lists Rotten Tomatoes has available.
        /// </summary>
        /// <returns>A response containing the name of the lists and the address to the API endpoint</returns>
        ListsReponse GetMovieListsDirectory();

        /// <summary>
        /// Displays Top Box Office Earning Movies, Sorted by Most Recent Weekend Gross Ticket Sales
        /// </summary>
        /// <returns>A list of Top Box Office Earning Movies</returns>
        MoviesResponse GetBoxOfficeMovies();

        /// <summary>
        /// Displays Top Box Office Earning Movies, Sorted by Most Recent Weekend Gross Ticket Sales
        /// </summary>
        /// <param name="limit">The number of results returned</param>
        /// <returns></returns>
        MoviesResponse GetBoxOfficeMovies(int? limit);

        /// <summary>
        /// Displays Top Box Office Earning Movies, Sorted by Most Recent Weekend Gross Ticket Sales
        /// </summary>
        /// <param name="limit">Limits the number of box office movies returned</param>
        /// <param name="isoCountryCode">Provides localized data for the selected country (ISO 3166-1 alpha-2) if available. Otherwise, returns US data.</param>
        /// <returns></returns>
        MoviesResponse GetBoxOfficeMovies(int? limit, string isoCountryCode);

        /// <summary>
        /// Retrieves movies currently in theaters
        /// </summary>
        /// <returns>List of first 30 movies currently in theaters with total movies.</returns>
        MoviesWithTotalResponse GetInTheaterMovies();

        /// <summary>
        /// Retrieves movies currently in theaters
        /// </summary>
        /// <param name="pageLimit">The amount of movies in theaters to show per page</param>
        /// <param name="page">The selected page of in theaters movies</param>
        /// <returns></returns>
        MoviesWithTotalResponse GetInTheaterMovies(int? pageLimit, int? page);

        /// <summary>
        /// Gets the in theater movies.
        /// </summary>
        /// <param name="pageLimit">The amount of movies in theaters to show per page</param>
        /// <param name="page">The selected page of in theaters movies</param>
        /// <param name="isoCountryCode">Provides localized data for the selected country (ISO 3166-1 alpha-2) if available. Otherwise, returns US data.</param>
        /// <returns></returns>
        MoviesWithTotalResponse GetInTheaterMovies(int? pageLimit, int? page, string isoCountryCode);

        /// <summary>
        /// Retrieves current opening movies
        /// </summary>
        /// <returns></returns>
        MoviesResponse GetOpeningMovies();

        /// <summary>
        /// Retrieves current opening movies
        /// </summary>
        /// <param name="limit">Limits the number of opening movies returned</param>
        /// <returns></returns>
        MoviesResponse GetOpeningMovies(int? limit);

        /// <summary>
        /// Retrieves current opening movies
        /// </summary>
        /// <param name="limit">Limits the number of opening movies returned</param>
        /// <param name="isoCountryCode">Provides localized data for the selected country (ISO 3166-1 alpha-2) if available. Otherwise, returns US data.</param>
        /// <returns></returns>
        MoviesResponse GetOpeningMovies(int? limit, string isoCountryCode);

        /// <summary>
        /// Retrieves upcoming movies. Results are paginated if they go past the specified page limit
        /// </summary>
        /// <returns></returns>
        MoviesWithTotalResponse GetUpcomingMovies();

        /// <summary>
        /// Retrieves upcoming movies. Results are paginated if they go past the specified page limit
        /// </summary>
        /// <param name="pageLimit">The amount of upcoming movies to show per page</param>
        /// <param name="page">The selected page of upcoming movies</param>
        /// <returns></returns>
        MoviesWithTotalResponse GetUpcomingMovies(int? pageLimit, int? page);

        /// <summary>
        /// Retrieves upcoming movies. Results are paginated if they go past the specified page limit
        /// </summary>
        /// <param name="pageLimit">The amount of upcoming movies to show per page</param>
        /// <param name="page">The selected page of upcoming movies</param>
        /// <param name="isoCountryCode">Provides localized data for the selected country (ISO 3166-1 alpha-2) if available. Otherwise, returns US data.</param>
        /// <returns></returns>
        MoviesWithTotalResponse GetUpcomingMovies(int? pageLimit, int? page, string isoCountryCode);

        /// <summary>
        /// Shows the DVD lists we have available
        /// </summary>
        /// <returns></returns>
        ListsReponse GetDVDListsDirectory();

        /// <summary>
        /// Retrieves the current top dvd rentals
        /// </summary>
        /// <returns></returns>
        MoviesResponse GetTopRentals();

        /// <summary>
        /// Retrieves the current top dvd rentals
        /// </summary>
        /// <param name="limit">Limits the number of top rentals returned</param>
        /// <returns></returns>
        MoviesResponse GetTopRentals(int? limit);

        /// <summary>
        /// Retrieves the current top dvd rentals
        /// </summary>
        /// <param name="limit">Limits the number of top rentals returned</param>
        /// <param name="isoCountryCode">Provides localized data for the selected country (ISO 3166-1 alpha-2) if available. Otherwise, returns US data.</param>
        /// <returns></returns>
        MoviesResponse GetTopRentals(int? limit, string isoCountryCode);

        /// <summary>
        /// Retrieves current release dvds. Results are paginated if they go past the specified page limit
        /// </summary>
        /// <returns></returns>
        MoviesWithTotalResponse GetCurrentReleaseDVDs();

        /// <summary>
        /// Retrieves current release dvds. Results are paginated if they go past the specified page limit
        /// </summary>
        /// <param name="pageLimit">The amount of new release dvds to show per page</param>
        /// <param name="page">The selected page of current DVD releases</param>
        /// <returns></returns>
        MoviesWithTotalResponse GetCurrentReleaseDVDs(int? pageLimit, int? page);

        /// <summary>
        /// Retrieves current release dvds. Results are paginated if they go past the specified page limit
        /// </summary>
        /// <param name="pageLimit">The amount of new release dvds to show per page</param>
        /// <param name="page">The selected page of current DVD releases</param>
        /// <param name="isoCountryCode">Provides localized data for the selected country (ISO 3166-1 alpha-2) if available. Otherwise, returns US data.</param>
        /// <returns></returns>
        MoviesWithTotalResponse GetCurrentReleaseDVDs(int? pageLimit, int? page, string isoCountryCode);

        /// <summary>
        /// Retrieves new release dvds. Results are paginated if they go past the specified page limit
        /// </summary>
        /// <returns></returns>
        MoviesWithTotalResponse GetNewReleaseDVDs();

        /// <summary>
        /// Retrieves new release dvds. Results are paginated if they go past the specified page limit
        /// </summary>
        /// <param name="pageLimit">The amount of new release dvds to show per page</param>
        /// <param name="page">The selected page of new release DVDs</param>
        /// <returns></returns>
        MoviesWithTotalResponse GetNewReleaseDVDs(int? pageLimit, int? page);

        /// <summary>
        /// Retrieves new release dvds. Results are paginated if they go past the specified page limit
        /// </summary>
        /// <param name="pageLimit">The amount of new release dvds to show per page</param>
        /// <param name="page">The selected page of new release DVDs</param>
        /// <param name="isoCountryCode">Provides localized data for the selected country (ISO 3166-1 alpha-2) if available. Otherwise, returns US data.</param>
        /// <returns></returns>
        MoviesWithTotalResponse GetNewReleaseDVDs(int? pageLimit, int? page, string isoCountryCode);

        /// <summary>
        /// Retrieves new release dvds. Results are paginated if they go past the specified page limit
        /// </summary>
        /// <returns></returns>
        MoviesWithTotalResponse GetUpcomingDVDs();

        /// <summary>
        /// Retrieves new release dvds. Results are paginated if they go past the specified page limit
        /// </summary>
        /// <param name="pageLimit">The amount of upcoming dvds to show per page</param>
        /// <param name="page">The selected page of upcoming DVDs</param>
        /// <returns></returns>
        MoviesWithTotalResponse GetUpcomingDVDs(int? pageLimit, int? page);

        /// <summary>
        /// Retrieves new release dvds. Results are paginated if they go past the specified page limit
        /// </summary>
        /// <param name="pageLimit">The amount of upcoming dvds to show per page</param>
        /// <param name="page">The selected page of upcoming DVDs</param>
        /// <param name="isoCountryCode">Provides localized data for the selected country (ISO 3166-1 alpha-2) if available. Otherwise, returns US data.</param>
        /// <returns></returns>
        MoviesWithTotalResponse GetUpcomingDVDs(int? pageLimit, int? page, string isoCountryCode);

        /// <summary>
        /// Detailed information on a specific movie specified by Id. You can use the movies search endpoint or peruse the lists of movies/dvds to get the urls to movies.
        /// </summary>
        /// <param name="rottenTomatoesMovieId">The rotten tomatoes movie id.</param>
        /// <returns></returns>
        MovieResponse GetMovieInfo(int rottenTomatoesMovieId);

        /// <summary>
        /// Pulls the complete movie cast for a movie
        /// </summary>
        /// <param name="rottenTomatoesMovieId">The rotten tomatoes movie id.</param>
        /// <returns></returns>
        CastResponse GetMovieCast(int rottenTomatoesMovieId);

        /// <summary>
        /// Related movie clips and trailers for a movie
        /// </summary>
        /// <param name="rottenTomatoesMovieId">The rotten tomatoes movie id.</param>
        /// <returns></returns>
        ClipsResponse GetClips(int rottenTomatoesMovieId);

        /// <summary>
        /// Retrieves the reviews for a movie. Results are paginated if they go past the specified page limit
        /// </summary>
        /// <param name="rottenTomatoesMovieId">The rotten tomatoes movie id.</param>
        /// <returns></returns>
        ReviewsResponse GetReviews(int rottenTomatoesMovieId);

        /// <summary>
        /// Retrieves the reviews for a movie. Results are paginated if they go past the specified page limit
        /// </summary>
        /// <param name="rottenTomatoesMovieId">The rotten tomatoes movie id.</param>
        /// <param name="reviewType">3 different review types are possible: "all", "top_critic" and "dvd". "top_critic" shows all the Rotten Tomatoes designated top critics. "dvd" pulls the reviews given on the DVD of the movie. "all" as the name implies retrieves all reviews.</param>
        /// <returns></returns>
        ReviewsResponse GetReviews(int rottenTomatoesMovieId, Review.ReviewType reviewType);

        /// <summary>
        /// Retrieves the reviews for a movie. Results are paginated if they go past the specified page limit
        /// </summary>
        /// <param name="rottenTomatoesMovieId">The rotten tomatoes movie id.</param>
        /// <param name="reviewType">3 different review types are possible: "all", "top_critic" and "dvd". "top_critic" shows all the Rotten Tomatoes designated top critics. "dvd" pulls the reviews given on the DVD of the movie. "all" as the name implies retrieves all reviews.</param>
        /// <param name="pageLimit">The number of reviews to show per page</param>
        /// <param name="page">The selected page of reviews</param>
        /// <returns></returns>
        ReviewsResponse GetReviews(int rottenTomatoesMovieId, Review.ReviewType reviewType, int? pageLimit, int? page);

        /// <summary>
        /// Retrieves the reviews for a movie. Results are paginated if they go past the specified page limit
        /// </summary>
        /// <param name="rottenTomatoesMovieId">The rotten tomatoes movie id.</param>
        /// <param name="reviewType">3 different review types are possible: "all", "top_critic" and "dvd". "top_critic" shows all the Rotten Tomatoes designated top critics. "dvd" pulls the reviews given on the DVD of the movie. "all" as the name implies retrieves all reviews.</param>
        /// <param name="pageLimit">The number of reviews to show per page</param>
        /// <param name="page">The selected page of reviews</param>
        /// <param name="isoCountryCode">Provides localized data for the selected country (ISO 3166-1 alpha-2) if available. Otherwise, returns US data.</param>
        /// <returns></returns>
        ReviewsResponse GetReviews(int rottenTomatoesMovieId, Review.ReviewType reviewType, int? pageLimit, int? page, string isoCountryCode);

        /// <summary>
        /// Gets the similar.
        /// </summary>
        /// <param name="rottenTomatoesMovieId">The rotten tomatoes movie id.</param>
        /// <returns></returns>
        MoviesResponse GetSimilar(int rottenTomatoesMovieId);

        /// <summary>
        /// Shows similar movies for a movie
        /// </summary>
        /// <param name="rottenTomatoesMovieId">The rotten tomatoes movie id.</param>
        /// <param name="limit">Limit the number of similar movies to show</param>
        /// <returns></returns>
        MoviesResponse GetSimilar(int rottenTomatoesMovieId, int? limit);

        /// <summary>
        /// Provides a movie lookup by an id from a different vendor. Only supports imdb lookup at this time WARNING - This feature is Beta quality. Accuracy of the lookup is not promised
        /// </summary>
        /// <param name="aliasId">The id you want to look up</param>
        /// <param name="aliasType">alias type you want to look up - only imdb is supported at this time</param>
        /// <returns></returns>
        MovieResponse GetMovieByAlias(string aliasId, Movie.AliasType aliasType);
    }
}