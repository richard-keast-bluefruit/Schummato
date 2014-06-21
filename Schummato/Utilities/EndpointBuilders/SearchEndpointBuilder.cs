using System.Web;

namespace Schummato.Utilities.EndpointBuilders
{
    /// <summary>
    /// Builder that helps safely build the endpoint string for Search
    /// </summary>
	public class SearchEndpointBuilder : PagingEndpointBuilderBase
	{
		public SearchEndpointBuilder(string apiKey, string searchQuery) : base(EndpointConstants.MoviesSearchEndpoint, apiKey)
		{
			Sb.AppendFormat("&q={0}", HttpUtility.UrlEncode(searchQuery));
		}
	}
}
