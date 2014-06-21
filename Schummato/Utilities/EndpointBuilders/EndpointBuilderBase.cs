using System.Text;

namespace Schummato.Utilities.EndpointBuilders
{
    /// <summary>
    /// Base class for an endpoint builder
    /// </summary>
	public abstract class EndpointBuilderBase
	{

		protected readonly StringBuilder Sb;

        /// <summary>
        /// Sets the country.
        /// </summary>
        /// <param name="isoCountryCode">The iso country code.</param>
        public void SetCountry(string isoCountryCode)
        {
            Sb.AppendFormat("&country={0}", isoCountryCode);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EndpointBuilderBase"/> class.
        /// </summary>
        /// <param name="baseAddress">The base address.</param>
        /// <param name="apiKey">The API key.</param>
		protected EndpointBuilderBase(string baseAddress, string apiKey)
		{
			Sb = new StringBuilder(baseAddress);
			Sb.AppendFormat("?apiKey={0}", apiKey);
		}

        /// <summary>
        /// Returns a <see cref="System.String"/> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String"/> that represents this instance.
        /// </returns>
		public override string ToString()
		{
			return Sb.ToString();
		}
	}

    public static class EndpointBuilderBaseExtensions
    {
        public static EndpointBuilderBase WithCountry(this EndpointBuilderBase builderBase, string isoCountryCode)
        {
            if (!string.IsNullOrWhiteSpace(isoCountryCode))
            {
                builderBase.SetCountry(isoCountryCode);
            }

            return builderBase;
        }
    }
}
