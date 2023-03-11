using System;
using System.Collections.ObjectModel;
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
        public OpenTaskCreationWindowCommand OpenTaskCreationWindowCommand { get; private set; }

        public string PlaceholderText
        {
            get { return "Search"; }
        }

        private string _searchText;

        public string SearchText
        {
            get { return _searchText; }
            set { Set(ref _searchText, value, nameof(_searchText)); }
        }

        public HomeScreenViewModel()
        {
            ValidateSearchBarOnLostFocusCommand = new ValigateSearchBarOnLostFocusCommand();
            ValidateSearchBarOnFocusCommand = new ValigateSearchBarOnFocusCommand();
            OpenTaskCreationWindowCommand = new OpenTaskCreationWindowCommand();

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
