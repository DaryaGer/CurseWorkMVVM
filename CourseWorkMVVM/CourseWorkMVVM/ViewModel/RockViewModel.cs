using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkMVVM.ViewModel
{
	class RockViewModel
	{
		public List<string> RockGenres { get; set; }
		public string SelectedGengeRock { get; set; }

		public RockViewModel()
		{
			RockGenres = new List<string>()
			{
				"Hard Rock",
				"Pop Rock",
				"Folk Rock",
				"Punk Rock",
				"Psychedelic Rock",
				"Heavy Metal",
				"Trash"
			};
		}
	}
}
