using System;
using System.Windows;
using System.Windows.Media;
using WPF_MVVM_ToDo.Commands;
using WPF_MVVM_ToDo.Models;

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

		public string CreationDate
		{
			get { return $"{Task.CreationDate.ToShortDateString()} {Task.CreationDate.ToShortTimeString()}"; }
		}

		#region IsSelected
		private bool _isSelected;

		public bool IsSelected
		{
			get { return _isSelected; }
			set { Set(ref _isSelected, value, nameof(IsSelected)); }
		}
		#endregion

		#region BackgroundColorBrush
		private SolidColorBrush _backgroundColorBrush = new SolidColorBrush(Color.FromRgb(228, 205, 238));

		public SolidColorBrush BackgroundColorBrush
		{
			get { return _backgroundColorBrush; }
			set { Set(ref _backgroundColorBrush, value, nameof(BackgroundColorBrush)); }
		}
		#endregion

		#region DeleteButtonVisibility
		private Visibility _deleteButtonVisibility;

		public Visibility DeleteButtonVisibility
		{
			get { return _deleteButtonVisibility; }
			set { Set(ref _deleteButtonVisibility, value, nameof(DeleteButtonVisibility)); }
		} 
		#endregion

		public SelectTaskCardCommand SelectTaskCardCommand { get; private set; }
		public DeleteTaskCardCommand DeleteTaskCardCommand { get; private set; }

		public TaskCardViewModel() {}

		public TaskCardViewModel(HomeScreenViewModel homeScreenViewModel, Task task)
		{
			_task = task;

			SelectTaskCardCommand = new SelectTaskCardCommand(this, homeScreenViewModel);
			DeleteTaskCardCommand = new DeleteTaskCardCommand(this, homeScreenViewModel);

			if (homeScreenViewModel.DeleteModeEnabled)
				DeleteButtonVisibility = Visibility.Visible;
			else
				DeleteButtonVisibility = Visibility.Collapsed;
		}
    }
}
