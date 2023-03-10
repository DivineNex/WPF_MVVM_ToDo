using System;
using WPF_MVVM_ToDo.Other;

namespace WPF_MVVM_ToDo.Models
{
    internal class Task
    {
        public string Header { get; private set; }
        public string Description { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set;}
        public eTaskStatus Status { get; private set; }
    }
}
