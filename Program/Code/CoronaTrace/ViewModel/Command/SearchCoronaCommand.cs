using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CoronaTrace.ViewModel.Command
{
    public class SearchCoronaCommand : ICommand
    {
        public MapWindowVM VM { get; set; }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }


        public SearchCoronaCommand(MapWindowVM vm)
        {
            VM = vm;
        }

        public bool CanExecute(object parameter)
        {
            string inputText = parameter as string;
            int result;
            if(int.TryParse(inputText,out result) && result >= 0)
            {
                return true;
            }
            return false;
            
        }

        public void Execute(object parameter)
        {
            string inputText = parameter as string;
            int result;
            int.TryParse(inputText, out result);

            VM.CurMapView.InvokeScript("SearchCorona", VM.CurSelectedDistance, VM.CurSelectedIndex, VM.CurSelectedIndexCoro,result);
            


        }
    }
}
