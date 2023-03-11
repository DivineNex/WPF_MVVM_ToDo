using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MVVM_ToDo.Commands
{
    class OpenTaskCreationWindowCommand : Command
    {
        public override bool CanExecute(object? parameter)
        {
            return true;
        }

        public override void Execute(object? parameter)
        {
            var window = new TaskCreationWindowView();
            window.ShowDialog();
        }
    }
}
