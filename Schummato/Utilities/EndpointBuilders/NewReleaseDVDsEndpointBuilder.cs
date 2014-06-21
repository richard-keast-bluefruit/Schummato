namespace Schummato.Utilities.EndpointBuilders
{
    /// <summary>
    /// Builder that helps safely build the endpoint string for New Release DVDs
    /// </summary>
	public class NewReleaseDVDsEndpointBuilder : PagingEndpointBuilderBase
	{
		public NewReleaseDVDsEndpointBuilder(string apiKey) : base(EndpointConstants.NewReleaseDVDsEndpoint, apiKey) { }
	}

}
