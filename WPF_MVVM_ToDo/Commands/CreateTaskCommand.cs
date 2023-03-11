using System.Collections.ObjectModel;
using WPF_MVVM_ToDo.Models;
using WPF_MVVM_ToDo.ViewModels.Controls;

namespace WPF_MVVM_ToDo.Commands
{
    internal class CreateTaskCommand : Command
    {
        private ObservableCollection<TaskCardViewModel> _taskCardViewModels;

        public CreateTaskCommand(ObservableCollection<TaskCardViewModel> taskCardViewModels)
        {
            _taskCardViewModels = taskCardViewModels;
        }

        public override bool CanExecute(object? parameter) => true;

        public override void Execute(object? parameter)
        {
            var task = parameter as Task;

            _taskCardViewModels.Add(new TaskCardViewModel(task));
        }
    }
}
