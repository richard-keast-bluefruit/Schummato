namespace Schummato.Utilities.EndpointBuilders
{
    /// <summary>
    /// Builder that helps safely build the endpoint string for Upcoming Movies
    /// </summary>
	public class UpcomingMoviesEndpointBuilder : PagingEndpointBuilderBase
	{
		public UpcomingMoviesEndpointBuilder(string apiKey) : base(EndpointConstants.UpcomingMoviesEndpoint, apiKey) {}

	}
}
