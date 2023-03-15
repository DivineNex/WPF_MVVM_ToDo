using FontAwesome5;
using WPF_MVVM_ToDo.ViewModels.Controls;

namespace WPF_MVVM_ToDo.Commands
{
    internal class SwitchTaskCardStatusCommand : Command
    {
        private TaskCardViewModel _taskCardViewModel;

        public SwitchTaskCardStatusCommand(TaskCardViewModel taskCardViewModel)
        {
            _taskCardViewModel = taskCardViewModel;
        }

        public override bool CanExecute(object? parameter)
        {
            return true;
        }

        public override void Execute(object? parameter)
        {
            if (_taskCardViewModel.Task.Status == Other.eTaskStatus.Active)
            {
                _taskCardViewModel.Task.Status = Other.eTaskStatus.Completed;
                _taskCardViewModel.StatusIcon = EFontAwesomeIcon.Regular_CheckCircle;
                _taskCardViewModel.StatusText = "Completed";
            }
            else
            {
                _taskCardViewModel.Task.Status = Other.eTaskStatus.Active;
                _taskCardViewModel.StatusIcon = EFontAwesomeIcon.Regular_Circle;
                _taskCardViewModel.StatusText = "Not completed yet";
            }
        }
    }
}
