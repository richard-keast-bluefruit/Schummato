namespace Schummato.Utilities.EndpointBuilders
{
    /// <summary>
    /// Builder that helps safely build the endpoint string for Movie info
    /// </summary>
	public class MovieInfoEndpointBuilder : EndpointBuilderBase
	{
		public MovieInfoEndpointBuilder(string apiKey, int movieId) : base(string.Format(EndpointConstants.MovieInfoEndpoint, movieId), apiKey) { }
	}
}
