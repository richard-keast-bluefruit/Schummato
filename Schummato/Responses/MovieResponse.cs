using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;
using Schummato.Entities;

namespace Schummato.Responses
{
    /// <summary>
    /// A response object containing a single movie
    /// </summary>
    [DataContract]
	public class MovieResponse : ObjectParsingEntityBase
	{

        /// <summary>
        /// Initializes a new instance of the <see cref="MovieResponse"/> class.
        /// </summary>
        /// <param name="json">The json.</param>
		public MovieResponse(string json) : base(json) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="MovieResponse"/> class.
        /// </summary>
        /// <param name="entity">The entity.</param>
		public MovieResponse(JObject entity) : base(entity) {}



        /// <summary>
        /// Gets the result.
        /// </summary>
        [DataMember]
		public Movie Result { get; internal set; }



        /// <summary>
        /// Parses json to hydrate this object.
        /// </summary>
        /// <param name="entity">The entity.</param>
		public override void Parse(JObject entity)
		{
			Result = new Movie(entity);
		}
	}
}
