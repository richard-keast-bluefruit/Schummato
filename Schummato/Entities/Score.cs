using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;

namespace Schummato.Entities
{
    /// <summary>
    /// A score for a movie
    /// </summary>
    [DataContract]
	public class Score : PropertyParsingEntityBase
	{

        /// <summary>
        /// Initializes a new instance of the <see cref="Score"/> class.
        /// </summary>
        /// <param name="entity">The entity.</param>
		public Score(JProperty entity) : base(entity) {}



        /// <summary>
        /// Gets the type of the score, ie. critics, audience
        /// </summary>
        /// <value>
        /// The type of the score.
        /// </value>
        [DataMember]
		public string ScoreType { get; internal set; }

        /// <summary>
        /// Gets the value.
        /// </summary>
        [DataMember]
		public int Value { get; internal set; }



        /// <summary>
        /// Parses json to hydrate this object.
        /// </summary>
        /// <param name="entity">The entity.</param>
		public override void Parse(JProperty jScore)
		{
			ScoreType = jScore.Name;

			Value = jScore.Value.Value<int>();
		}
	}
}
