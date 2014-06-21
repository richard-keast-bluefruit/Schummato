using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;
using Schummato.Utilities;

namespace Schummato.Entities
{
    /// <summary>
    /// An actor in a movie
    /// </summary>
    [DataContract]
    public class Actor : ObjectParsingEntityBase
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Actor"/> class.
        /// </summary>
        /// <param name="json">The json.</param>
        public Actor(string json) : base(json) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Actor"/> class.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public Actor(JObject entity) : base(entity) { }



        /// <summary>
        /// Gets the characters.
        /// </summary>
        [DataMember]
        public List<string> Characters { get; internal set; }

        /// <summary>
        /// Gets the name.
        /// </summary>
        [DataMember]
        public string Name { get; internal set; }




        /// <summary>
        /// Parses json to hydrate this object.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public override void Parse(JObject entity)
        {
            Name = entity.TryGetProperty<string>("name");

            ParseCharacters(entity);
        }

        private void ParseCharacters(JObject entity)
        {
            Characters = new List<string>();

            JToken characters;

            if (entity.TryGetValue("characters", out characters))
            {
                foreach (var character in characters)
                {
                    Characters.Add(character.Value<string>());
                }
            }
        }
    }
}
