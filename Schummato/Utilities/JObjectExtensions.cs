using System;
using System.Diagnostics;
using Newtonsoft.Json.Linq;

namespace Schummato.Utilities
{
	internal static class JObjectExtensions
	{
        /// <summary>
        /// Tries the get the value of the property specified. Returns the default value of T if it can't retrieve the value.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="jObject">The j object.</param>
        /// <param name="propertyName">Name of the property.</param>
        /// <returns></returns>
		public static T TryGetProperty<T>(this JToken jObject, string propertyName)
		{
            if (jObject as JObject == null)
                throw new ArgumentException("jObject parameter was not an object that inherits from type JObject.");

			JToken value;

        	var returnValue = default(T);

			if ((jObject as JObject).TryGetValue(propertyName, out value))
			{
				try
				{
					returnValue = value.Value<T>();
				}
				catch (Exception)
				{
                    Debug.Write("Exception thrown trying to get value from JObject");
				}
			}

        	return returnValue;
		}
	}
}
