namespace Schummato.Utilities.EndpointBuilders
{
    /// <summary>
    /// Builder that helps safely build the endpoint string for Top Rentals
    /// </summary>
	public class TopRentalsEndpointBuilder : LimitableEndpointBuilderBase
	{
		public TopRentalsEndpointBuilder(string apiKey) : base(EndpointConstants.TopRentalsEndpoint, apiKey) { }
	}

}
