namespace Schummato.Utilities
{
	internal static class EndpointConstants
	{
		// Search
		public const string MoviesSearchEndpoint = "http://api.rottentomatoes.com/api/public/v1.0/movies.json";

		// Lists
		public const string ListsDirectoryEndpoint = "http://api.rottentomatoes.com/api/public/v1.0/lists.json";

		public const string MovieListsDirectoryEndpoint = "http://api.rottentomatoes.com/api/public/v1.0/lists/movies.json";

		public const string BoxOfficeMoviesEndpoint = "http://api.rottentomatoes.com/api/public/v1.0/lists/movies/box_office.json";

		public const string InTheatersMoviesEndpoint = "http://api.rottentomatoes.com/api/public/v1.0/lists/movies/in_theaters.json";

		public const string OpeningMoviesEndpoint = "http://api.rottentomatoes.com/api/public/v1.0/lists/movies/opening.json";

		public const string UpcomingMoviesEndpoint = "http://api.rottentomatoes.com/api/public/v1.0/lists/movies/upcoming.json";

		public const string DVDListsDirectoryEndpoint = "http://api.rottentomatoes.com/api/public/v1.0/lists/dvds.json";

		public const string TopRentalsEndpoint = "http://api.rottentomatoes.com/api/public/v1.0/lists/dvds/top_rentals.json";

		public const string CurrentReleaseDVDsEndpoint = "http://api.rottentomatoes.com/api/public/v1.0/lists/dvds/current_releases.json";

		public const string NewReleaseDVDsEndpoint = "http://api.rottentomatoes.com/api/public/v1.0/lists/dvds/new_releases.json";

		public const string UpcomingDVDsEndpoint = "http://api.rottentomatoes.com/api/public/v1.0/lists/dvds/upcoming.json";

		public const string MovieInfoEndpoint = "http://api.rottentomatoes.com/api/public/v1.0/movies/{0}.json";

		public const string MovieCastEndpoint = "http://api.rottentomatoes.com/api/public/v1.0/movies/{0}/cast.json";

		public const string ClipsEndpoint = "http://api.rottentomatoes.com/api/public/v1.0/movies/{0}/clips.json";

		public const string ReviewsEndpoint = "http://api.rottentomatoes.com/api/public/v1.0/movies/{0}/reviews.json";

		public const string SimilarEndpoint = "http://api.rottentomatoes.com/api/public/v1.0/movies/{0}/similar.json";

		public const string MovieAliasEndpoint = "http://api.rottentomatoes.com/api/public/v1.0/movie_alias.json";
	}
}
