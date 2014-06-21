using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;

namespace Schummato.Entities
{
    /// <summary>
    /// Information for an image related to a movie
    /// </summary>
    [DataContract]
	public class Poster : PropertyParsingEntityBase
	{

        /// <summary>
        /// Initializes a new instance of the <see cref="Poster"/> class.
        /// </summary>
        /// <param name="entity">The entity.</param>
		public Poster(JProperty entity) : base(entity) {}



        /// <summary>
        /// Gets the image URL.
        /// </summary>
        [DataMember]
		public string ImageUrl { get; internal set; }

        /// <summary>
        /// Gets the type of the poster.
        /// </summary>
        /// <value>
        /// The type of the poster.
        /// </value>
        [DataMember]
		public string PosterType { get; internal set; }



        /// <summary>
        /// Parses json to hydrate this object.
        /// </summary>
        /// <param name="entity">The entity.</param>
		public override void Parse(JProperty entity)
		{
			PosterType = entity.Name;
			ImageUrl = entity.Value.Value<string>();
		}
	}
}
