using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;

namespace Schummato.Entities
{
    /// <summary>
    /// A fairly generic link class
    /// </summary>
    [DataContract]
	public class Link : PropertyParsingEntityBase
	{

        /// <summary>
        /// Initializes a new instance of the <see cref="Link"/> class.
        /// </summary>
        /// <param name="entity">The entity.</param>
		public Link(JProperty entity) : base(entity) {}



        /// <summary>
        /// Gets the type of the link.
        /// </summary>
        /// <value>
        /// The type of the link.
        /// </value>
        [DataMember]
		public string LinkType { get; internal set; }

        /// <summary>
        /// Gets the value.
        /// </summary>
        [DataMember]
		public string Value { get; internal set; }



        /// <summary>
        /// Parses json to hydrate this object.
        /// </summary>
        /// <param name="entity">The entity.</param>
		public override void Parse(JProperty entity)
		{
			LinkType = entity.Name;
			Value = entity.Value.Value<string>();
		}
	}
}
