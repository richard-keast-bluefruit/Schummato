namespace Schummato.Utilities.EndpointBuilders
{
    /// <summary>
    /// Builder that helps safely build the endpoint string for Similar 
    /// </summary>
	public class SimilarEndpointBuilder : LimitableEndpointBuilderBase
	{
		public SimilarEndpointBuilder(string apiKey, int movieID) : base(string.Format(EndpointConstants.SimilarEndpoint, movieID), apiKey) {}
	}
}
