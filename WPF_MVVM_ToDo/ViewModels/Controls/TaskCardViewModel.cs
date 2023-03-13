using System.Runtime.CompilerServices;
using System.Windows;
using WPF_MVVM_ToDo.Commands;
using WPF_MVVM_ToDo.Models;
using WPF_MVVM_ToDo.Other;

namespace WPF_MVVM_ToDo.ViewModels.Controls
{
	class TaskCardViewModel : ViewModel
    {
		#region Task
		private Task _task;

		public Task Task
		{
			get { return _task; }
			private set { Set(ref _task, value, nameof(Task)); }
		}
		#endregion

		#region IsSelected
		private bool _isSelected;

		public bool IsSelected
		{
			get { return _isSelected; }
			set { Set(ref _isSelected, value, nameof(IsSelected)); }
		}
		#endregion

		public SelectTaskCardCommand SelectTaskCardCommand { get; private set; }

		public TaskCardViewModel() {}

		public TaskCardViewModel(HomeScreenViewModel homeScreenViewModel, Task task)
		{
			_task = task;

			SelectTaskCardCommand = new SelectTaskCardCommand(this, homeScreenViewModel);
		}
    }
}
