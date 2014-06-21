namespace Schummato.Utilities.EndpointBuilders
{
    /// <summary>
    /// Builder that helps safely build the endpoint string for Current Release DVDs
    /// </summary>

	public class CurrentReleaseDVDEndpointBuilder : PagingEndpointBuilderBase
	{
		public CurrentReleaseDVDEndpointBuilder(string apiKey) : base(EndpointConstants.CurrentReleaseDVDsEndpoint, apiKey) { }
	}
}
