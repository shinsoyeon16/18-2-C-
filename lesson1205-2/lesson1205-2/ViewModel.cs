using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace lesson1205_2
{
    class ViewModel
    {
        public ICommand MyCommand { get; set; }
        //public string MyMessage { get; set; }
        public ViewModel()
        {
            MyCommand = new Command(ExecuteMethod);
        }
        private bool CanExecuteMethod(object arg)
        {
            return true;
        }
        private void ExecuteMethod(string message)
        {
            MessageBox.Show(message);
        }
    }
}
