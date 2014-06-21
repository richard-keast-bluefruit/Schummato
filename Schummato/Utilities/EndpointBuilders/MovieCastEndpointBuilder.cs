namespace Schummato.Utilities.EndpointBuilders
{
    /// <summary>
    /// Builder that helps safely build the endpoint string for Movie Cast
    /// </summary>
	public class MovieCastEndpointBuilder : EndpointBuilderBase
	{
		public MovieCastEndpointBuilder(string apiKey, int movieId) : base(string.Format(EndpointConstants.MovieCastEndpoint, movieId), apiKey) {}
	}
}
