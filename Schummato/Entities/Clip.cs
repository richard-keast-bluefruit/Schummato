using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;
using Schummato.Utilities;

namespace Schummato.Entities
{
    /// <summary>
    /// A movie clip associated with a movie
    /// </summary>
    [DataContract]
	public class Clip : ObjectParsingEntityBase
	{

        /// <summary>
        /// Initializes a new instance of the <see cref="Clip"/> class.
        /// </summary>
        /// <param name="json">The json.</param>
		public Clip(string json) : base(json) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="Clip"/> class.
        /// </summary>
        /// <param name="entity">A Json.NET object</param>
		public Clip(JObject entity) : base(entity) {}



        /// <summary>
        /// Gets the duration of the movie clip
        /// </summary>
        [DataMember]
		public string Duration { get; internal set; }

        /// <summary>
        /// A collection of links that point to the clip
        /// </summary>
        [DataMember]
		public List<Link> Links { get; internal set; }

        /// <summary>
        /// A representative thumbnail for the clip
        /// </summary>
        [DataMember]
		public string Thumbnail { get; internal set; }

        /// <summary>
        /// Gets the title
        /// </summary>
        [DataMember]
		public string Title { get; internal set; }



        /// <summary>
        /// Parses json to hydrate this object.
        /// </summary>
        /// <param name="entity">The entity.</param>
		public override void Parse(JObject entity)
		{
			Title = entity.TryGetProperty<string>("title");
			Duration = entity.TryGetProperty<string>("duration");
			Thumbnail = entity.TryGetProperty<string>("thumbnail");

			Links = new List<Link>();
			JToken links;
			if (entity.TryGetValue("links", out links))
			{
				foreach (var link in links.Cast<JProperty>())
				{
					Links.Add(new Link(link));
				}
			}

		}
	}
}
