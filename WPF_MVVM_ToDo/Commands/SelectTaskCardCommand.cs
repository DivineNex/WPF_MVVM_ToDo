using System.Linq;
using WPF_MVVM_ToDo.ViewModels;
using WPF_MVVM_ToDo.ViewModels.Controls;

namespace WPF_MVVM_ToDo.Commands
{
    internal class SelectTaskCardCommand : Command
    {
        private TaskCardViewModel _taskCardViewModel;
        private HomeScreenViewModel _homeScreenViewModel;

        public SelectTaskCardCommand(TaskCardViewModel taskCardViewModel, HomeScreenViewModel homeScreenViewModel)
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
            foreach (TaskCardViewModel taskCard in _homeScreenViewModel.TaskCardViewModels)
                taskCard.IsSelected = false;

            _homeScreenViewModel.SelectedTaskCard = _taskCardViewModel;
            _homeScreenViewModel.ColorPickerViewModel.SelectedColor = _taskCardViewModel.BackgroundColorBrush.Color;
            _taskCardViewModel.IsSelected = true;
        }
    }
}
