using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;
using Schummato.Entities;

namespace Schummato.Responses
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
	public class ClipsResponse : ObjectParsingEntityBase
	{

        /// <summary>
        /// Initializes a new instance of the <see cref="ClipsResponse"/> class.
        /// </summary>
        /// <param name="json">The json.</param>
		public ClipsResponse(string json) : base(json) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="ClipsResponse"/> class.
        /// </summary>
        /// <param name="entity">The entity.</param>
		public ClipsResponse(JObject entity) : base(entity) {}



        /// <summary>
        /// Gets or sets the clips.
        /// </summary>
        /// <value>
        /// The clips.
        /// </value>
        [DataMember]
		public List<Clip> Clips { get; set; }



        /// <summary>
        /// Parses json to hydrate this object.
        /// </summary>
        /// <param name="entity">The entity.</param>
 		public override void Parse(JObject entity)
		{
			Clips = new List<Clip>();

			foreach (var jClip in entity["clips"].Cast<JObject>())
			{
				Clips.Add(new Clip(jClip));
			}
		}
	}
}
