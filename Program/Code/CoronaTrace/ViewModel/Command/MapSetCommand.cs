using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace CoronaTrace.ViewModel.Command
{
    public class MapSetCommand : ICommand
    {
        public MapWindowVM VM { get; set; }

        public event EventHandler CanExecuteChanged;

        public MapSetCommand(MapWindowVM vm)
        {
            VM = vm;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
 
            string input = parameter.ToString();
            switch (input)
            {
                case "1번":
                    VM.Location.Lat = 35.845379;
                    VM.Location.Lng = 127.124863;
                    VM.CurMapName = "덕진 광장로";
                    break;
                case "2번":
                    VM.Location.Lat = 35.842864;
                    VM.Location.Lng = 127.128150;
                    VM.CurMapName = "전북대학교 구정문";
                    break;
                case "3번":                    
                    VM.Location.Lat = 35.841668;
                    VM.Location.Lng = 127.133897;
                    VM.CurMapName = "전북대학교 정문";
                    break;
                case "4번":
                    VM.Location.Lat = 35.843914;
                    VM.Location.Lng = 127.138463;
                    VM.CurMapName = "정북대학교 사대부고쪽 입구";
                    break;
            }
            object[] ps = new object[] { VM.Location.Lat, VM.Location.Lng };
            VM.CurMapView.InvokeScript("MapSet", ps);

        }
    }

}
