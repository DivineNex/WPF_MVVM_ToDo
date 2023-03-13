using System;
using System.Collections.ObjectModel;
using System.Linq;
using WPF_MVVM_ToDo.Commands;
using WPF_MVVM_ToDo.Models;
using WPF_MVVM_ToDo.ViewModels.Controls;

namespace WPF_MVVM_ToDo.ViewModels
{
    internal class HomeScreenViewModel : ViewModel
    {
        public ObservableCollection<TaskCardViewModel> TaskCardViewModels { get; }

        public ValidateTextBoxOnFocusCommand ValidateTextBoxOnFocusCommand { get; private set; }
        public OpenTaskCreationWindowCommand OpenTaskCreationWindowCommand { get; private set; }
        public SelectTaskCardCommand SelectTaskCardCommand { get; private set; }

        #region SearchPlaceholderText
        public string SearchPlaceholderText
        {
            get { return "Search"; }
        } 
        #endregion

        #region SearchText
        private string _searchText;

        public string SearchText
        {
            get { return _searchText; }
            set { Set(ref _searchText, value, nameof(_searchText)); }
        }
        #endregion

        #region SelectedTaskCard
        private TaskCardViewModel _selectedTaskCard;

        public TaskCardViewModel SelectedTaskCard
        {
            get { return _selectedTaskCard; }
            set { Set(ref _selectedTaskCard, value, nameof(SelectedTaskCard)); }
        } 
        #endregion

        public HomeScreenViewModel()
        {
            ValidateTextBoxOnFocusCommand = new ValidateTextBoxOnFocusCommand();
            OpenTaskCreationWindowCommand = new OpenTaskCreationWindowCommand(this);

            TaskCardViewModels = new ObservableCollection<TaskCardViewModel>();

            TaskCardViewModels.Add(new TaskCardViewModel(this, new Task("test1",
                "test description",
                new DateTime(2000, 12, 10),
                new DateTime(2000, 12, 11),
                Other.eTaskStatus.Active)));

            TaskCardViewModels.Add(new TaskCardViewModel(this, new Task("test1",
                "test description",
                new DateTime(2000, 12, 10),
                new DateTime(2000, 12, 11),
                Other.eTaskStatus.Active)));

            TaskCardViewModels.Add(new TaskCardViewModel(this, new Task("test1",
                "test description",
                new DateTime(2000, 12, 10),
                new DateTime(2000, 12, 11),
                Other.eTaskStatus.Active)));

            TaskCardViewModels.Add(new TaskCardViewModel(this, new Task("test1",
                "test description",
                new DateTime(2000, 12, 10),
                new DateTime(2000, 12, 11),
                Other.eTaskStatus.Active)));

            TaskCardViewModels.Add(new TaskCardViewModel(this, new Task("test1",
                "test description",
                new DateTime(2000, 12, 10),
                new DateTime(2000, 12, 11),
                Other.eTaskStatus.Active)));
        }
    }
}
