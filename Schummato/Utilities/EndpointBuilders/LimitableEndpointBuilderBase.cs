using System.Web;

namespace Schummato.Utilities.EndpointBuilders
{
    /// <summary>
    /// Base class for an endpoint builder who's results can be limited
    /// </summary>
	public abstract class LimitableEndpointBuilderBase : EndpointBuilderBase
	{
		protected LimitableEndpointBuilderBase(string baseAddress, string apiKey) : base(baseAddress, apiKey) {}

        /// <summary>
        /// Sets the limit of results returned
        /// </summary>
        /// <param name="limit">The limit.</param>
		public void SetLimit(int limit)
		{
			Sb.AppendFormat("&limit={0}", limit);
		}
	}

    public static class LimitableEndpointBuilderBaseExtensions
    {
        public static LimitableEndpointBuilderBase WithLimit(this LimitableEndpointBuilderBase builderBase, int? limit)
        {
            if (limit.HasValue)
            {
                builderBase.SetLimit(limit.Value);
            }

            return builderBase;
        }
    }
}
