using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;
using Schummato.Entities;

namespace Schummato.Responses
{
    /// <summary>
    /// A response object containing a collection of lists
    /// </summary>
    [DataContract]
	public class ListsReponse : ObjectParsingEntityBase
	{

        /// <summary>
        /// Initializes a new instance of the <see cref="ListsReponse"/> class.
        /// </summary>
        /// <param name="json">The json.</param>
		public ListsReponse(string json) : base(json) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="ListsReponse"/> class.
        /// </summary>
        /// <param name="entity">The entity.</param>
		public ListsReponse(JObject entity) : base(entity) {}



        /// <summary>
        /// Gets the links.
        /// </summary>
        [DataMember]
		public List<Link> Links { get; internal set; }



        /// <summary>
        /// Parses json to hydrate this object.
        /// </summary>
        /// <param name="entity">The entity.</param>
 		public override void Parse(JObject entity)
		{
			Links = new List<Link>();

			foreach (var jLink in entity["links"].Cast<JProperty>())
			{
				Links.Add(new Link(jLink));
			}
		}
	}
}
