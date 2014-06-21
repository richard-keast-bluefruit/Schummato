namespace Schummato.Utilities.EndpointBuilders
{
    /// <summary>
    /// Builder that helps safely build the endpoint string for Lists Directory
    /// </summary>
	public class ListsDirectoryEndpointBuilder : EndpointBuilderBase
	{
		public ListsDirectoryEndpointBuilder(string apiKey) : base(EndpointConstants.ListsDirectoryEndpoint, apiKey) {}
	}
}
