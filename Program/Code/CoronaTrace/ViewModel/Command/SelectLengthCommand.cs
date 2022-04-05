using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CoronaTrace.ViewModel.Command 
{
    public class SelectLengthCommand : ICommand
    {
        public Interior1VM VM { get; set; }
        public SelectLengthCommand(Interior1VM vm)
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
            VM.CheckLen = parameter.ToString();

            switch(VM.CheckLen)
            {
                case "one":
                    VM.LenSource = "/View/Image/table1.png";
                    break;
                case "two":
                    VM.LenSource = "/View/Image/table2.png";
                    break;
                case "three":
                    VM.LenSource = "/View/Image/table3.png";
                    break;
            }

        }
    }
}
