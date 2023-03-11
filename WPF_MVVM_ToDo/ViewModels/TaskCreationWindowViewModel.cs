using System;
using System.Collections.ObjectModel;
using WPF_MVVM_ToDo.Commands;
using WPF_MVVM_ToDo.Models;
using WPF_MVVM_ToDo.Other;
using WPF_MVVM_ToDo.ViewModels.Controls;

namespace WPF_MVVM_ToDo.ViewModels
{
    internal class TaskCreationWindowViewModel : ViewModel
    {
        private Task _task;

        public Task Task
        {
            get { return _task; }
            private set { _task = value; }
        }

        public string Title
        {
            get { return _task.Title; }
            set { _task.Title = value; }
        }

        public string Description
        {
            get { return _task.Description; }
            set { _task.Description = value; }
        }

        public DateTime StartDate
        {
            get { return _task.StartDate; }
            set { _task.StartDate = value; }
        }

        public DateTime EndDate
        {
            get { return _task.EndDate; }
            set { _task.EndDate = value; }
        }

        public eTaskStatus Status
        {
            get { return _task.Status; }
            set { _task.Status = value; }
        }

        public CloseActiveWindowCommand CloseActiveWindowCommand { get; private set; }
        public CreateTaskCommand CreateTaskCommand { get; private set; }

        public TaskCreationWindowViewModel(ObservableCollection<TaskCardViewModel> taskCardViewModels)
        {
            _task = new Task();
            CloseActiveWindowCommand = new CloseActiveWindowCommand();
            CreateTaskCommand = new CreateTaskCommand(taskCardViewModels);
        }
    }
}
