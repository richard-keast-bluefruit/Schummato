using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;
using Schummato.Entities;

namespace Schummato.Responses
{
    /// <summary>
    /// A response object containing a list of actors
    /// </summary>
    [DataContract]
	public class CastResponse : ObjectParsingEntityBase
	{

        /// <summary>
        /// Initializes a new instance of the <see cref="CastResponse"/> class.
        /// </summary>
        /// <param name="json">The json.</param>
		public CastResponse(string json) : base(json) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="CastResponse"/> class.
        /// </summary>
        /// <param name="entity">The entity.</param>
		public CastResponse(JObject entity) : base(entity) {}



        /// <summary>
        /// Gets the cast.
        /// </summary>
        [DataMember]
		public List<Actor> Cast { get; internal set; }



        /// <summary>
        /// Parses json to hydrate this object.
        /// </summary>
        /// <param name="entity">The entity.</param>
		public override void Parse(JObject entity)
		{
			Cast = new List<Actor>();

			foreach (var actor in entity["cast"].Cast<JObject>())
			{
				Cast.Add(new Actor(actor));
			}
		}
	}
}
