using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using TvShows.Models.Entities;

namespace TvShows.Models.DAL
{
	public class TvShowsInitializer : DropCreateDatabaseIfModelChanges<TvShowsContext>
	{
		protected override void Seed(TvShowsContext context)
		{
			var shows = new TvShow[] {
				new TvShow {
					ID = 1,
					Title = "House, M.D.",
					CreatedBy = "David Shore",
					Country = "United States",
					OriginalLanguage = "English",
					Summary = "The series' main character is Dr. Gregory House (Hugh Laurie), an unconventional, misanthropic medical genius who, despite his dependence on pain medication, leads a team of diagnosticians at the fictional Princeton–Plainsboro Teaching Hospital (PPTH) in New Jersey.",
					Website = "https://en.wikipedia.org/wiki/House_(TV_series)",
					UrlLogo = "https://upload.wikimedia.org/wikipedia/commons/e/e5/House_logo.svg"
				},
				new TvShow {
					ID = 2,
					Title = "Breaking Bad",
					CreatedBy = "Vince Gilligan",
					Country = "United States",
					OriginalLanguage = "English",
					Summary = "It tells the story of Walter White (Bryan Cranston), a struggling high school chemistry teacher diagnosed with inoperable lung cancer. Together with his former student Jesse Pinkman (Aaron Paul), White turns to a life of crime, producing and selling crystallized methamphetamine to secure his family's financial future before he dies, while navigating the dangers of the criminal world.",
					Website = "https://en.wikipedia.org/wiki/Breaking_Bad",
					UrlLogo = "https://upload.wikimedia.org/wikipedia/en/6/61/Breaking_Bad_title_card.png"
				}
			};

			context.Shows.AddRange(shows);
			context.SaveChanges();

			var seasons = new Season[] {
				new Season {
					ID = 1,
					Title = null,
					SeasonNumber = 1,
					FirstAired = new DateTime(2004, 11, 16),
					LastAired = new DateTime(2005, 5, 24),
					TvShowID = 1
				},
				new Season {
					ID = 2,
					Title = null,
					SeasonNumber = 1,
					FirstAired = new DateTime(2008, 1, 20),
					LastAired = new DateTime(2008, 3, 9),
					TvShowID = 2
				}
			};

			context.Seasons.AddRange(seasons);
			context.SaveChanges();

			var episodes = new Episode[] {
				new Episode {
					ID = 1,
					Title = "Pilot - Everybody Lies",
					Summary = "The episode features House's attempts to diagnose a kindergarten teacher after she collapses in class.",
					EpNumber = 1,
					AirDate = new DateTime(2004, 11, 16),
					RunningTime = new TimeSpan(0, 44, 0),
					SeasonID = 1
				},
				new Episode {
					ID = 2,
					Title = "Paternity",
					Summary = "A teenage boy is struck on the head in a lacrosse game and is found to have hallucinations and night terrors that are not due to concussion.",
					EpNumber = 2,
					AirDate = new DateTime(2004, 11, 23),
					RunningTime = new TimeSpan(0, 44, 0),
					SeasonID = 1
				},
				new Episode {
					ID = 3,
					Title = "Pilot",
					Summary = @"After White is diagnosed with lung cancer, he uses his chemistry knowledge to ""cook"" crystal meth with his former student Jesse Pinkman, in order to secure his family's financial future before he dies from the disease.",
					EpNumber = 1,
					AirDate = new DateTime(2008, 1, 20),
					RunningTime = new TimeSpan(0, 58, 0),
					SeasonID = 2
				},
				new Episode {
					ID = 4,
					Title = "Cat's in the Bag...",
					Summary = "Walter and Jesse return the RV to Jesse's house, which was previously owned by Jesse's late aunt. When they open the RV to remove the two bodies inside, they notice that one of them is still moving.",
					EpNumber = 2,
					AirDate = new DateTime(2008, 1, 27),
					RunningTime = new TimeSpan(0, 48, 0),
					SeasonID = 2
				}
			};

			context.Episodes.AddRange(episodes);
			context.SaveChanges();

			var actors = new Actor[] {
				new Actor {
					ID = 1,
					Name = "Hugh Laurie"
				},
				new Actor {
					ID = 2,
					Name = "Robert Sean Leonard"
				},
				new Actor {
					ID = 3,
					Name = "Omar Epps"
				},
				new Actor {
					ID = 4,
					Name = "Bryan Cranston"
				},
				new Actor {
					ID = 5,
					Name = "Aaron Paul"
				},
			};

			context.Actors.AddRange(actors);
			context.SaveChanges();

			var casts = new Cast[] {
				new Cast {
					EpisodeID = 1,
					ActorID = 1,
					Character = "Dr. Gregory House"
				},
				new Cast {
					EpisodeID = 1,
					ActorID = 2,
					Character = "Dr. James Wilson"
				},
				new Cast {
					EpisodeID = 1,
					ActorID = 3,
					Character = "Dr. Eric Foreman"
				},
				new Cast {
					EpisodeID = 2,
					ActorID = 1,
					Character = "Dr. Gregory House"
				},
				new Cast {
					EpisodeID = 2,
					ActorID = 2,
					Character = "Dr. James Wilson"
				},
				new Cast {
					EpisodeID = 2,
					ActorID = 3,
					Character = "Dr. Eric Foreman"
				},
				new Cast {
					EpisodeID = 3,
					ActorID = 4,
					Character = "Walter White"
				},
				new Cast {
					EpisodeID = 3,
					ActorID = 5,
					Character = "Jesse Pinkman"
				},
				new Cast {
					EpisodeID = 4,
					ActorID = 4,
					Character = "Walter White"
				},
				new Cast {
					EpisodeID = 4,
					ActorID = 5,
					Character = "Jesse Pinkman"
				},
			};

			context.Casts.AddRange(casts);
			context.SaveChanges();
		}
	}
}