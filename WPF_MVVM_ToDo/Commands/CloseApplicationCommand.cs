using System.Windows;

namespace WPF_MVVM_ToDo.Commands
{
    internal class CloseApplicationCommand : Command
    {
        public override bool CanExecute(object? parameter) => true;

        public override void Execute(object? parameter)
        {
            Application.Current.Shutdown();
        }
    }
}
