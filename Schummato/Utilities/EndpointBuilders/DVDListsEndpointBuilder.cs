namespace Schummato.Utilities.EndpointBuilders
{
    /// <summary>
    /// Builder that helps safely build the endpoint string for DVD Lists
    /// </summary>
	public class DVDListsEndpointBuilder : EndpointBuilderBase
	{
		public DVDListsEndpointBuilder(string apiKey) : base(EndpointConstants.DVDListsDirectoryEndpoint, apiKey) {}
	}
}
