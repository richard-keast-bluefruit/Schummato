namespace Schummato.Utilities.EndpointBuilders
{
    /// <summary>
    /// Builder that helps safely build the endpoint string for Movie Lists
    /// </summary>
	public class MovieListsEndpointBuilder : EndpointBuilderBase
	{
		public MovieListsEndpointBuilder(string apiKey) : base(EndpointConstants.MovieListsDirectoryEndpoint, apiKey) {}
	}
}
