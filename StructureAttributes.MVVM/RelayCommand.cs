using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StructureAttributes.MVVM
{
    public class RelayCommand : ICommand
    {
        public event EventHandler CanExecuteChanged = (sender, e) => {};
        private Action _mAction;
        public RelayCommand(Action action)
        {
            _mAction = action;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
           this._mAction();
        }
    }
}
