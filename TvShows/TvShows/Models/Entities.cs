using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TvShows.Models.Entities
{
	public class TvShow
	{
		public int ID { get; set; }

		[Required, MaxLength(100)]
		public string Title { get; set; }

		[Required, MaxLength(100)]
		public string CreatedBy { get; set; }

		[Required, MaxLength(100)]
		public string Country { get; set; }

		[Required, MaxLength(50)]
		public string OriginalLanguage { get; set; }

		[Required, MaxLength(1000)]
		public string Summary { get; set; }

		[Required, MaxLength(500)]
		public string Website { get; set; }

		[Required, MaxLength(500)]
		public string UrlLogo { get; set; }

		public virtual ICollection<Season> Seasons { get; set; }
	}

	public class Season
	{
		public int ID { get; set; }

		[MaxLength(100)]
		public string Title { get; set; }

		public int SeasonNumber { get; set; }
		public DateTime FirstAired { get; set; }
		public DateTime? LastAired { get; set; }
		public int TvShowID { get; set; }

		public virtual TvShow TvShow { get; set; }
		public virtual ICollection<Episode> Episodes { get; set; }
	}

	public class Episode
	{
		public int ID { get; set; }

		[Required, MaxLength(500)]
		public string Title { get; set; }

		[Required, MaxLength(1000)]
		public string Summary { get; set; }

		public int EpNumber { get; set; }
		public DateTime AirDate { get; set; }
		public TimeSpan? RunningTime { get; set; }
		public int SeasonID { get; set; }

		public virtual Season Season { get; set; }
		public virtual ICollection<Review> Reviews { get; set; }
		public virtual ICollection<Cast> Cast { get; set; }
	}

	public class Review
	{
		public enum Score
		{
			A, B, C, D, E, F
		}

		public int ID { get; set; }

		[MaxLength(100)]
		public string Author { get; set; }

		[Required, MaxLength(1000)]
		public string ReviewText { get; set; }

		public Score EpScore { get; set; }
		public int EpisodeID { get; set; }

		public virtual Episode Episode { get; set; }
	}

	public class Cast
	{
		[Key, Column(Order = 0)]
		public int EpisodeID { get; set; }

		[Key, Column(Order = 1)]
		public int ActorID { get; set; }

		[Required, MaxLength(100)]
		public string Character { get; set; }
		
		public virtual Episode Episode { get; set; }
		public virtual Actor Actor { get; set; }
	}

	public class Actor
	{
		public int ID { get; set; }

		[Required, MaxLength(100)]
		public string Name { get; set; }

		public virtual ICollection<Cast> Casts { get; set; }
	}
}