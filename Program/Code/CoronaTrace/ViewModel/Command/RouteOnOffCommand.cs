using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CoronaTrace.ViewModel.Command
{
    public class RouteOnOffCommand : ICommand
    {
        public MapWindowVM VM { get; set; }
        public RouteOnOffCommand(MapWindowVM vm)
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
            bool Ischecked = (bool)parameter;
            if (Ischecked)
            {
                VM.CurMapView.InvokeScript("ON");
            }
            else
            {
                VM.CurMapView.InvokeScript("OFF");
            }
        }
    }
}
