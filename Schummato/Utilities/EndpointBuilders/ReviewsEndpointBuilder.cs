using Schummato.Entities;

namespace Schummato.Utilities.EndpointBuilders
{
    /// <summary>
    /// Builder that helps safely build the endpoint string for Reviews
    /// </summary>
	public class ReviewsEndpointBuilder : PagingEndpointBuilderBase
	{
		public ReviewsEndpointBuilder(string apiKey, int movieId) : base(string.Format(EndpointConstants.ReviewsEndpoint, movieId), apiKey) { }

		public void SetReviewType(Review.ReviewType reviewType)
		{
			Sb.Append("&review_type=");

			switch (reviewType)
			{
				case Review.ReviewType.TopCritic:
					Sb.Append("top_critic");
					break;
				case Review.ReviewType.DVD:
					Sb.Append("dvd");
					break;
				default:
					Sb.Append("all");
					break;
			}
		}
	}

    public static class ReviewsEndpointBuilderExtensions
    {
        public static ReviewsEndpointBuilder WithReviewType(this ReviewsEndpointBuilder reviewsEndpointBuilder, Review.ReviewType reviewType)
        {
            reviewsEndpointBuilder.SetReviewType(reviewType);
            return reviewsEndpointBuilder;
        }
    }
}
