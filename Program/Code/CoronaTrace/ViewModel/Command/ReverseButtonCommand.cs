using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CoronaTrace.ViewModel.Command
{
    public class ReverseButtonCommand : ICommand
    {
        public Interior1VM VM { get; set; }

        public ReverseButtonCommand(Interior1VM vm)
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
            string curimage = parameter.ToString();

            if (curimage == "pack://application:,,,/View/Image/frozen.png")
            {
                VM.CurImage = "/View/Image/frozenreverse.png";
            }
            else if(curimage == "pack://application:,,,/View/Image/frozenreverse.png")
            {
                VM.CurImage = "/View/Image/frozen.png";
            }
            else if(curimage == "pack://application:,,,/View/Image/desk.png")
            {
                VM.CurImage = "/View/Image/deskreverse.png";
            }
            else if (curimage == "pack://application:,,,/View/Image/deskreverse.png")
            {
                VM.CurImage = "/View/Image/desk.png";
            }




        }
    }
}
