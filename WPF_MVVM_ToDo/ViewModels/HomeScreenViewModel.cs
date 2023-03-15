using System;
using System.Collections.ObjectModel;
using WPF_MVVM_ToDo.Commands;
using WPF_MVVM_ToDo.ViewModels.Controls;

namespace WPF_MVVM_ToDo.ViewModels
{
    internal class HomeScreenViewModel : ViewModel
    {
        public ObservableCollection<TaskCardViewModel> TaskCardViewModels { get; }
        public ColorPickerPanelViewModel ColorPickerViewModel { get; private set; }

        public ValidateTextBoxOnFocusCommand ValidateTextBoxOnFocusCommand { get; private set; }
        public OpenTaskCreationWindowCommand OpenTaskCreationWindowCommand { get; private set; }
        public SelectTaskCardCommand SelectTaskCardCommand { get; private set; }
        public SwitchDeleteModeCommand SwitchDeleteModeCommand { get; private set; }

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

        #region DeleteModeEnabled
        private bool _deleteModeEnabled;

        public bool DeleteModeEnabled
        {
            get { return _deleteModeEnabled; }
            set 
            {
                Set(ref _deleteModeEnabled, value, nameof(DeleteModeEnabled));

                if (value)
                    foreach (var taskCardViewModel in TaskCardViewModels)
                        taskCardViewModel.DeleteButtonVisibility = System.Windows.Visibility.Visible;
                else
                    foreach (var taskCardViewModel in TaskCardViewModels)
                        taskCardViewModel.DeleteButtonVisibility = System.Windows.Visibility.Collapsed;
            }
        } 
        #endregion

        public HomeScreenViewModel()
        {
            ValidateTextBoxOnFocusCommand = new ValidateTextBoxOnFocusCommand();
            OpenTaskCreationWindowCommand = new OpenTaskCreationWindowCommand(this);
            SwitchDeleteModeCommand = new SwitchDeleteModeCommand(this);

            TaskCardViewModels = new ObservableCollection<TaskCardViewModel>();
            ColorPickerViewModel = new ColorPickerPanelViewModel(this);

            TaskCardViewModels.Add(new TaskCardViewModel(this, new Models.Task("Купить хлеб", "Описание", DateTime.Parse("2023.03.12 17:30"), Other.eTaskStatus.Active)));
            TaskCardViewModels.Add(new TaskCardViewModel(this, new Models.Task("Купить хлеб", "Описание", DateTime.Now, Other.eTaskStatus.Active)));
            TaskCardViewModels.Add(new TaskCardViewModel(this, new Models.Task("Купить хлеб", "Описание", DateTime.Now, Other.eTaskStatus.Active)));
            TaskCardViewModels.Add(new TaskCardViewModel(this, new Models.Task("Купить хлеб", "Описание", DateTime.Now, Other.eTaskStatus.Active)));
            TaskCardViewModels.Add(new TaskCardViewModel(this, new Models.Task("Купить хлеб", "Описание", DateTime.Now, Other.eTaskStatus.Active)));
        }
    }
}
