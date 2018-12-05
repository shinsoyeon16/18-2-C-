using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace lesson1205_2
{
    class Command : ICommand
    {
        Action<string> _executeMethod;

        public Command(Action<string> executeMethod)
        {
            this._executeMethod = executeMethod;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _executeMethod(parameter as string);
        }
    }
}
