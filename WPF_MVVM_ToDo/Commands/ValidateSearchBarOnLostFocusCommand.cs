using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WPF_MVVM_ToDo.Commands
{
    class ValigateSearchBarOnLostFocusCommand : Command
    {
        public override bool CanExecute(object? parameter) => true;

        public override void Execute(object? parameter)
        {
            var textbox = parameter as TextBox;

            if (string.IsNullOrEmpty(textbox.Text))
                textbox.Text = "Search";
        }
    }
}
