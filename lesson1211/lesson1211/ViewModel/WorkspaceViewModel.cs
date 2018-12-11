using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace lesson1211.ViewModel
{
    abstract class WorkspaceViewModel : ViewModelBase
    {
        public ICommand CloseCommand{ get; set; }
        public WorkspaceViewModel()
        {
                    
        }
    }
}
