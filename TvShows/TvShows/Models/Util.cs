using System;
using System.Collections.Generic;

namespace TvShows.Models
{
	public static class Util
	{
		public static string ToSpanishDate(DateTime date)
		{
			var months = new Dictionary<int, string> {
				{ 1, "Enero" },
				{ 2, "Febrero" },
				{ 3, "Marzo" },
				{ 4, "Abril" },
				{ 5, "Mayo" },
				{ 6, "Junio" },
				{ 7, "Julio" },
				{ 8, "Agosto" },
				{ 9, "Septiembre" },
				{ 10, "Octubre" },
				{ 11, "Noviembre" },
				{ 12, "Diciembre" },
			};

			return string.Format("{0} de {1} de {2}", date.Day, months[date.Month], date.Year);
		}
	}
}