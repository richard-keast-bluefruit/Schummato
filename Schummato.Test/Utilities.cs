using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Schummato.Test
{
    public static class Utilities
    {
        public static string GetSearchJsonResponse()
        {
            return @"{
    ""total"": 620,
    ""movies"": [{
        ""id"": ""11583"",
        ""title"": ""Jack"",
        ""year"": 1996,
        ""mpaa_rating"": ""PG-13"",
        ""runtime"": 114,
        ""release_dates"": {
            ""theater"": ""1996-08-09"",
            ""dvd"": ""2004-08-03""
        },
        ""ratings"": {
            ""critics_rating"": ""Rotten"",
            ""critics_score"": 17,
            ""audience_rating"": ""Spilled"",
            ""audience_score"": 50
        },
        ""synopsis"": """",
        ""posters"": {
            ""thumbnail"": ""http://content9.flixster.com/movie/26/14/261407_tmb.jpg"",
            ""profile"": ""http://content9.flixster.com/movie/26/14/261407_tmb.jpg"",
            ""detailed"": ""http://content9.flixster.com/movie/26/14/261407_tmb.jpg"",
            ""original"": ""http://content9.flixster.com/movie/26/14/261407_tmb.jpg""
        },
        ""abridged_cast"": [{
            ""name"": ""Robin Williams"",
            ""id"": ""162652387"",
            ""characters"": [""Jack Powell""]
        }, {
            ""name"": ""Diane Lane"",
            ""id"": ""162652926"",
            ""characters"": [""Karen Powell""]
        }, {
            ""name"": ""Jennifer Lopez"",
            ""id"": ""162652167"",
            ""characters"": [""Miss Marquez""]
        }, {
            ""name"": ""Brian Kerwin"",
            ""id"": ""162673867"",
            ""characters"": [""PowellBrian""]
        }, {
            ""name"": ""Fran Drescher"",
            ""id"": ""162670729"",
            ""characters"": [""Dolores Durante""]
        }],
        ""alternate_ids"": {
            ""imdb"": ""0116669""
        },
        ""links"": {
            ""self"": ""http://api.rottentomatoes.com/api/public/v1.0/movies/11583.json"",
            ""alternate"": ""http://www.rottentomatoes.com/m/1072875-jack/"",
            ""cast"": ""http://api.rottentomatoes.com/api/public/v1.0/movies/11583/cast.json"",
            ""reviews"": ""http://api.rottentomatoes.com/api/public/v1.0/movies/11583/reviews.json"",
            ""similar"": ""http://api.rottentomatoes.com/api/public/v1.0/movies/11583/similar.json""
        }
    }, {
        ""id"": ""770673958"",
        ""title"": ""Jack"",
        ""year"": 2003,
        ""mpaa_rating"": ""PG-13"",
        ""runtime"": 145,
        ""release_dates"": {
            ""theater"": ""2003-01-11"",
            ""dvd"": ""2004-12-07""
        },
        ""ratings"": {
            ""critics_score"": -1,
            ""audience_rating"": ""Upright"",
            ""audience_score"": 62
        },
        ""synopsis"": """",
        ""posters"": {
            ""thumbnail"": ""http://content7.flixster.com/movie/93/43/76/9343769_tmb.jpg"",
            ""profile"": ""http://content7.flixster.com/movie/93/43/76/9343769_tmb.jpg"",
            ""detailed"": ""http://content7.flixster.com/movie/93/43/76/9343769_tmb.jpg"",
            ""original"": ""http://content7.flixster.com/movie/93/43/76/9343769_tmb.jpg""
        },
        ""abridged_cast"": [{
            ""name"": ""Andrew Airlie"",
            ""id"": ""410722795"",
            ""characters"": [""Michael""]
        }, {
            ""name"": ""Erich Anderson"",
            ""id"": ""162701121"",
            ""characters"": [""Steve""]
        }, {
            ""name"": ""Stockard Channing"",
            ""id"": ""162676523"",
            ""characters"": [""Anne""]
        }, {
            ""name"": ""Wendy Crewson"",
            ""id"": ""162656175"",
            ""characters"": [""Elaine""]
        }, {
            ""name"": ""Jano Frandsen"",
            ""id"": ""770743933"",
            ""characters"": [""John""]
        }],
        ""alternate_ids"": {
            ""imdb"": ""0257568""
        },
        ""links"": {
            ""self"": ""http://api.rottentomatoes.com/api/public/v1.0/movies/770673958.json"",
            ""alternate"": ""http://www.rottentomatoes.com/m/1136750-jack/"",
            ""cast"": ""http://api.rottentomatoes.com/api/public/v1.0/movies/770673958/cast.json"",
            ""reviews"": ""http://api.rottentomatoes.com/api/public/v1.0/movies/770673958/reviews.json"",
            ""similar"": ""http://api.rottentomatoes.com/api/public/v1.0/movies/770673958/similar.json""
        }
    }, {
        ""id"": ""771357236"",
        ""title"": ""Jack"",
        ""year"": 2013,
        ""mpaa_rating"": ""Unrated"",
        ""runtime"": 89,
        ""release_dates"": {},
        ""ratings"": {
            ""critics_score"": -1,
            ""audience_score"": 0
        },
        ""synopsis"": ""Rick Roberts stars as Canadian former federal New Democratic Party leader Jack Layton in this biopic tracing the politician's courtship of his wife Olivia Chow, as well as his arduous yet successful 2011 election campaign. ~ Jason Buchanan, Rovi"",
        ""posters"": {
            ""thumbnail"": ""http://images.rottentomatoescdn.com/images/redesign/poster_default_thumb.gif"",
            ""profile"": ""http://images.rottentomatoescdn.com/images/redesign/poster_default_thumb.gif"",
            ""detailed"": ""http://images.rottentomatoescdn.com/images/redesign/poster_default_thumb.gif"",
            ""original"": ""http://images.rottentomatoescdn.com/images/redesign/poster_default_thumb.gif""
        },
        ""abridged_cast"": [{
            ""name"": ""Rick Roberts"",
            ""id"": ""770672953"",
            ""characters"": [""Jack Layton""]
        }],
        ""alternate_ids"": {
            ""imdb"": ""2253566""
        },
        ""links"": {
            ""self"": ""http://api.rottentomatoes.com/api/public/v1.0/movies/771357236.json"",
            ""alternate"": ""http://www.rottentomatoes.com/m/jack_2013/"",
            ""cast"": ""http://api.rottentomatoes.com/api/public/v1.0/movies/771357236/cast.json"",
            ""reviews"": ""http://api.rottentomatoes.com/api/public/v1.0/movies/771357236/reviews.json"",
            ""similar"": ""http://api.rottentomatoes.com/api/public/v1.0/movies/771357236/similar.json""
        }
    }, {
        ""id"": ""771375393"",
        ""title"": ""Jack"",
        ""year"": 2014,
        ""mpaa_rating"": ""Unrated"",
        ""runtime"": 103,
        ""release_dates"": {},
        ""ratings"": {
            ""critics_score"": -1,
            ""audience_score"": 0
        },
        ""synopsis"": ""For JACK (10), having a family is the most important thing in the world. Then, one day, his mother disappears. Together with his younger brother MANUEL (6), he embarks on a journey to find her... the journey of a boy who has learnt from an early age to take responsibility. In the end, his brave and startling decision holds up a mirror to all of us."",
        ""posters"": {
            ""thumbnail"": ""http://images.rottentomatoescdn.com/images/redesign/poster_default_thumb.gif"",
            ""profile"": ""http://images.rottentomatoescdn.com/images/redesign/poster_default_thumb.gif"",
            ""detailed"": ""http://images.rottentomatoescdn.com/images/redesign/poster_default_thumb.gif"",
            ""original"": ""http://images.rottentomatoescdn.com/images/redesign/poster_default_thumb.gif""
        },
        ""abridged_cast"": [{
            ""name"": ""Ivo Pietzcker"",
            ""id"": ""771478730""
        }, {
            ""name"": ""Georg Arms"",
            ""id"": ""771478731""
        }, {
            ""name"": ""Luise Heyer"",
            ""id"": ""771378607""
        }, {
            ""name"": ""Vincent Redetzki"",
            ""id"": ""381421956""
        }, {
            ""name"": ""Jakob Matschenz"",
            ""id"": ""771021479""
        }],
        ""alternate_ids"": {
            ""imdb"": ""3469918""
        },
        ""links"": {
            ""self"": ""http://api.rottentomatoes.com/api/public/v1.0/movies/771375393.json"",
            ""alternate"": ""http://www.rottentomatoes.com/m/771375393/"",
            ""cast"": ""http://api.rottentomatoes.com/api/public/v1.0/movies/771375393/cast.json"",
            ""reviews"": ""http://api.rottentomatoes.com/api/public/v1.0/movies/771375393/reviews.json"",
            ""similar"": ""http://api.rottentomatoes.com/api/public/v1.0/movies/771375393/similar.json""
        }
    }, {
        ""id"": ""770813677"",
        ""title"": ""The Karate Kid"",
        ""year"": 2010,
        ""mpaa_rating"": ""PG"",
        ""runtime"": 140,
        ""critics_consensus"": """",
        ""release_dates"": {
            ""theater"": ""2010-06-11"",
            ""dvd"": ""2010-10-05""
        },
        ""ratings"": {
            ""critics_rating"": ""Fresh"",
            ""critics_score"": 66,
            ""audience_rating"": ""Upright"",
            ""audience_score"": 67
        },
        ""synopsis"": ""When a 12-year-old from Detroit moves to China with his mother and incurs the wrath of the class bully at his new school, he makes an unlikely ally in the form of his aging maintenance man, a kung fu master who teaches him the secrets to self-defense. Upon arriving at his new school, Dre Parker (Jaden Smith) develops a powerful crush on pretty classmate Mei Ying. The feeling is mutual, although the cultural divide between Dre and Mei Ying makes a friendship unlikely, and romance impossible. When cruel classmate and kung fu prodigy Cheng learns of Dre's feelings for Mei Ying, he harasses and humiliates the young outsider in front of the entire school. With no one to turn to for help, Dre confides his fears in kindly maintenance man Mr. Han (Jackie Chan), a kung fu master who knows that serenity and maturity -- not punches and power -- are the true keys to mastering the martial arts. As Dre prepares to face down his intimidating tormentor, he begins to realize that the real fight is just beginning. ~ Jason Buchanan, Rovi"",
        ""posters"": {
            ""thumbnail"": ""http://content7.flixster.com/movie/11/17/10/11171073_tmb.jpg"",
            ""profile"": ""http://content7.flixster.com/movie/11/17/10/11171073_tmb.jpg"",
            ""detailed"": ""http://content7.flixster.com/movie/11/17/10/11171073_tmb.jpg"",
            ""original"": ""http://content7.flixster.com/movie/11/17/10/11171073_tmb.jpg""
        },
        ""abridged_cast"": [{
            ""name"": ""Jaden Smith"",
            ""id"": ""364618979"",
            ""characters"": [""Dre Parker""]
        }, {
            ""name"": ""Jackie Chan"",
            ""id"": ""162661013"",
            ""characters"": [""Mr. Han""]
        }, {
            ""name"": ""Taraji P. Henson"",
            ""id"": ""598455133"",
            ""characters"": [""Sherry Parker""]
        }, {
            ""name"": ""Han Wenwen"",
            ""id"": ""770755150"",
            ""characters"": [""Meiying""]
        }, {
            ""name"": ""Rongguang Yu"",
            ""id"": ""162683344"",
            ""characters"": [""Master Li""]
        }],
        ""alternate_ids"": {
            ""imdb"": ""1155076""
        },
        ""links"": {
            ""self"": ""http://api.rottentomatoes.com/api/public/v1.0/movies/770813677.json"",
            ""alternate"": ""http://www.rottentomatoes.com/m/karate_kid_2010/"",
            ""cast"": ""http://api.rottentomatoes.com/api/public/v1.0/movies/770813677/cast.json"",
            ""reviews"": ""http://api.rottentomatoes.com/api/public/v1.0/movies/770813677/reviews.json"",
            ""similar"": ""http://api.rottentomatoes.com/api/public/v1.0/movies/770813677/similar.json""
        }
    }, {
        ""id"": ""770805263"",
        ""title"": ""Percy Jackson & the Olympians: The Lightning Thief"",
        ""year"": 2010,
        ""mpaa_rating"": ""PG"",
        ""runtime"": 83,
        ""critics_consensus"": """",
        ""release_dates"": {
            ""theater"": ""2010-02-12"",
            ""dvd"": ""2010-06-29""
        },
        ""ratings"": {
            ""critics_rating"": ""Rotten"",
            ""critics_score"": 49,
            ""audience_rating"": ""Spilled"",
            ""audience_score"": 53
        },
        ""synopsis"": ""A teenager discovers he's the descendant of a Greek god and sets out on an adventure to settle an on-going battle between the gods."",
        ""posters"": {
            ""thumbnail"": ""http://content6.flixster.com/movie/10/94/11/10941176_tmb.jpg"",
            ""profile"": ""http://content6.flixster.com/movie/10/94/11/10941176_tmb.jpg"",
            ""detailed"": ""http://content6.flixster.com/movie/10/94/11/10941176_tmb.jpg"",
            ""original"": ""http://content6.flixster.com/movie/10/94/11/10941176_tmb.jpg""
        },
        ""abridged_cast"": [{
            ""name"": ""Logan Lerman"",
            ""id"": ""341816559"",
            ""characters"": [""Percy Jackson""]
        }, {
            ""name"": ""Brandon T. Jackson"",
            ""id"": ""770694652"",
            ""characters"": [""Grover""]
        }, {
            ""name"": ""Alexandra Daddario"",
            ""id"": ""770777867"",
            ""characters"": [""Annabeth""]
        }, {
            ""name"": ""Jake Abel"",
            ""id"": ""770673230"",
            ""characters"": [""Luke""]
        }, {
            ""name"": ""Sean Bean"",
            ""id"": ""162652874"",
            ""characters"": [""Zeus""]
        }],
        ""alternate_ids"": {
            ""imdb"": ""0814255""
        },
        ""links"": {
            ""self"": ""http://api.rottentomatoes.com/api/public/v1.0/movies/770805263.json"",
            ""alternate"": ""http://www.rottentomatoes.com/m/0814255/"",
            ""cast"": ""http://api.rottentomatoes.com/api/public/v1.0/movies/770805263/cast.json"",
            ""reviews"": ""http://api.rottentomatoes.com/api/public/v1.0/movies/770805263/reviews.json"",
            ""similar"": ""http://api.rottentomatoes.com/api/public/v1.0/movies/770805263/similar.json""
        }
    }, {
        ""id"": ""770814825"",
        ""title"": ""Michael Jackson's This Is It"",
        ""year"": 2009,
        ""mpaa_rating"": ""PG"",
        ""runtime"": 121,
        ""critics_consensus"": """",
        ""release_dates"": {
            ""theater"": ""2009-10-28"",
            ""dvd"": ""2010-01-26""
        },
        ""ratings"": {
            ""critics_rating"": ""Certified Fresh"",
            ""critics_score"": 81,
            ""audience_rating"": ""Upright"",
            ""audience_score"": 82
        },
        ""synopsis"": """",
        ""posters"": {
            ""thumbnail"": ""http://content6.flixster.com/movie/10/89/74/10897428_tmb.jpg"",
            ""profile"": ""http://content6.flixster.com/movie/10/89/74/10897428_tmb.jpg"",
            ""detailed"": ""http://content6.flixster.com/movie/10/89/74/10897428_tmb.jpg"",
            ""original"": ""http://content6.flixster.com/movie/10/89/74/10897428_tmb.jpg""
        },
        ""abridged_cast"": [{
            ""name"": ""Michael Jackson"",
            ""id"": ""162655885""
        }],
        ""alternate_ids"": {
            ""imdb"": ""1477715""
        },
        ""links"": {
            ""self"": ""http://api.rottentomatoes.com/api/public/v1.0/movies/770814825.json"",
            ""alternate"": ""http://www.rottentomatoes.com/m/michael_jackson_this_is_it/"",
            ""cast"": ""http://api.rottentomatoes.com/api/public/v1.0/movies/770814825/cast.json"",
            ""reviews"": ""http://api.rottentomatoes.com/api/public/v1.0/movies/770814825/reviews.json"",
            ""similar"": ""http://api.rottentomatoes.com/api/public/v1.0/movies/770814825/similar.json""
        }
    }, {
        ""id"": ""287865350"",
        ""title"": ""Jackass: Number Two"",
        ""year"": 2006,
        ""mpaa_rating"": ""R"",
        ""runtime"": 92,
        ""critics_consensus"": """",
        ""release_dates"": {
            ""theater"": ""2006-09-22"",
            ""dvd"": ""2006-12-26""
        },
        ""ratings"": {
            ""critics_rating"": ""Fresh"",
            ""critics_score"": 63,
            ""audience_rating"": ""Upright"",
            ""audience_score"": 81
        },
        ""synopsis"": """",
        ""posters"": {
            ""thumbnail"": ""http://content8.flixster.com/movie/10/88/83/10888302_tmb.jpg"",
            ""profile"": ""http://content8.flixster.com/movie/10/88/83/10888302_tmb.jpg"",
            ""detailed"": ""http://content8.flixster.com/movie/10/88/83/10888302_tmb.jpg"",
            ""original"": ""http://content8.flixster.com/movie/10/88/83/10888302_tmb.jpg""
        },
        ""abridged_cast"": [{
            ""name"": ""Johnny Knoxville"",
            ""id"": ""162652591""
        }, {
            ""name"": ""Stephen 'Steve-O' Glover"",
            ""id"": ""326392825""
        }, {
            ""name"": ""Chris Pontius"",
            ""id"": ""162692333""
        }, {
            ""name"": ""Ryan Dunn"",
            ""id"": ""335720003""
        }, {
            ""name"": ""Jason \""Wee Man\"" Acuna"",
            ""id"": ""770898347""
        }],
        ""alternate_ids"": {
            ""imdb"": ""0493430""
        },
        ""links"": {
            ""self"": ""http://api.rottentomatoes.com/api/public/v1.0/movies/287865350.json"",
            ""alternate"": ""http://www.rottentomatoes.com/m/jackass_number_2/"",
            ""cast"": ""http://api.rottentomatoes.com/api/public/v1.0/movies/287865350/cast.json"",
            ""reviews"": ""http://api.rottentomatoes.com/api/public/v1.0/movies/287865350/reviews.json"",
            ""similar"": ""http://api.rottentomatoes.com/api/public/v1.0/movies/287865350/similar.json""
        }
    }, {
        ""id"": ""771360997"",
        ""title"": ""Jackass Presents: Bad Grandpa"",
        ""year"": 2013,
        ""mpaa_rating"": ""R"",
        ""runtime"": 92,
        ""critics_consensus"": """",
        ""release_dates"": {
            ""theater"": ""2013-10-25"",
            ""dvd"": ""2014-01-28""
        },
        ""ratings"": {
            ""critics_rating"": ""Fresh"",
            ""critics_score"": 60,
            ""audience_rating"": ""Upright"",
            ""audience_score"": 62
        },
        ""synopsis"": ""86 year-old Irving Zisman is on a journey across America with the most unlikely companion, his 8 year-old Grandson Billy in \""Jackass Presents: Bad Grandpa.\"" This October, the signature Jackass character Irving Zisman (Johnny Knoxville) and Billy (Jackson Nicoll) will take movie audiences along for the most insane hidden camera road trip ever captured on camera. Along the way Irving will introduce the young and impressionable Billy to people, places and situations that give new meaning to the term childrearing. The duo will encounter male strippers, disgruntled child beauty pageant contestants (and their equally disgruntled mothers), funeral home mourners, biker bar patrons and a whole lot of unsuspecting citizens. (c) Paramount"",
        ""posters"": {
            ""thumbnail"": ""http://content8.flixster.com/movie/11/17/31/11173102_tmb.jpg"",
            ""profile"": ""http://content8.flixster.com/movie/11/17/31/11173102_tmb.jpg"",
            ""detailed"": ""http://content8.flixster.com/movie/11/17/31/11173102_tmb.jpg"",
            ""original"": ""http://content8.flixster.com/movie/11/17/31/11173102_tmb.jpg""
        },
        ""abridged_cast"": [{
            ""name"": ""Johnny Knoxville"",
            ""id"": ""162652591"",
            ""characters"": [""Irving Zisman""]
        }, {
            ""name"": ""Jackson Nicoll"",
            ""id"": ""771091208"",
            ""characters"": [""Billy""]
        }, {
            ""name"": ""Spike Jonze"",
            ""id"": ""162689010"",
            ""characters"": [""Old Woman""]
        }, {
            ""name"": ""Georgina Cates"",
            ""id"": ""162726506"",
            ""characters"": [""Kimmy""]
        }, {
            ""name"": ""Blythe Barrington-Hughes"",
            ""id"": ""771427668"",
            ""characters"": [""Pageant Contestant""]
        }],
        ""alternate_ids"": {
            ""imdb"": ""3063516""
        },
        ""links"": {
            ""self"": ""http://api.rottentomatoes.com/api/public/v1.0/movies/771360997.json"",
            ""alternate"": ""http://www.rottentomatoes.com/m/jackass_presents_bad_grandpa/"",
            ""cast"": ""http://api.rottentomatoes.com/api/public/v1.0/movies/771360997/cast.json"",
            ""reviews"": ""http://api.rottentomatoes.com/api/public/v1.0/movies/771360997/reviews.json"",
            ""similar"": ""http://api.rottentomatoes.com/api/public/v1.0/movies/771360997/similar.json""
        }
    }, {
        ""id"": ""771257656"",
        ""title"": ""Percy Jackson: Sea of Monsters"",
        ""year"": 2013,
        ""mpaa_rating"": ""PG"",
        ""runtime"": 110,
        ""critics_consensus"": """",
        ""release_dates"": {
            ""theater"": ""2013-08-07"",
            ""dvd"": ""2013-12-17""
        },
        ""ratings"": {
            ""critics_rating"": ""Rotten"",
            ""critics_score"": 41,
            ""audience_rating"": ""Spilled"",
            ""audience_score"": 57
        },
        ""synopsis"": ""Percy Jackson, the son of Poseidon, continues his epic journey to fulfill his destiny, as he teams with his demigod friends to retrieve the Golden Fleece, which has the power to save their home and training ground, Camp Half-Blood."",
        ""posters"": {
            ""thumbnail"": ""http://content7.flixster.com/movie/11/17/26/11172689_tmb.jpg"",
            ""profile"": ""http://content7.flixster.com/movie/11/17/26/11172689_tmb.jpg"",
            ""detailed"": ""http://content7.flixster.com/movie/11/17/26/11172689_tmb.jpg"",
            ""original"": ""http://content7.flixster.com/movie/11/17/26/11172689_tmb.jpg""
        },
        ""abridged_cast"": [{
            ""name"": ""Logan Lerman"",
            ""id"": ""341816559"",
            ""characters"": [""Percy Jackson""]
        }, {
            ""name"": ""Alexandra Daddario"",
            ""id"": ""770777867"",
            ""characters"": [""Annabeth""]
        }, {
            ""name"": ""Brandon T. Jackson"",
            ""id"": ""770694652"",
            ""characters"": [""Grover""]
        }, {
            ""name"": ""Nathan Fillion"",
            ""id"": ""162654267"",
            ""characters"": [""Hermes""]
        }, {
            ""name"": ""Jake Abel"",
            ""id"": ""770673230"",
            ""characters"": [""Luke""]
        }],
        ""alternate_ids"": {
            ""imdb"": ""1854564""
        },
        ""links"": {
            ""self"": ""http://api.rottentomatoes.com/api/public/v1.0/movies/771257656.json"",
            ""alternate"": ""http://www.rottentomatoes.com/m/percy_jackson_sea_of_monsters/"",
            ""cast"": ""http://api.rottentomatoes.com/api/public/v1.0/movies/771257656/cast.json"",
            ""reviews"": ""http://api.rottentomatoes.com/api/public/v1.0/movies/771257656/reviews.json"",
            ""similar"": ""http://api.rottentomatoes.com/api/public/v1.0/movies/771257656/similar.json""
        }
    }],
    ""links"": {
        ""self"": ""http://api.rottentomatoes.com/api/public/v1.0/movies.json?q=Jack&page_limit=10&page=1"",
        ""next"": ""http://api.rottentomatoes.com/api/public/v1.0/movies.json?q=Jack&page_limit=10&page=2""
    },
    ""link_template"": ""http://api.rottentomatoes.com/api/public/v1.0/movies.json?q={search-term}&page_limit={results-per-page}&page={page-number}""
}";
        }
    }
}
