using System.Windows.Controls;

namespace WPF_MVVM_ToDo.Commands
{
    internal class ValidateTextBoxOnFocusCommand : Command
    {
        public override bool CanExecute(object? parameter) => true;

        public override void Execute(object? parameter)
        {
            var textbox = parameter as TextBox;

            if (textbox.Text == textbox.Tag.ToString())
                textbox.Text = "";
        }
    }
}
