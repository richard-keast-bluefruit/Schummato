namespace Schummato.Utilities.EndpointBuilders
{
    /// <summary>
    /// Builder that helps safely build the endpoint string for Clips
    /// </summary>
	public class ClipsEndpointBuilder : EndpointBuilderBase
	{
		public ClipsEndpointBuilder(string apiKey, int movieId) : base(string.Format(EndpointConstants.ClipsEndpoint, movieId), apiKey) {}
	}
}
