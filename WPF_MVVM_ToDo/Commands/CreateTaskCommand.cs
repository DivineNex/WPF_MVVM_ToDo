using System.Windows.Media;
using WPF_MVVM_ToDo.Models;
using WPF_MVVM_ToDo.ViewModels;
using WPF_MVVM_ToDo.ViewModels.Controls;

namespace WPF_MVVM_ToDo.Commands
{
    internal class CreateTaskCommand : Command
    {
        private HomeScreenViewModel _homeScreenViewModel;

        public CreateTaskCommand(HomeScreenViewModel homeScreenViewModel)
        {
            _homeScreenViewModel = homeScreenViewModel;
        }

        public override bool CanExecute(object? parameter) => true;

        public override void Execute(object? parameter)
        {
            var task = parameter as Task;

            var taskCardViewModel = new TaskCardViewModel(_homeScreenViewModel, task);

            _homeScreenViewModel.TaskCardViewModels.Add(taskCardViewModel);
        }
    }
}
