using CoronaTrace.ViewModel.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaTrace.Model
{

    public class Item
    {
        public string item_id { get; set; }
        public string sales_type { get; set; } 
        public string service_type { get; set; } 
        public IList<string> images { get; set; }
        public string image_thumbnail { get; set; }
        public string description { get; set; }
        public int 보증금액 { get; set; }
        public int 월세금액 { get; set; }
        public double 전용면적_m2 { get; set; }
        public string address { get; set; }
    }

    public class Agent
    {
        public string agent_title { get; set; }
        public string agent_phone { get; set; }
        public string agent_intro { get; set; }
    }

    public class HouseInformation : INotifyPropertyChanged
    {
        public Item item { get; set; }
        public Agent agent { get; set; }

        // 내부적으로 변환시키는 바인딩된 속성이있음.
        private string imageView;
        public string ImageView
        {
            get { return imageView; }
            set
            {
                imageView = value;
                OnPropertyChanged("ImageView");
            }
        }

        public ChangeImageViewCommand ChangeImageViewCommand { get; set; }

        public HouseInformation()
        {
            ChangeImageViewCommand = new ChangeImageViewCommand(this);
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
