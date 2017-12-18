using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkMVVM.ViewModel
{
	class PopViewModel
	{
		public List<string> PopGenres { get; set; }
		public string SelectedGengePop { get; set; }

		public PopViewModel()
		{
			PopGenres = new List<string>()
			{
				"Disco",
				"Trans",
				"House",
				"Techno",
				"Funk",
				"New Wave"
			};
		}
	}
}
