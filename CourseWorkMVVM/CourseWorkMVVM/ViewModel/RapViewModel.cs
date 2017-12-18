using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkMVVM.ViewModel
{
	class RapViewModel
	{
		public List<string> RapGenres { get; set; }
		public string SelectedGengeRap { get; set; }

		public RapViewModel()
		{
			RapGenres = new List<string>()
			{
				"Reggae",
				"Rap"
			};
		}
	}
}
