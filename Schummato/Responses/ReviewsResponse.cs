using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;
using Schummato.Entities;
using Schummato.Utilities;

namespace Schummato.Responses
{
    /// <summary>
    /// A response object containing a collection of reviews. Also contains a total count of all the reviews.
    /// </summary>
    [DataContract]
	public class ReviewsResponse : ObjectParsingEntityBase
	{

        /// <summary>
        /// Initializes a new instance of the <see cref="ReviewsResponse"/> class.
        /// </summary>
        /// <param name="json">The json.</param>
		public ReviewsResponse(string json) : base(json) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="ReviewsResponse"/> class.
        /// </summary>
        /// <param name="entity">The entity.</param>
		public ReviewsResponse(JObject entity) : base(entity) {}



        /// <summary>
        /// Gets the reviews.
        /// </summary>
        [DataMember]
		public List<Review> Reviews { get; internal set; }

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

			Reviews = new List<Review>();
			foreach (var jReview in entity["reviews"].Cast<JObject>())
			{
				Reviews.Add(new Review(jReview));
			}
		}
	}
}
