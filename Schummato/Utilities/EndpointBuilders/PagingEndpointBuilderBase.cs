using System.Web.UI;

namespace Schummato.Utilities.EndpointBuilders
{
    /// <summary>
    /// Base class for an endpoint builder who's results can be limited and paged
    /// </summary>
	public abstract class PagingEndpointBuilderBase : EndpointBuilderBase
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="PagingEndpointBuilderBase"/> class.
        /// </summary>
        /// <param name="baseAddress">The base address.</param>
        /// <param name="apiKey">The API key.</param>
		protected PagingEndpointBuilderBase(string baseAddress, string apiKey) : base(baseAddress, apiKey) {}

        /// <summary>
        /// Sets the page limit.
        /// </summary>
        /// <param name="pageLimit">The page limit.</param>
		public void SetPageLimit(int pageLimit)
		{
			Sb.AppendFormat("&page_limit={0}", pageLimit);
		}

        /// <summary>
        /// Sets the page number.
        /// </summary>
        /// <param name="pageNumber">The page number.</param>
		public void SetPageNumber(int pageNumber)
		{
			Sb.AppendFormat("&page={0}", pageNumber);
		}
	}

    public static class PagingEndpointBuilderBaseExtensions
    {
        public static PagingEndpointBuilderBase WithPageNumber(this PagingEndpointBuilderBase builderBase, int? pageNumber)
        {
            if (pageNumber.HasValue)
            {
                builderBase.SetPageNumber(pageNumber.Value);
            }
            return builderBase;
        }

        public static PagingEndpointBuilderBase WithPageLimit(this PagingEndpointBuilderBase builderBase, int? pageLimit)
        {
            if (pageLimit.HasValue)
            {
                builderBase.SetPageLimit(pageLimit.Value);
            }
            return builderBase;
        }
    }
}
