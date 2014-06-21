using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;
using Schummato.Entities;

namespace Schummato.Responses
{
    /// <summary>
    /// A response object containing a collection of movies
    /// </summary>
    [DataContract]
	public class MoviesResponse : ObjectParsingEntityBase
	{

        /// <summary>
        /// Initializes a new instance of the <see cref="MoviesResponse"/> class.
        /// </summary>
        /// <param name="json">The json.</param>
		public MoviesResponse(string json) : base(json) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="MoviesResponse"/> class.
        /// </summary>
        /// <param name="entity">The entity.</param>
		public MoviesResponse(JObject entity) : base(entity) {}



        /// <summary>
        /// Gets the movies.
        /// </summary>
        [DataMember]
		public List<Movie> Movies { get; internal set; }



        /// <summary>
        /// Parses json to hydrate this object.
        /// </summary>
        /// <param name="entity">The entity.</param>
		public override void Parse(JObject entity)
		{
			Movies = new List<Movie>();
			foreach (var jMovie in entity["movies"].Cast<JObject>())
			{
				Movies.Add(new Movie(jMovie));
			}
		}
	}
}
