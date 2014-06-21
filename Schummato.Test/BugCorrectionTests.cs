using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Schummato.Test
{
	[TestClass]
	public class BugCorrectionTests
	{
		[TestMethod]
		public void TestSearchParseWithInvalidDate()
		{
			var api = new RottenTomatoesAPI();
			var result = api.PerformSearch("Incredible Hulk");

			Assert.IsTrue(result.Total > 0);
			Assert.IsTrue(result.Movies.Count > 0);
		}
	}
}
