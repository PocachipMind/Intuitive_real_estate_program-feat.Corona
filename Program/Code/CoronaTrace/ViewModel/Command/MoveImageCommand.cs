using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CoronaTrace.ViewModel.Command
{
    public class MoveImageCommand : ICommand
    {
        public Interior1VM VM { get; set; }

        public event EventHandler CanExecuteChanged;

        public MoveImageCommand(Interior1VM vm)
        {
            VM = vm;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            string direction = parameter.ToString();
            switch(direction)
            {
                case "↑":
                    if (VM.ImageCanvasTop > -40) { VM.ImageCanvasTop -= 10; }
                    break;
                case "↓":
                    if(VM.ImageCanvasTop < 200) { VM.ImageCanvasTop += 10; }
                    break;
                case "←":
                    if(VM.ImageCanvasLeft > -60) { VM.ImageCanvasLeft -= 10; }
                    break;
                case "→":
                    if (VM.ImageCanvasLeft < 350) { VM.ImageCanvasLeft += 10; }
                    break;
            }

        }
    }
}
