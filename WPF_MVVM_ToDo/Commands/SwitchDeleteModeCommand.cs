using WPF_MVVM_ToDo.ViewModels;

namespace WPF_MVVM_ToDo.Commands
{
    internal class SwitchDeleteModeCommand : Command
    {
        private HomeScreenViewModel _homeScreenViewModel;

        public SwitchDeleteModeCommand(HomeScreenViewModel homeScreenViewModel)
        {
            _homeScreenViewModel = homeScreenViewModel;
        }

        public override bool CanExecute(object? parameter)
        {
            return true;
        }

        public override void Execute(object? parameter)
        {
            if (!_homeScreenViewModel.DeleteModeEnabled)
                _homeScreenViewModel.DeleteModeEnabled = true;
            else
                _homeScreenViewModel.DeleteModeEnabled = false;
        }
    }
}
