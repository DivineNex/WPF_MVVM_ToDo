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

		#region IsSelected
		private bool _isSelected;

		public bool IsSelected
		{
			get { return _isSelected; }
			set { Set(ref _isSelected, value, nameof(IsSelected)); }
		}
		#endregion

		#region BackgroundColorBrush
		private SolidColorBrush _backgroundColorBrush = new SolidColorBrush(Color.FromArgb(0xC9, 0xCA, 0xEE, 0xFF));


		public SolidColorBrush BackgroundColorBrush
		{
			get { return _backgroundColorBrush; }
			set { Set(ref _backgroundColorBrush, value, nameof(BackgroundColorBrush)); }
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
