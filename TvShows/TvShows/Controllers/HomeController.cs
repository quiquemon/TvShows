using System.Linq;
using System.Web.Mvc;
using TvShows.Models.DAL;

namespace TvShows.Controllers
{
    public class HomeController : Controller
    {
		private TvShowsContext db = new TvShowsContext();

        [HttpGet]
        public ActionResult Index()
        {
			var shows = db.Shows
				.OrderByDescending(show => show.ID)
				.Take(10)
				.OrderBy(show => show.Title)
				.ToArray()
				.Select((show, index) => new { show, index })
				.GroupBy(e => e.index / 5)
				.Select(e => e.Select(a => a.show).ToArray())
				.ToArray();

            return View(shows);
        }

		[HttpGet]
		[ValidateInput(false)]
		public ActionResult Search(string query)
		{
			var shows = db.Shows
				.Where(show => show.Title.Contains(query))
				.ToArray();

			ViewBag.Query = query;
			return View(shows);
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				db.Dispose();
			}

			base.Dispose(disposing);
		}
	}
}