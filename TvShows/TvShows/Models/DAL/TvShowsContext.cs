using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using TvShows.Models.Entities;

namespace TvShows.Models.DAL
{
	public class TvShowsContext : DbContext
	{
		public DbSet<TvShow> Shows { get; set; }
		public DbSet<Season> Seasons { get; set; }
		public DbSet<Episode> Episodes { get; set; }
		public DbSet<Review> Reviews { get; set; }
		public DbSet<Cast> Casts { get; set; }
		public DbSet<Actor> Actors { get; set; }

		public TvShowsContext() : base("TvShows")
		{
		}

		protected override void OnModelCreating(DbModelBuilder builder)
		{
			builder.Conventions.Remove<PluralizingTableNameConvention>();
		}
	}
}