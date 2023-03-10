using System;
using WPF_MVVM_ToDo.Other;

namespace WPF_MVVM_ToDo.Models
{
    internal class Task
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set;}
        public eTaskStatus Status { get; private set; }

        public Task(string title, string description, DateTime startDate, DateTime endDate, eTaskStatus status)
        {
            Title = title;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;
            Status = status;
        }
    }
}
