using CoronaTrace.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CoronaTrace.ViewModel.Command
{
    public class ChangeImageViewCommand : ICommand
    {
        public HouseInformation VM { get; set; }

        public event EventHandler CanExecuteChanged;

        public ChangeImageViewCommand(HouseInformation vm)
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
            int cur = 0;
            for (int i = 0; i < VM.item.images.Count; i++)
            {
                if(VM.item.images[i] == VM.ImageView)
                {
                    cur = i;
                }
                
            }

            if (direction == "←" && cur > 0)
            {
                VM.ImageView = VM.item.images[cur - 1];
            }
            else if (direction == "→" && cur < VM.item.images.Count - 1)
            {
                VM.ImageView = VM.item.images[cur + 1];
            }


        }
    }
}
