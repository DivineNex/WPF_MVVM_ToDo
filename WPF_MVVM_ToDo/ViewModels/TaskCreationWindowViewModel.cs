using WPF_MVVM_ToDo.Commands;

namespace WPF_MVVM_ToDo.ViewModels
{
    internal class TaskCreationWindowViewModel : ViewModel
    {
        public CloseActiveWindowCommand CloseActiveWindowCommand { get; private set; }

        public TaskCreationWindowViewModel()
        {
            CloseActiveWindowCommand = new CloseActiveWindowCommand();
        }
    }
}
