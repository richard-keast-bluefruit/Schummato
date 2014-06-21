using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;
using Schummato.Utilities;

namespace Schummato.Entities
{
    /// <summary>
    /// A review for a movie
    /// </summary>
    [DataContract]
	public class Review : ObjectParsingEntityBase
	{

        /// <summary>
        /// Indicates what type of review a review is
        /// </summary>
		public enum ReviewType
		{
			All,
			TopCritic,
			DVD
		}



        /// <summary>
        /// Initializes a new instance of the <see cref="Review"/> class.
        /// </summary>
        /// <param name="json">The json.</param>
		public Review(string json) : base(json) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="Review"/> class.
        /// </summary>
        /// <param name="entity">The entity.</param>
		public Review(JObject entity) : base(entity) {}



        /// <summary>
        /// Gets the critic.
        /// </summary>
        [DataMember]
		public string Critic { get; internal set; }

        /// <summary>
        /// Gets the date.
        /// </summary>
        [DataMember]
		public DateTime Date { get; internal set; }

        /// <summary>
        /// Gets the freshness.
        /// </summary>
        [DataMember]
		public string Freshness { get; internal set; }

        /// <summary>
        /// Gets the links.
        /// </summary>
        [DataMember]
		public List<Link> Links { get; internal set; }

        /// <summary>
        /// Gets the original score.
        /// </summary>
        [DataMember]
		public string OriginalScore { get; internal set; }

        /// <summary>
        /// Gets the publication.
        /// </summary>
        [DataMember]
		public string Publication { get; internal set; }

        /// <summary>
        /// Gets the quote.
        /// </summary>
        [DataMember]
		public string Quote { get; internal set; }



        /// <summary>
        /// Parses json to hydrate this object.
        /// </summary>
        /// <param name="entity">The entity.</param>
 		public override void Parse(JObject entity)
		{
			Critic = entity.TryGetProperty<string>("critic");

			JToken dateToken;

			if (entity.TryGetValue("date", out dateToken))
			{
				DateTime date;
				if (DateTime.TryParse(dateToken.Value<string>(), out date))
				{
					Date = date;
				}
			}

			OriginalScore = entity.TryGetProperty<string>("original_score");

			Freshness = entity.TryGetProperty<string>("freshness");

			Publication = entity.TryGetProperty<string>("publication");

			Quote = entity.TryGetProperty<string>("quote");

			Links = new List<Link>();
			foreach (var jLink in entity["links"].Cast<JProperty>())
			{
				Links.Add(new Link(jLink));
			}
		}
	}
}
