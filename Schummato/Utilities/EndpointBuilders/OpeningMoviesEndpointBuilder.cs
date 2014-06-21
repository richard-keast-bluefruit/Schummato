namespace Schummato.Utilities.EndpointBuilders
{
    /// <summary>
    /// Builder that helps safely build the endpoint string for Opening Movies
    /// </summary>
	public class OpeningMoviesEndpointBuilder : LimitableEndpointBuilderBase
	{
		public OpeningMoviesEndpointBuilder(string apiKey) : base(EndpointConstants.OpeningMoviesEndpoint, apiKey) {}
	}
}
