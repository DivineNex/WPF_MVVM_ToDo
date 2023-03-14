using System.Windows.Media;
using WPF_MVVM_ToDo.ViewModels.Controls;

namespace WPF_MVVM_ToDo.Commands
{
    internal class SelectColorInColorPickerCommand : Command
    {
        private ColorPickerPanelViewModel _colorPickerPanelViewModel;

        public SelectColorInColorPickerCommand(ColorPickerPanelViewModel colorPickerPanelViewModel)
        {
            _colorPickerPanelViewModel = colorPickerPanelViewModel;
        }

        public override bool CanExecute(object? parameter)
        {
            return true;
        }

        public override void Execute(object? parameter)
        {
            if (_colorPickerPanelViewModel.HomeScreenViewModel.SelectedTaskCard == null)
                return;

            _colorPickerPanelViewModel.SelectedColor = (parameter as SolidColorBrush).Color;
        }
    }
}
