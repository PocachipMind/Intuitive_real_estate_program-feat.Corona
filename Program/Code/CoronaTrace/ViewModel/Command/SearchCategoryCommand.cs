using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CoronaTrace.ViewModel.Command
{
    public class SearchCategoryCommand : ICommand
    {

        public MapWindowVM VM { get; set; }
        private string FunctionName;

        public event EventHandler CanExecuteChanged;

        public SearchCategoryCommand(MapWindowVM vm, string name)
        {
            VM = vm;
            FunctionName = name;
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
                string showMarkers = FunctionName + "showMarkers";
                VM.CurMapView.InvokeScript(showMarkers);
            }
            else
            {
                string hideMarkers = FunctionName + "hideMarkers";
                VM.CurMapView.InvokeScript(hideMarkers);
            }

        }
    }
}
