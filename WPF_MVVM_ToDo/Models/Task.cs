using System;
using WPF_MVVM_ToDo.Other;

namespace WPF_MVVM_ToDo.Models
{
    internal class Task
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public eTaskStatus Status { get; set; }

        public Task()
        {

        }

        public Task(string title, string description, DateTime creationDate, eTaskStatus status)
        {
            Title = title;
            Description = description;
            CreationDate = creationDate;
            Status = status;
        }
    }
}
