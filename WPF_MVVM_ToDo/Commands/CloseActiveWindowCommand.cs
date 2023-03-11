using System.Linq;
using System.Windows;

namespace WPF_MVVM_ToDo.Commands
{
    internal class CloseActiveWindowCommand : Command
    {
        public override bool CanExecute(object? parameter) => true;

        public override void Execute(object? parameter)
        {
            Window activeWindow = Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);

            activeWindow?.Close();
        }
    }
}
