using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;
using System.Windows.Controls;

namespace CourseWorkMVVM.ViewModel
{
	class MainWindowViewModel:INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		public void DoPropertyChanged(string Name)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(Name));
			}
		}
		private Page Welcome;
		private Page Pop;
		private Page Rock;
		private Page Rap;

		public Page _CurrentPage;
		public Page CurrentPage;

		public MainWindowViewModel()
		{
			Welcome = new Pages.Welcome();
			Pop = new Pages.Pop();
			Rock = new Pages.Rock();
			Rap = new Pages.Rap();

			CurrentPage = Welcome;
		}

		public interface ICommand
		{
			void Execute(object param);
			bool CanExecute(object param);
			event EventHandler<object> CanExecuteChanged;
		}

		public ICommand MenuPopClick
		{
			get
			{
				return CurrentPage;
			} 
			set
			{
				CurrentPage = Pop;
				DoPropertyChanged("CurrentPage");
			}
		}
	}
}
