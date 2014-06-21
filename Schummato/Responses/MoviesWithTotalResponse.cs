using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;
using Schummato.Utilities;

namespace Schummato.Responses
{
    /// <summary>
    /// A response object with a collection of movies. May be a subset of the total results. This object also contains a total count for paging purposes.
    /// </summary>
    [DataContract]
	public class MoviesWithTotalResponse : MoviesResponse
	{

        /// <summary>
        /// Initializes a new instance of the <see cref="MoviesWithTotalResponse"/> class.
        /// </summary>
        /// <param name="json">The json.</param>
		public MoviesWithTotalResponse(string json) : base(json) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="MoviesWithTotalResponse"/> class.
        /// </summary>
        /// <param name="entity">The entity.</param>
		public MoviesWithTotalResponse(JObject entity) : base(entity) {}




        /// <summary>
        /// Gets the total.
        /// </summary>
        [DataMember]
		public int Total { get; internal set; }



        /// <summary>
        /// Parses json to hydrate this object.
        /// </summary>
        /// <param name="entity">The entity.</param>
		public override void Parse(JObject entity)
		{
			Total = entity.TryGetProperty<int>("total");

			base.Parse(entity);
		}
	}
}
