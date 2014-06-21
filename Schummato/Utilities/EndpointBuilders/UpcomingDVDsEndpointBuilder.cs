using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Schummato.Utilities.EndpointBuilders
{
    /// <summary>
    /// Builder that helps safely build the endpoint string for Upcoming DVDs
    /// </summary>
	public class UpcomingDVDsEndpointBuilder : PagingEndpointBuilderBase
	{
		public UpcomingDVDsEndpointBuilder(string apiKey) : base(EndpointConstants.UpcomingDVDsEndpoint, apiKey) { }
	}
}
