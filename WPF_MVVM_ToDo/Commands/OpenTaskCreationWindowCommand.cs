using System.Collections.ObjectModel;
using WPF_MVVM_ToDo.ViewModels;
using WPF_MVVM_ToDo.ViewModels.Controls;

namespace WPF_MVVM_ToDo.Commands
{
    internal class OpenTaskCreationWindowCommand : Command
    {
        public override bool CanExecute(object? parameter)
        {
            return true;
        }

        public override void Execute(object? parameter)
        {
            var taskCollection = parameter as ObservableCollection<TaskCardViewModel>;

            var taskCreationWindowView = new TaskCreationWindowView();
            var taskCreationWindowViewModel = new TaskCreationWindowViewModel(taskCollection);
            taskCreationWindowView.DataContext = taskCreationWindowViewModel;
            taskCreationWindowView.ShowDialog();
        }
    }
}
