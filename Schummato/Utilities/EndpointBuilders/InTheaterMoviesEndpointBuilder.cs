namespace Schummato.Utilities.EndpointBuilders
{
    /// <summary>
    /// Builder that helps safely build the endpoint string for In Theater Movies
    /// </summary>

	public class InTheaterMoviesEndpointBuilder : PagingEndpointBuilderBase
	{
		public InTheaterMoviesEndpointBuilder(string apiKey) : base(EndpointConstants.InTheatersMoviesEndpoint, apiKey) { }

	}
}
