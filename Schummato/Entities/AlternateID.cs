using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;

namespace Schummato.Entities
{
    /// <summary>
    /// An alternate ID for a movie. Such as an IMDB identifer.
    /// </summary>
    [DataContract]
	public class AlternateID : PropertyParsingEntityBase
	{

        /// <summary>
        /// Initializes a new instance of the <see cref="AlternateID"/> class.
        /// </summary>
        /// <param name="entity">The entity.</param>
		public AlternateID(JProperty entity) : base(entity) {}



        /// <summary>
        /// Gets the ID.
        /// </summary>
        [DataMember]
		public string ID { get; internal set; }

        /// <summary>
        /// Gets the id source, ie. IMDB
        /// </summary>
        [DataMember]
		public string IdSource { get; internal set; }




        /// <summary>
        /// Parses json to hydrate this object.
        /// </summary>
        /// <param name="entity">The entity.</param>
		public override void Parse(JProperty entity)
		{
			IdSource = entity.Name;
			ID = entity.Value.Value<string>();
		}
	}
}
