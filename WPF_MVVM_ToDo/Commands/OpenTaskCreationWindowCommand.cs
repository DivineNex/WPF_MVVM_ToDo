using System.Collections.ObjectModel;
using WPF_MVVM_ToDo.ViewModels;
using WPF_MVVM_ToDo.ViewModels.Controls;

namespace WPF_MVVM_ToDo.Commands
{
    internal class OpenTaskCreationWindowCommand : Command
    {
        private HomeScreenViewModel _homeScreenViewModel;

        public OpenTaskCreationWindowCommand(HomeScreenViewModel homeScreenViewModel)
        {
            _homeScreenViewModel = homeScreenViewModel;
        }

        public override bool CanExecute(object? parameter)
        {
            return true;
        }

        public override void Execute(object? parameter)
        {
            var taskCreationWindowView = new TaskCreationWindowView();
            var taskCreationWindowViewModel = new TaskCreationWindowViewModel(_homeScreenViewModel);
            taskCreationWindowView.DataContext = taskCreationWindowViewModel;
            taskCreationWindowView.ShowDialog();
        }
    }
}
