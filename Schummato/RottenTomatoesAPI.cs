using System.Configuration;
using System.Net;
using Schummato.Entities;
using Schummato.Responses;
using Schummato.Utilities.EndpointBuilders;

namespace Schummato
{
    /// <summary>
    /// Access the Rotten Tomatoes API
    /// </summary>
	public class RottenTomatoesAPI
	{
		private readonly string _apiKey;

		/// <summary>
		/// Constructs an new instance of the Rotten Tomatoes API
		/// </summary>
		/// <param name="apiKey">The API key given to you by Rotten Tomatoes</param>
		public RottenTomatoesAPI(string apiKey)
		{
			_apiKey = apiKey;
		}

		public RottenTomatoesAPI()
		{
			_apiKey = ConfigurationManager.AppSettings["RottenTomatoesApiKey"];
		}

		/// <summary>
		/// The movies search endpoint for plain text queries. Allows you to search for movies!
		/// </summary>
		/// <param name="query">Plain text movie search query. Should not be URL encoded yet!</param>
		/// <returns>A response containing the top 30 movie search result and a total of all results.</returns>
		public MoviesWithTotalResponse PerformSearch(string query)
		{
			return PerformSearch(query, null, null);
		}

		/// <summary>
		/// The movies search endpoint for plain text queries. Allows you to search for movies!
		/// </summary>
		/// <param name="query">Plain text movie search query. Should not be URL encoded yet!</param>
		/// <param name="pageLimit"></param>
		/// <param name="page"></param>
		/// <returns>A response containing the search results you've limited to for the page you specified and a total of all results.</returns>
		public MoviesWithTotalResponse PerformSearch(string query, int? pageLimit, int? page)
		{
			MoviesWithTotalResponse response;

			using (var client = new WebClient())
			{
				var builder = new SearchEndpointBuilder(_apiKey, query)
                    .WithPageLimit(pageLimit)
                    .WithPageNumber(page);
                
				var json = client.DownloadString(builder.ToString());

				response = new MoviesWithTotalResponse(json);
			}

			return response;
		}

		/// <summary>
		/// Gets the top level lists available in the API. Rotten Tomatoes currently has movie lists and dvd lists available.
		/// </summary>
		/// <returns>A response containing the lists and links to the list endpoints.</returns>
		public ListsReponse GetListsDirectory()
		{
			ListsReponse response;

			using (var client = new WebClient())
			{
			    var endPoint = new ListsDirectoryEndpointBuilder(_apiKey);

				var json = client.DownloadString(endPoint.ToString());

				response = new ListsReponse(json);
			}

			return response;
		}

		/// <summary>
		/// Shows the movie lists Rotten Tomatoes has available.
		/// </summary>
		/// <returns>A response containing the name of the lists and the address to the API endpoint</returns>
		public ListsReponse GetMovieListsDirectory()
		{
			ListsReponse response;

			using (var client = new WebClient())
			{
				var endPoint = new MovieListsEndpointBuilder(_apiKey).ToString();

				var json = client.DownloadString(endPoint);

				response = new ListsReponse(json);
			}

			return response;
		}

		/// <summary>
		/// Displays Top Box Office Earning Movies, Sorted by Most Recent Weekend Gross Ticket Sales
		/// </summary>
		/// <returns>A list of Top Box Office Earning Movies</returns>
		public MoviesResponse GetBoxOfficeMovies()
		{
			return GetBoxOfficeMovies(null, null);
		}

        /// <summary>
        /// Displays Top Box Office Earning Movies, Sorted by Most Recent Weekend Gross Ticket Sales
        /// </summary>
        /// <param name="limit">The number of results returned</param>
        /// <returns></returns>
		public MoviesResponse GetBoxOfficeMovies(int? limit)
		{
			return GetBoxOfficeMovies(limit, null);
		}

        /// <summary>
        /// Displays Top Box Office Earning Movies, Sorted by Most Recent Weekend Gross Ticket Sales
        /// </summary>
        /// <param name="limit">Limits the number of box office movies returned</param>
        /// <param name="isoCountryCode">Provides localized data for the selected country (ISO 3166-1 alpha-2) if available. Otherwise, returns US data.</param>
        /// <returns></returns>
		public MoviesResponse GetBoxOfficeMovies(int? limit, string isoCountryCode)
		{
			MoviesResponse response;

			using (var client = new WebClient())
			{
				var builder = new BoxOfficeMoviesEndpointBuilder(_apiKey)
                    .WithLimit(limit)
                    .WithCountry(isoCountryCode);

				var json = client.DownloadString(builder.ToString());

				response = new MoviesResponse(json);
			}

			return response;
		}

        /// <summary>
        /// Retrieves movies currently in theaters
        /// </summary>
        /// <returns>List of first 30 movies currently in theaters with total movies.</returns>
		public MoviesWithTotalResponse GetInTheaterMovies()
		{
			return GetInTheaterMovies(null, null);
		}

        /// <summary>
        /// Retrieves movies currently in theaters
        /// </summary>
        /// <param name="pageLimit">The amount of movies in theaters to show per page</param>
        /// <param name="page">The selected page of in theaters movies</param>
        /// <returns></returns>
		public MoviesWithTotalResponse GetInTheaterMovies(int? pageLimit, int? page)
		{
			return GetInTheaterMovies(pageLimit, page, null);
		}

        /// <summary>
        /// Gets the in theater movies.
        /// </summary>
        /// <param name="pageLimit">The amount of movies in theaters to show per page</param>
        /// <param name="page">The selected page of in theaters movies</param>
        /// <param name="isoCountryCode">Provides localized data for the selected country (ISO 3166-1 alpha-2) if available. Otherwise, returns US data.</param>
        /// <returns></returns>
		public MoviesWithTotalResponse GetInTheaterMovies(int? pageLimit, int? page, string isoCountryCode)
		{
			MoviesWithTotalResponse response;

			using (var client = new WebClient())
			{
				var builder = new InTheaterMoviesEndpointBuilder(_apiKey)
                    .WithPageLimit(pageLimit)
                    .WithPageNumber(page)
                    .WithCountry(isoCountryCode);

				var json = client.DownloadString(builder.ToString());
				response = new MoviesWithTotalResponse(json);
			}

			return response;
		}

        /// <summary>
        /// Retrieves current opening movies
        /// </summary>
        /// <returns></returns>
		public MoviesResponse GetOpeningMovies()
		{
			return GetOpeningMovies(null);
		}

        /// <summary>
        /// Retrieves current opening movies
        /// </summary>
        /// <param name="limit">Limits the number of opening movies returned</param>
        /// <returns></returns>
		public MoviesResponse GetOpeningMovies(int? limit)
		{
			return GetOpeningMovies(limit, null);
		}

        /// <summary>
        /// Retrieves current opening movies
        /// </summary>
        /// <param name="limit">Limits the number of opening movies returned</param>
        /// <param name="isoCountryCode">Provides localized data for the selected country (ISO 3166-1 alpha-2) if available. Otherwise, returns US data.</param>
        /// <returns></returns>
		public MoviesResponse GetOpeningMovies(int? limit, string isoCountryCode)
		{
			MoviesResponse response;

			using (var client = new WebClient())
			{
				var builder = new OpeningMoviesEndpointBuilder(_apiKey)
                    .WithLimit(limit)
                    .WithCountry(isoCountryCode);

				var json = client.DownloadString(builder.ToString());
				response = new MoviesResponse(json);
			}

			return response;
		}

        /// <summary>
        /// Retrieves upcoming movies. Results are paginated if they go past the specified page limit
        /// </summary>
        /// <returns></returns>
		public MoviesWithTotalResponse GetUpcomingMovies()
		{
			return GetUpcomingMovies(null, null);
		}

        /// <summary>
        /// Retrieves upcoming movies. Results are paginated if they go past the specified page limit
        /// </summary>
        /// <param name="pageLimit">The amount of upcoming movies to show per page</param>
        /// <param name="page">The selected page of upcoming movies</param>
        /// <returns></returns>
		public MoviesWithTotalResponse GetUpcomingMovies(int? pageLimit, int? page)
		{
			return GetUpcomingMovies(pageLimit, page, null);
		}

        /// <summary>
        /// Retrieves upcoming movies. Results are paginated if they go past the specified page limit
        /// </summary>
        /// <param name="pageLimit">The amount of upcoming movies to show per page</param>
        /// <param name="page">The selected page of upcoming movies</param>
        /// <param name="isoCountryCode">Provides localized data for the selected country (ISO 3166-1 alpha-2) if available. Otherwise, returns US data.</param>
        /// <returns></returns>
		public MoviesWithTotalResponse GetUpcomingMovies(int? pageLimit, int? page, string isoCountryCode)
		{
			MoviesWithTotalResponse response;

			using (var client = new WebClient())
			{
				var builder = new UpcomingMoviesEndpointBuilder(_apiKey)
                    .WithPageLimit(pageLimit)
                    .WithPageNumber(page)
                    .WithCountry(isoCountryCode);

				var json = client.DownloadString(builder.ToString());
				response = new MoviesWithTotalResponse(json);
			}

			return response;
		}

        /// <summary>
        /// Shows the DVD lists we have available
        /// </summary>
        /// <returns></returns>
		public ListsReponse GetDVDListsDirectory()
		{
			ListsReponse response;

			using (var client = new WebClient())
			{
				var endPoint = new DVDListsEndpointBuilder(_apiKey).ToString();

				var json = client.DownloadString(endPoint);

				response = new ListsReponse(json);
			}

			return response;
		}

        /// <summary>
        /// Retrieves the current top dvd rentals
        /// </summary>
        /// <returns></returns>
		public MoviesResponse GetTopRentals()
		{
			return GetTopRentals(null, null);
		}

        /// <summary>
        /// Retrieves the current top dvd rentals
        /// </summary>
        /// <param name="limit">Limits the number of top rentals returned</param>
        /// <returns></returns>
		public MoviesResponse GetTopRentals(int? limit)
		{
			return GetTopRentals(limit, null);
		}

        /// <summary>
        /// Retrieves the current top dvd rentals
        /// </summary>
        /// <param name="limit">Limits the number of top rentals returned</param>
        /// <param name="isoCountryCode">Provides localized data for the selected country (ISO 3166-1 alpha-2) if available. Otherwise, returns US data.</param>
        /// <returns></returns>
		public MoviesResponse GetTopRentals(int? limit, string isoCountryCode)
		{
			MoviesResponse response;

			using (var client = new WebClient())
			{
				var builder = new TopRentalsEndpointBuilder(_apiKey)
                    .WithLimit(limit)
                    .WithCountry(isoCountryCode);

				var json = client.DownloadString(builder.ToString());

				response = new MoviesResponse(json);
			}

			return response;
		}

        /// <summary>
        /// Retrieves current release dvds. Results are paginated if they go past the specified page limit
        /// </summary>
        /// <returns></returns>
		public MoviesWithTotalResponse GetCurrentReleaseDVDs()
		{
			return GetCurrentReleaseDVDs(null, null);
		}

        /// <summary>
        /// Retrieves current release dvds. Results are paginated if they go past the specified page limit
        /// </summary>
        /// <param name="pageLimit">The amount of new release dvds to show per page</param>
        /// <param name="page">The selected page of current DVD releases</param>
        /// <returns></returns>
		public MoviesWithTotalResponse GetCurrentReleaseDVDs(int? pageLimit, int? page)
		{
			return GetCurrentReleaseDVDs(pageLimit, page, null);
		}

        /// <summary>
        /// Retrieves current release dvds. Results are paginated if they go past the specified page limit
        /// </summary>
        /// <param name="pageLimit">The amount of new release dvds to show per page</param>
        /// <param name="page">The selected page of current DVD releases</param>
        /// <param name="isoCountryCode">Provides localized data for the selected country (ISO 3166-1 alpha-2) if available. Otherwise, returns US data.</param>
        /// <returns></returns>
		public MoviesWithTotalResponse GetCurrentReleaseDVDs(int? pageLimit, int? page, string isoCountryCode)
		{
			MoviesWithTotalResponse response;

			using (var client = new WebClient())
			{
				var builder = new CurrentReleaseDVDEndpointBuilder(_apiKey)
                    .WithPageLimit(pageLimit)
                    .WithPageNumber(page)
                    .WithCountry(isoCountryCode);

				var json = client.DownloadString(builder.ToString());
				response = new MoviesWithTotalResponse(json);
			}

			return response;
		}

        /// <summary>
        /// Retrieves new release dvds. Results are paginated if they go past the specified page limit
        /// </summary>
        /// <returns></returns>
		public MoviesWithTotalResponse GetNewReleaseDVDs()
		{
			return GetNewReleaseDVDs(null, null);
		}

        /// <summary>
        /// Retrieves new release dvds. Results are paginated if they go past the specified page limit
        /// </summary>
        /// <param name="pageLimit">The amount of new release dvds to show per page</param>
        /// <param name="page">The selected page of new release DVDs</param>
        /// <returns></returns>
		public MoviesWithTotalResponse GetNewReleaseDVDs(int? pageLimit, int? page)
		{
			return GetNewReleaseDVDs(pageLimit, page, null);
		}

        /// <summary>
        /// Retrieves new release dvds. Results are paginated if they go past the specified page limit
        /// </summary>
        /// <param name="pageLimit">The amount of new release dvds to show per page</param>
        /// <param name="page">The selected page of new release DVDs</param>
        /// <param name="isoCountryCode">Provides localized data for the selected country (ISO 3166-1 alpha-2) if available. Otherwise, returns US data.</param>
        /// <returns></returns>
		public MoviesWithTotalResponse GetNewReleaseDVDs(int? pageLimit, int? page, string isoCountryCode)
		{
			MoviesWithTotalResponse response;

			using (var client = new WebClient())
			{
				var builder = new NewReleaseDVDsEndpointBuilder(_apiKey)
                    .WithPageLimit(pageLimit)
                    .WithPageNumber(page)
                    .WithCountry(isoCountryCode);

				var json = client.DownloadString(builder.ToString());
				response = new MoviesWithTotalResponse(json);
			}

			return response;
		}

        /// <summary>
        /// Retrieves new release dvds. Results are paginated if they go past the specified page limit
        /// </summary>
        /// <returns></returns>
		public MoviesWithTotalResponse GetUpcomingDVDs()
		{
			return GetUpcomingDVDs(null, null);
		}

        /// <summary>
        /// Retrieves new release dvds. Results are paginated if they go past the specified page limit
        /// </summary>
        /// <param name="pageLimit">The amount of upcoming dvds to show per page</param>
        /// <param name="page">The selected page of upcoming DVDs</param>
        /// <returns></returns>
		public MoviesWithTotalResponse GetUpcomingDVDs(int? pageLimit, int? page)
		{
			return GetUpcomingDVDs(pageLimit, page, null);
		}

        /// <summary>
        /// Retrieves new release dvds. Results are paginated if they go past the specified page limit
        /// </summary>
        /// <param name="pageLimit">The amount of upcoming dvds to show per page</param>
        /// <param name="page">The selected page of upcoming DVDs</param>
        /// <param name="isoCountryCode">Provides localized data for the selected country (ISO 3166-1 alpha-2) if available. Otherwise, returns US data.</param>
        /// <returns></returns>
		public MoviesWithTotalResponse GetUpcomingDVDs(int? pageLimit, int? page, string isoCountryCode)
		{
			MoviesWithTotalResponse response;

			using (var client = new WebClient())
			{
				var builder = new UpcomingDVDsEndpointBuilder(_apiKey)
                    .WithPageLimit(pageLimit)
                    .WithPageNumber(page)
                    .WithCountry(isoCountryCode);

				var json = client.DownloadString(builder.ToString());
				response = new MoviesWithTotalResponse(json);
			}

			return response;
		}

        /// <summary>
        /// Detailed information on a specific movie specified by Id. You can use the movies search endpoint or peruse the lists of movies/dvds to get the urls to movies.
        /// </summary>
        /// <param name="rottenTomatoesMovieId">The rotten tomatoes movie id.</param>
        /// <returns></returns>
		public MovieResponse GetMovieInfo(int rottenTomatoesMovieId)
		{
			MovieResponse response;

			using (var client = new WebClient())
			{
				var endpoint = new MovieInfoEndpointBuilder(_apiKey, rottenTomatoesMovieId).ToString();

				var json = client.DownloadString(endpoint);

				response = new MovieResponse(json);
			}

			return response;
		}

        /// <summary>
        /// Pulls the complete movie cast for a movie
        /// </summary>
        /// <param name="rottenTomatoesMovieId">The rotten tomatoes movie id.</param>
        /// <returns></returns>
		public CastResponse GetMovieCast(int rottenTomatoesMovieId)
		{
			CastResponse response;

			using (var client = new WebClient())
			{
				var endpoint = new MovieCastEndpointBuilder(_apiKey, rottenTomatoesMovieId).ToString();

				var json = client.DownloadString(endpoint);

				response = new CastResponse(json);
			}

			return response;
		}

        /// <summary>
        /// Related movie clips and trailers for a movie
        /// </summary>
        /// <param name="rottenTomatoesMovieId">The rotten tomatoes movie id.</param>
        /// <returns></returns>
		public ClipsResponse GetClips(int rottenTomatoesMovieId)
		{
			ClipsResponse response;

			using (var client = new WebClient())
			{
				var endpoint = new ClipsEndpointBuilder(_apiKey, rottenTomatoesMovieId).ToString();

				var json = client.DownloadString(endpoint);

				response = new ClipsResponse(json);
			}

			return response;
		}

        /// <summary>
        /// Retrieves the reviews for a movie. Results are paginated if they go past the specified page limit
        /// </summary>
        /// <param name="rottenTomatoesMovieId">The rotten tomatoes movie id.</param>
        /// <returns></returns>
		public ReviewsResponse GetReviews(int rottenTomatoesMovieId)
		{
			return GetReviews(rottenTomatoesMovieId, Review.ReviewType.All);
		}

        /// <summary>
        /// Retrieves the reviews for a movie. Results are paginated if they go past the specified page limit
        /// </summary>
        /// <param name="rottenTomatoesMovieId">The rotten tomatoes movie id.</param>
        /// <param name="reviewType">3 different review types are possible: "all", "top_critic" and "dvd". "top_critic" shows all the Rotten Tomatoes designated top critics. "dvd" pulls the reviews given on the DVD of the movie. "all" as the name implies retrieves all reviews.</param>
        /// <returns></returns>
		public ReviewsResponse GetReviews(int rottenTomatoesMovieId, Review.ReviewType reviewType)
		{
			return GetReviews(rottenTomatoesMovieId, reviewType, null, null);
		}

        /// <summary>
        /// Retrieves the reviews for a movie. Results are paginated if they go past the specified page limit
        /// </summary>
        /// <param name="rottenTomatoesMovieId">The rotten tomatoes movie id.</param>
        /// <param name="reviewType">3 different review types are possible: "all", "top_critic" and "dvd". "top_critic" shows all the Rotten Tomatoes designated top critics. "dvd" pulls the reviews given on the DVD of the movie. "all" as the name implies retrieves all reviews.</param>
        /// <param name="pageLimit">The number of reviews to show per page</param>
        /// <param name="page">The selected page of reviews</param>
        /// <returns></returns>
		public ReviewsResponse GetReviews(int rottenTomatoesMovieId, Review.ReviewType reviewType, int? pageLimit, int? page)
		{
			return GetReviews(rottenTomatoesMovieId, reviewType, pageLimit, page, null);
		}

        /// <summary>
        /// Retrieves the reviews for a movie. Results are paginated if they go past the specified page limit
        /// </summary>
        /// <param name="rottenTomatoesMovieId">The rotten tomatoes movie id.</param>
        /// <param name="reviewType">3 different review types are possible: "all", "top_critic" and "dvd". "top_critic" shows all the Rotten Tomatoes designated top critics. "dvd" pulls the reviews given on the DVD of the movie. "all" as the name implies retrieves all reviews.</param>
        /// <param name="pageLimit">The number of reviews to show per page</param>
        /// <param name="page">The selected page of reviews</param>
        /// <param name="isoCountryCode">Provides localized data for the selected country (ISO 3166-1 alpha-2) if available. Otherwise, returns US data.</param>
        /// <returns></returns>
		public ReviewsResponse GetReviews(int rottenTomatoesMovieId, Review.ReviewType reviewType, int? pageLimit, int? page, string isoCountryCode)
		{
			ReviewsResponse response;

			using (var client = new WebClient())
			{
				var builder = new ReviewsEndpointBuilder(_apiKey, rottenTomatoesMovieId)
                    .WithReviewType(reviewType)
                    .WithPageLimit(pageLimit)
                    .WithPageNumber(page)
                    .WithCountry(isoCountryCode);

				var json = client.DownloadString(builder.ToString());

				response = new ReviewsResponse(json);
			}
			return response;
		}

        /// <summary>
        /// Gets the similar.
        /// </summary>
        /// <param name="rottenTomatoesMovieId">The rotten tomatoes movie id.</param>
        /// <returns></returns>
		public MoviesResponse GetSimilar(int rottenTomatoesMovieId)
		{
			return GetSimilar(rottenTomatoesMovieId, null);
		}

        /// <summary>
        /// Shows similar movies for a movie
        /// </summary>
        /// <param name="rottenTomatoesMovieId">The rotten tomatoes movie id.</param>
        /// <param name="limit">Limit the number of similar movies to show</param>
        /// <returns></returns>
		public MoviesResponse GetSimilar(int rottenTomatoesMovieId, int? limit)
		{
			MoviesResponse response;

			using (var client = new WebClient())
			{
				var builder = new SimilarEndpointBuilder(_apiKey, rottenTomatoesMovieId)
                    .WithLimit(limit);

				var endpoint = builder.ToString();

				var json = client.DownloadString(endpoint);

				response = new MoviesResponse(json);
			}

			return response;
		}

        /// <summary>
        /// Provides a movie lookup by an id from a different vendor. Only supports imdb lookup at this time WARNING - This feature is Beta quality. Accuracy of the lookup is not promised
        /// </summary>
        /// <param name="aliasId">The id you want to look up</param>
        /// <param name="aliasType">alias type you want to look up - only imdb is supported at this time</param>
        /// <returns></returns>
		public MovieResponse GetMovieByAlias(string aliasId, Movie.AliasType aliasType)
		{
			MovieResponse response;

			using (var client = new WebClient())
			{
				var builder = new MovieAliasEndpointBuilder(_apiKey, aliasId, aliasType);

				var json = client.DownloadString(builder.ToString());

				response = new MovieResponse(json);
			}

			return response;
		}
	}
}
