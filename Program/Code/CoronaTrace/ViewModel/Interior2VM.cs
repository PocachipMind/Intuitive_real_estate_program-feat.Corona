using CoronaTrace.ViewModel.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaTrace.ViewModel
{
    public class Interior2VM : INotifyPropertyChanged
    {
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

        private int curselectedIndex;
        public int CurSelectedIndex
        {
            get { return curselectedIndex; }
            set
            {
                curselectedIndex = value;
                OnPropertyChanged("CurSelectedIndex");
                switch (CurSelectedIndex)
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

        private double imagelocation;
        public double ImageLocation
        {
            get { return imagelocation; }
            set
            {
                imagelocation = value;
                OnPropertyChanged("ImageLocation");
                SetShownImage(ImageLocation);

            }
        }

        private double imagewidth;
        public double ImageWidth
        {
            get { return imagewidth; }
            set
            {
                if( value > 0 )
                {
                    imagewidth = value;
                    OnPropertyChanged("ImageWidth");
                    SetShownImage(ImageLocation);
                }

            }
        }

        private double imageheight;
        public double ImageHeight
        {
            get { return imageheight; }
            set
            {
                if( value > 0)
                {
                    imageheight = value;
                    OnPropertyChanged("ImageHeight");
                    SetShownImage(ImageLocation);
                }

            }
        }

        private double changedwidth;
        public double ChangedWidth
        {
            get { return changedwidth; }
            set
            {
                changedwidth = value;
                OnPropertyChanged("ChangedWidth");

            }
        }

        private double changedheight;
        public double ChangedHeight
        {
            get { return changedheight; }
            set
            {
                changedheight = value;
                OnPropertyChanged("ChangedHeight");

            }
        }


        //생성자
        public Interior2VM()
        {
            CurSelectedIndex = -1;
            ImageHeight = 180;
            ImageWidth = 140;
            SetShownImage(ImageLocation);

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
        
        private void SetShownImage(double ImageLocation)
        {
            if( ImageLocation < 170)
            {
                switch(CurImage)
                {
                    case "/View/Image/frozenreverse.png":
                        CurImage = "/View/Image/frozen.png";
                        break;
                    case "/View/Image/deskreverse.png":
                        CurImage = "/View/Image/desk.png";
                        break;
                    default:
                        break;
                }

                //45% 까지 감소되어감
                ChangedHeight = ImageHeight * (1 - ((ImageLocation + 42) / 385));
                ChangedWidth = ImageWidth * (1 - ((ImageLocation + 42) / 385));


            }
            else
            {
                switch (CurImage)
                {
                    case "/View/Image/frozen.png":
                        CurImage = "/View/Image/frozenreverse.png";
                        break;
                    case "/View/Image/desk.png":
                        CurImage = "/View/Image/deskreverse.png";
                        break;
                    default:
                        break;
                }
                ChangedHeight = (ImageHeight * 45/100) *(1+((ImageLocation - 170) / 185));
                ChangedWidth = (ImageWidth * 45 / 100) * (1 + ((ImageLocation - 170) / 185));

            }
            

        }
        
    }
}
