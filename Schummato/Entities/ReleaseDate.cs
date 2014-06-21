using System;
using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;

namespace Schummato.Entities
{
    /// <summary>
    /// Information for a release date
    /// </summary>
    [DataContract]
	public class ReleaseDate : PropertyParsingEntityBase
	{

        /// <summary>
        /// Initializes a new instance of the <see cref="ReleaseDate"/> class.
        /// </summary>
        /// <param name="entity">The entity.</param>
		public ReleaseDate(JProperty entity) : base(entity) {}



        /// <summary>
        /// Gets the date of the release
        /// </summary>
        [DataMember]
		public DateTime? Date { get; internal set; }


        /// <summary>
        /// Gets the type of the release, ie. DVD, theatrical
        /// </summary>
        [DataMember]
		public string ReleaseType { get; internal set; }



        /// <summary>
        /// Parses json to hydrate this object.
        /// </summary>
        /// <param name="entity">The entity.</param>
		public override void Parse(JProperty jRelease)
		{
			ReleaseType = jRelease.Name;

			if (!string.IsNullOrWhiteSpace(jRelease.Value.ToString()))
			{
				DateTime tryDate;
				Date = DateTime.TryParse(jRelease.Value.ToString(), out tryDate) ? tryDate : new DateTime?();
			}
			
		}
	}
}
