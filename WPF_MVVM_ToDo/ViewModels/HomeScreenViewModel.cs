using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using WPF_MVVM_ToDo.Commands;
using WPF_MVVM_ToDo.Models;
using WPF_MVVM_ToDo.ViewModels.Controls;

namespace WPF_MVVM_ToDo.ViewModels
{
    internal class HomeScreenViewModel : ViewModel
    {
        public ObservableCollection<TaskCardViewModel> TaskCardViewModels { get; }

        public ValigateSearchBarOnLostFocusCommand ValidateSearchBarOnLostFocusCommand { get; private set; }
        public ValigateSearchBarOnFocusCommand ValidateSearchBarOnFocusCommand { get; private set; }

        public HomeScreenViewModel()
        {
            ValidateSearchBarOnLostFocusCommand = new ValigateSearchBarOnLostFocusCommand();
            ValidateSearchBarOnFocusCommand = new ValigateSearchBarOnFocusCommand();

            TaskCardViewModels = new ObservableCollection<TaskCardViewModel>();

            TaskCardViewModels.Add(new TaskCardViewModel(new Task("test1",
                "test description",
                new DateTime(2000, 12, 10),
                new DateTime(2000, 12, 11),
                Other.eTaskStatus.Active)));

            TaskCardViewModels.Add(new TaskCardViewModel(new Task("test1",
    "test description",
    new DateTime(2000, 12, 10),
    new DateTime(2000, 12, 11),
    Other.eTaskStatus.Active)));

            TaskCardViewModels.Add(new TaskCardViewModel(new Task("test1",
    "test description",
    new DateTime(2000, 12, 10),
    new DateTime(2000, 12, 11),
    Other.eTaskStatus.Active)));

            TaskCardViewModels.Add(new TaskCardViewModel(new Task("test1",
    "test description",
    new DateTime(2000, 12, 10),
    new DateTime(2000, 12, 11),
    Other.eTaskStatus.Active)));

            TaskCardViewModels.Add(new TaskCardViewModel(new Task("test1",
    "test description",
    new DateTime(2000, 12, 10),
    new DateTime(2000, 12, 11),
    Other.eTaskStatus.Active)));
        }
    }
}
