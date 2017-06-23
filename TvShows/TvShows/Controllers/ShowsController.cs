using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using TvShows.Models.DAL;
using TvShows.Models.Entities;

namespace TvShows.Controllers
{
    public class ShowsController : Controller
    {
		private TvShowsContext db = new TvShowsContext();

        [HttpGet]
        public ActionResult Show(int? id)
        {
			var show = db.Shows
				.Include(s => s.Seasons)
				.FirstOrDefault(s => s.ID == id);

			if (show == null) {
				Session["Error"] = true;
				Session["ErrorMessage"] = "That show couldn't be found.";
				return RedirectToAction("Index", "Home");
			}

			return View(show);
        }

		public ActionResult Season(int? id)
		{
			var season = db.Seasons
				.Include(s => s.Episodes)
				.Include(s => s.TvShow)
				.FirstOrDefault(s => s.ID == id);

			if (season == null) {
				Session["Error"] = true;
				Session["ErrorMessage"] = "That season couldn't be found.";
				return RedirectToAction("Index", "Home");
			}

			return View(season);
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