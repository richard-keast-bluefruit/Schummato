using Newtonsoft.Json.Linq;

namespace Schummato.Entities
{
    /// <summary>
    /// Base class for an entity that parses a json property
    /// </summary>
	public abstract class PropertyParsingEntityBase
	{

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyParsingEntityBase"/> class.
        /// </summary>
        /// <param name="entity">The entity.</param>
		protected PropertyParsingEntityBase(JProperty entity)
		{
			Parse(entity);
		}



        /// <summary>
        /// Parses json to hydrate this object.
        /// </summary>
        /// <param name="entity">The entity.</param>
		public abstract void Parse(JProperty entity);
	}
}
