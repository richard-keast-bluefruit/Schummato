using Schummato.Entities;

namespace Schummato.Utilities.EndpointBuilders
{
    /// <summary>
    /// Builder that helps safely build the endpoint string for Movie Alias
    /// </summary>
	public class MovieAliasEndpointBuilder : EndpointBuilderBase
	{

        /// <summary>
        /// Initializes a new instance of the <see cref="MovieAliasEndpointBuilder"/> class.
        /// </summary>
        /// <param name="apiKey">The API key.</param>
        /// <param name="aliasId">The alias id.</param>
        /// <param name="aliasType">Type of the alias.</param>
		public MovieAliasEndpointBuilder(string apiKey, string aliasId, Movie.AliasType aliasType) : base(EndpointConstants.MovieAliasEndpoint, apiKey)
		{
			string type;

			switch (aliasType)
			{
				case Movie.AliasType.IMDB:
					type = "imdb";
					break;
				default:
					type = "imdb";
					break;
			}

			Sb.AppendFormat("&type={0}&id={1}", type, aliasId);
		}
	}
}
