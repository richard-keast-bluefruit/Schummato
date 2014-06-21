using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;

namespace Schummato.Entities
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
	public class Rating : PropertyParsingEntityBase
	{

        /// <summary>
        /// Initializes a new instance of the <see cref="Rating"/> class.
        /// </summary>
        /// <param name="entity">The entity.</param>
		public Rating(JProperty entity) : base(entity) {}



        /// <summary>
        /// Gets the type of the rating, ie. audience rating or critic rating
        /// </summary>
        /// <value>
        /// The type of the rating.
        /// </value>
        [DataMember]
		public string RatingType { get; internal set; }

        /// <summary>
        /// Gets the value of the rating
        /// </summary>
        [DataMember]
		public string Value { get; internal set; }



        /// <summary>
        /// Parses json to hydrate this object.
        /// </summary>
        /// <param name="entity">The entity.</param>
		public override void Parse(JProperty jRating)
		{
			RatingType = jRating.Name;

			Value = jRating.Value.ToString();
		}
	}
}
