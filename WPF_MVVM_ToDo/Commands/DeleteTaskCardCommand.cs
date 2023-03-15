using WPF_MVVM_ToDo.ViewModels;
using WPF_MVVM_ToDo.ViewModels.Controls;

namespace WPF_MVVM_ToDo.Commands
{
    internal class DeleteTaskCardCommand : Command
    {
        private HomeScreenViewModel _homeScreenViewModel;
        private TaskCardViewModel _taskCardViewModel;

        public DeleteTaskCardCommand(TaskCardViewModel taskCardViewModel, HomeScreenViewModel homeScreenViewModel)
        {
            _taskCardViewModel = taskCardViewModel;
            _homeScreenViewModel = homeScreenViewModel;
        }

        public override bool CanExecute(object? parameter)
        {
            return true;
        }

        public override void Execute(object? parameter)
        {
            _homeScreenViewModel.TaskCardViewModels.Remove(_taskCardViewModel);
        }
    }
}
