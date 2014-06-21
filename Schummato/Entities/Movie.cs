using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;
using Schummato.Utilities;

namespace Schummato.Entities
{
    /// <summary>
    /// All the information rotten tomatoes has for a movie. Nothing is guaranteed to be populated. 
    /// Various bits and pieces are loaded depending on the endpoint the movie is coming from.
    /// </summary>
    [DataContract]
	public class Movie : ObjectParsingEntityBase
	{

        /// <summary>
        /// Supported alias id types
        /// </summary>
		public enum AliasType
		{
			IMDB
		}



        /// <summary>
        /// Initializes a new instance of the <see cref="Movie"/> class.
        /// </summary>
        /// <param name="json">The json.</param>
        public Movie(string json) : base(json) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="Movie"/> class.
        /// </summary>
        /// <param name="entity">The entity.</param>
		public Movie(JObject entity) : base(entity) {}



        /// <summary>
        /// Gets the alternate ids, ie. IMDB's identifier
        /// </summary>
        [DataMember]
        public List<AlternateID> AlternateIds { get; internal set; }

        /// <summary>
        /// Gets the cast.
        /// </summary>
        [DataMember]
        public List<Actor> Cast { get; internal set; }

        /// <summary>
        /// Gets the critics consensus.
        /// </summary>
        [DataMember]
		public string CriticsConsensus { get; internal set; }

        /// <summary>
        /// Gets the directors.
        /// </summary>
        [DataMember]
        public List<string> Directors { get; internal set; }

        /// <summary>
        /// Gets the genres.
        /// </summary>
        [DataMember]
        public List<string> Genres { get; internal set; }

        /// <summary>
        /// Gets the id.
        /// </summary>
        [DataMember]
        public int Id { get; internal set; }

        /// <summary>
        /// Gets the links.
        /// </summary>
        [DataMember]
        public List<Link> Links { get; internal set; }

        /// <summary>
        /// Gets the MPAA rating.
        /// </summary>
        [DataMember]
        public string MPAARating { get; internal set; }

        /// <summary>
        /// Gets the posters.
        /// </summary>
        [DataMember]
        public List<Poster> Posters { get; internal set; }

        /// <summary>
        /// Gets the ratings.
        /// </summary>
        [DataMember]
        public List<Rating> Ratings { get; internal set; }

        /// <summary>
        /// Gets the release dates.
        /// </summary>
        [DataMember]
        public List<ReleaseDate> ReleaseDates { get; internal set; }

        /// <summary>
        /// Gets the runtime.
        /// </summary>
        [DataMember]
        public int? Runtime { get; internal set; }

        /// <summary>
        /// Gets the scores.
        /// </summary>
        [DataMember]
        public List<Score> Scores { get; internal set; }

        /// <summary>
        /// Gets the studio.
        /// </summary>
        [DataMember]
        public string Studio { get; internal set; }

        /// <summary>
        /// Gets the synopsis.
        /// </summary>
        [DataMember]
        public string Synopsis { get; internal set; }

        /// <summary>
        /// Gets the title.
        /// </summary>
        [DataMember]
        public string Title { get; internal set; }

        /// <summary>
        /// Gets the year.
        /// </summary>
        [DataMember]
        public int Year { get; internal set; }



        /// <summary>
        /// Parses json to hydrate this object.
        /// </summary>
        /// <param name="entity">The entity.</param>
 		public override void Parse(JObject jMovie)
		{
            Id = jMovie.TryGetProperty<int>("id");

            Title = jMovie.TryGetProperty<string>("title");

            Year = jMovie.TryGetProperty<int>("year");

            ParseGenres(jMovie);

            MPAARating = jMovie.TryGetProperty<string>("mpaa_rating");

            ParseRuntime(jMovie);

            CriticsConsensus = jMovie.TryGetProperty<string>("critics_consensus");

            ParseReleaseDates(jMovie);

            ParseScoresAndRatings(jMovie);

            Synopsis = jMovie.TryGetProperty<string>("synopsis");

            ParsePosters(jMovie);

            ParseCast(jMovie);

            ParseDirectors(jMovie);

            Studio = jMovie.TryGetProperty<string>("studio");

            ParseAlternateIds(jMovie);

            ParseLinks(jMovie);
		}

        private void ParseAlternateIds(JObject jMovie)
        {
            AlternateIds = new List<AlternateID>();

            JToken alternateIds;
            if (jMovie.TryGetValue("alternate_ids", out alternateIds))
            {
                foreach (var jAlternateId in alternateIds.Cast<JProperty>())
                {
                    AlternateIds.Add(new AlternateID(jAlternateId));
                }
            }
        }

        private void ParseCast(JObject jMovie)
        {
            Cast = new List<Actor>();

            JToken actors;

            if (jMovie.TryGetValue("abridged_cast", out actors))
            {
                foreach (var jActor in actors.Cast<JObject>())
                {
                    Cast.Add(new Actor(jActor));
                }
            }
        }

        private void ParseDirectors(JObject jMovie)
        {
            Directors = new List<string>();

            JToken directors;

            if (jMovie.TryGetValue("abridged_directors", out directors))
            {
                foreach (var jDirector in directors)
                {
                    Directors.Add(jDirector["name"].Value<string>());
                }
            }
        }

        private void ParseGenres(JObject jMovie)
        {
            Genres = new List<string>();

            JToken genres;

            if (jMovie.TryGetValue("genres", out genres))
            {
                foreach (var jGenre in genres)
                {
                    Genres.Add(jGenre.Value<string>());
                }
            }
        }

        private void ParseLinks(JObject jMovie)
        {
            Links = new List<Link>();
            JToken links;
            if (jMovie.TryGetValue("links", out links))
            {
                foreach (var jLink in links.Cast<JProperty>())
                {
                    Links.Add(new Link(jLink));
                }
            }
        }

        private void ParsePosters(JObject jMovie)
        {
            Posters = new List<Poster>();

            JToken posters;

            if (jMovie.TryGetValue("posters", out posters))
            {
                foreach (var jPoster in posters.Cast<JProperty>())
                {
                    Posters.Add(new Poster(jPoster));
                }
            }
        }

        private void ParseReleaseDates(JObject jMovie)
        {
            ReleaseDates = new List<ReleaseDate>();

            JToken releaseDates;
            if (jMovie.TryGetValue("release_dates", out releaseDates))
            {
                foreach (var jRelease in releaseDates.Cast<JProperty>())
                {
                    ReleaseDates.Add(new ReleaseDate(jRelease));
                }
            }
        }

        private void ParseRuntime(JObject jMovie)
        {
            JToken runtimeToken;

            if (jMovie.TryGetValue("runtime", out runtimeToken))
            {
                if (!string.IsNullOrWhiteSpace(runtimeToken.Value<string>()))
                {
                    int runtime;
                    Runtime = int.TryParse(runtimeToken.Value<string>(), out runtime) ? runtime : new int?();
                }
            }
        }

        private void ParseScoresAndRatings(JObject jMovie)
        {
            Scores = new List<Score>();
            Ratings = new List<Rating>();

            JToken ratings;
            if (jMovie.TryGetValue("ratings", out ratings))
            {
                foreach (var jRating in ratings.Cast<JProperty>())
                {
                    if (jRating.Name.Contains("rating"))
                    {
                        Ratings.Add(new Rating(jRating));
                    }

                    if (jRating.Name.Contains("score"))
                    {
                        Scores.Add(new Score(jRating));
                    }
                }
            }
        }
	}
}
