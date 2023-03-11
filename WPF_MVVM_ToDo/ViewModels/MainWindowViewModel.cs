using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_MVVM_ToDo.Commands;

namespace WPF_MVVM_ToDo.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        public CloseActiveWindowCommand CloseApplicationCommand { get; private set; }

        public MainWindowViewModel()
        {
            CloseApplicationCommand = new CloseActiveWindowCommand();
        }
    }
}
