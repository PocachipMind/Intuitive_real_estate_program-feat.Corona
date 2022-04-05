using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CoronaTrace.ViewModel.Command
{
    public class CheckCoronaCommand : ICommand
    {
        public MapWindowVM VM { get; set; }

        public event EventHandler CanExecuteChanged;

        public CheckCoronaCommand(MapWindowVM vm)
        {
            VM = vm;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            bool Ischecked = (bool)parameter;
            if (Ischecked)
            {                
              VM.CurMapView.InvokeScript("makeCir");
            }
            else
            {
                VM.CurMapView.InvokeScript("removeCir");
            }

        }
    }

}
