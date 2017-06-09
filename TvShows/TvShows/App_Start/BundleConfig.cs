using System.Web.Optimization;

namespace TvShows
{
	public class BundleConfig
	{
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.Add(new ScriptBundle("~/app-scripts").Include(
				"~/Scripts/jquery-3.1.1.min.js",
				"~/Scripts/bootstrap.min.js"
			));

			bundles.Add(new StyleBundle("~/app-styles").Include(
				"~/Content/bootstrap.min.css"
			));
		}
	}
}