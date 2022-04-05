using CoronaTrace.Model;
using CoronaTrace.ViewModel.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace CoronaTrace.ViewModel
{
    public class Interior1VM : INotifyPropertyChanged
    {
        public SelectLengthCommand SelectLengthCommand { get; set; }
        public MoveImageCommand MoveImageCommand { get; set; }
        public ReverseButtonCommand ReverseButtonCommand { get; set; }

        public string CheckLen;

        private string curimage;
        public string CurImage
        {
            get { return curimage; }
            set
            {
                curimage = value;
                OnPropertyChanged("CurImage");
            }
        }

        private string lenSource;
        public string LenSource
        {
            get { return lenSource; }
            set
            {
                lenSource = value;
                OnPropertyChanged("LenSource");
            }
        }


        private int curselectedIndex;
        public int CurSelectedIndex
        {
            get { return curselectedIndex; }
            set
            {
                curselectedIndex = value;
                OnPropertyChanged("CurSelectedIndex");
                switch(CurSelectedIndex)
                {
                    case 0:
                        CurImage = "/View/Image/frozen.png";
                        break;
                    case 1:
                        CurImage = "/View/Image/desk.png";
                        break;
                    default:
                        break;
                }
            }
        }

        private int imagewidth;
        public int ImageWidth
        {
            get { return imagewidth; }
            set
            {
                if(value > 0)
                {
                    imagewidth = value;
                    if (CheckLen == "two")
                    {
                        imagewidth = 2 * value;
                    }
                    if (CheckLen == "three")
                    {
                        imagewidth = 3 * value;
                    }
                    OnPropertyChanged("ImageWidth");

                }
                
            }
        }

        private int imageheight;
        public int ImageHeight
        {
            get { return imageheight; }
            set
            {
                if(value > 0)
                {
                    imageheight = value;
                    if (CheckLen == "two")
                    {
                        imageheight = 2 * value;
                    }
                    if (CheckLen == "three")
                    {
                        imageheight = 3 * value;
                    }
                    OnPropertyChanged("ImageHeight");

                }

            }
        }

        private int imagecanvasleft;
        public int ImageCanvasLeft
        {
            get { return imagecanvasleft; }
            set
            {
                imagecanvasleft = value;
                OnPropertyChanged("ImageCanvasLeft");

            }
        }

        private int Imagecanvastop;
        public int ImageCanvasTop
        {
            get { return Imagecanvastop; }
            set
            {
                Imagecanvastop = value;
                OnPropertyChanged("ImageCanvasTop");

            }
        }


        //생성자
        public Interior1VM()
        {
            SelectLengthCommand = new SelectLengthCommand(this);
            LenSource = "/View/Image/table.png";
            CurSelectedIndex = -1;
            ImageHeight = 140;
            ImageWidth = 90;
            ImageCanvasLeft = 0;
            ImageCanvasTop = 0;
            MoveImageCommand = new MoveImageCommand(this);
            ReverseButtonCommand = new ReverseButtonCommand(this);
            CheckLen = "zero";
        }


        //의존속성 함수 구현
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
