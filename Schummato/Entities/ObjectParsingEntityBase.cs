using System;
using Newtonsoft.Json.Linq;

namespace Schummato.Entities
{
    /// <summary>
    /// Base class for an object that parses json to hydrate itself
    /// </summary>
	public abstract class ObjectParsingEntityBase
	{

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectParsingEntityBase"/> class.
        /// </summary>
        /// <param name="json">The json.</param>
		protected ObjectParsingEntityBase(string json)
		{
			Parse(json);
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectParsingEntityBase"/> class.
        /// </summary>
        /// <param name="entity">The entity.</param>
		protected ObjectParsingEntityBase(JObject entity)
		{
			Parse(entity);
		}




        /// <summary>
        /// Parses json to hydrate this object.
        /// </summary>
        /// <param name="entity">The entity.</param>
		public abstract void Parse(JObject entity);

        /// <summary>
        /// Parses json to hydrate this object.
        /// </summary>
        /// <param name="entity">The entity.</param>
		protected void Parse(string json)
		{
			Parse(JObject.Parse(json));
		}
	}
}
