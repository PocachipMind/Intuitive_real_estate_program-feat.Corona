using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CoronaTrace.ViewModel.Command
{
    public class RemoveSearchCoronaCommand : ICommand
    {
        public MapWindowVM VM { get; set; }
        public RemoveSearchCoronaCommand(MapWindowVM vm)
        {
            VM = vm;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            VM.CurMapView.InvokeScript("ssshideMarkers");
        }
    }
}
