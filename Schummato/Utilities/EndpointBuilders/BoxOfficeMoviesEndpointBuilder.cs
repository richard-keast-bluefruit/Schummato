namespace Schummato.Utilities.EndpointBuilders
{
    /// <summary>
    /// Builder that helps safely build the endpoint string for BoxOffice Movies
    /// </summary>
	public class BoxOfficeMoviesEndpointBuilder : LimitableEndpointBuilderBase
	{
		public BoxOfficeMoviesEndpointBuilder(string apiKey) : base(EndpointConstants.BoxOfficeMoviesEndpoint, apiKey) {}
	}
}
