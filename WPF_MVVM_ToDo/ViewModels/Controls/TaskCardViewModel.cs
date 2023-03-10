using WPF_MVVM_ToDo.Models;

namespace WPF_MVVM_ToDo.ViewModels.Controls
{
	class TaskCardViewModel : ViewModel
    {
		private Task _task;

		public Task Task
		{
			get { return _task; }
			private set { Set(ref _task, value, nameof(Task)); }
		}

		public TaskCardViewModel(Task task)
		{
			_task = task;
		}
	}
}
