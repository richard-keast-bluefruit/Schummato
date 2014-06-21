using Microsoft.VisualStudio.TestTools.UnitTesting;
using Schummato.Entities;

namespace Schummato.Test
{
	[TestClass]
	public class ApiTests
	{
		[TestMethod]
		public void TestSearchParsing()
		{
			var api = new RottenTomatoesAPI();
			var result = api.PerformSearch("Jack");

			Assert.IsTrue(result.Total > 0);
			Assert.IsTrue(result.Movies.Count > 0);
		}

		[TestMethod]
		public void TestListsParsing()
		{
			var api = new RottenTomatoesAPI();
			var result = api.GetListsDirectory();

			Assert.IsTrue(result.Links.Count > 0);
		}		
		
		[TestMethod]
		public void TestMovieListsParsing()
		{
			var api = new RottenTomatoesAPI();
			var result = api.GetMovieListsDirectory();

			Assert.IsTrue(result.Links.Count > 0);
		}		
		
		[TestMethod]
		public void TestGetBoxOfficeMoviesParsing()
		{
			var api = new RottenTomatoesAPI();
			var result = api.GetBoxOfficeMovies();

			Assert.IsTrue(result.Movies.Count > 0);
		}		
		
		[TestMethod]
		public void TestGetInTheatersMoviesParsing()
		{
			var api = new RottenTomatoesAPI();
			var result = api.GetInTheaterMovies();

			Assert.IsTrue(result.Total > 0);
			Assert.IsTrue(result.Movies.Count > 0);
		}

		[TestMethod]
		public void TestGetOpeningMoviesParsing()
		{
			var api = new RottenTomatoesAPI();
			var result = api.GetOpeningMovies();

			Assert.IsTrue(result.Movies.Count > 0);
		}

		[TestMethod]
		public void TestGetUpcomingMoviesParsing()
		{
			var api = new RottenTomatoesAPI();
			var result = api.GetUpcomingMovies();

			Assert.IsTrue(result.Total > 0);
			Assert.IsTrue(result.Movies.Count > 0);
		}

		[TestMethod]
		public void TestDvdListsParsing()
		{
			var api = new RottenTomatoesAPI();
			var result = api.GetDVDListsDirectory();

			Assert.IsTrue(result.Links.Count > 0);
		}

		[TestMethod]
		public void TestGetTopRentalsParsing()
		{
			var api = new RottenTomatoesAPI();
			var result = api.GetTopRentals();

			Assert.IsTrue(result.Movies.Count > 0);
		}

		[TestMethod]
		public void TestGetCurrentReleaseDVDs()
		{
			var api = new RottenTomatoesAPI();
			var result = api.GetCurrentReleaseDVDs();

			Assert.IsTrue(result.Total > 0);
			Assert.IsTrue(result.Movies.Count > 0);
		}

		[TestMethod]
		public void TestNewCurrentReleaseDVDs()
		{
			var api = new RottenTomatoesAPI();
			var result = api.GetNewReleaseDVDs();

			Assert.IsTrue(result.Total > 0);
			Assert.IsTrue(result.Movies.Count > 0);
		}

		[TestMethod]
		public void TestGetUpcomingDVDs()
		{
			var api = new RottenTomatoesAPI();
			var result = api.GetUpcomingDVDs();

			Assert.IsTrue(result.Total > 0);
			Assert.IsTrue(result.Movies.Count > 0);
		}

		[TestMethod]
		public void TestGetMovieInfo()
		{
			var api = new RottenTomatoesAPI();
			var result = api.GetMovieInfo(770672122);

			Assert.IsNotNull(result.Result);
		}

		[TestMethod]
		public void TestGetMovieCast()
		{
			var api = new RottenTomatoesAPI();
			var result = api.GetMovieCast(770672122);

			Assert.IsTrue(result.Cast.Count > 0);
		}

		[TestMethod]
		public void TestGetClips()
		{
			var api = new RottenTomatoesAPI();
			var result = api.GetClips(770672122);

			Assert.IsTrue(result.Clips.Count > 0);
		}

		[TestMethod]
		public void TestGetReviews()
		{
			var api = new RottenTomatoesAPI();
			var result = api.GetSimilar(770672122);

			Assert.IsTrue(result.Movies.Count > 0);
		}

		[TestMethod]
		public void TestAlias()
		{
			var api = new RottenTomatoesAPI();
			var result = api.GetMovieByAlias("0031381", Movie.AliasType.IMDB);

			Assert.IsNotNull(result.Result);
		}

	}
}
