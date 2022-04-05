using CoronaTrace.Model;
using CoronaTrace.ViewModel.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CoronaTrace.ViewModel
{
    public class MapWindowVM : INotifyPropertyChanged
    {
        public LocalInformation Location { get; set; }

        private string curMapName;
        public string CurMapName
        {
            get { return curMapName; }
            set
            {
                curMapName = value;
                OnPropertyChanged("curMapName");
            }
        }

        
        private int curSelectedIndex;
        public int CurSelectedIndex
        {
            get { return curSelectedIndex; }
            set
            {
                curSelectedIndex = value;
                OnPropertyChanged("CurSelectedIndex");
            }
        }

        private int curSelectedIndexCoro;
        public int CurSelectedIndexCoro
        {
            get { return curSelectedIndexCoro; }
            set
            {
                curSelectedIndexCoro = value;
                OnPropertyChanged("CurSelectedIndexCoro");
            }
        }

        private int curSelectedDistance;
        public int CurSelectedDistance
        {
            get { return curSelectedDistance; }
            set
            {
                curSelectedDistance = value;
                OnPropertyChanged("CurSelectedDistance");
            }
        }


        //현재 보이는 MapView
        private WebBrowser curmapView;
        public WebBrowser CurMapView
        {
            get { return curmapView; }
            set
            {
                curmapView = value;
                OnPropertyChanged("CurMapView");
            }
        }

        //Command
        public CheckCoronaCommand CheckCoronaCommand { get; set; }
        public MapSetCommand MapSetCommand { get; set; }
        public OpenInforWindowCommand OpenInforWindowCommand { get; set; }
        public SearchCategoryCommand FoodCategory { get; set; }
        public SearchCategoryCommand CafeCategory { get; set; }
        public SearchCategoryCommand ConCategory { get; set; }
        public SearchCategoryCommand HouseCategory { get; set; }
        public RouteOnOffCommand RouteOnOffCommand { get; set; }
        public SearchCoronaCommand SearchCoronaCommand { get; set; }
        public RemoveSearchCoronaCommand RemoveSearchCorona { get; set; }

        //생성자
        public MapWindowVM()
        {
            Location = new LocalInformation("덕진 광장로", 35.845379, 127.124863);
            OpenInforWindowCommand = new OpenInforWindowCommand();
            CheckCoronaCommand = new CheckCoronaCommand(this);
            MapSetCommand = new MapSetCommand(this);
            CurMapView = new WebBrowser() { Source = new Uri("https://wpprogramming.tiiny.site/") };
            FoodCategory = new SearchCategoryCommand(this,"food");
            CafeCategory = new SearchCategoryCommand(this, "cafe");
            ConCategory = new SearchCategoryCommand(this, "con");
            HouseCategory = new SearchCategoryCommand(this, "house");
            RouteOnOffCommand = new RouteOnOffCommand(this);
            CurMapName = "덕진 광장로";
            CurSelectedIndex = -1;
            CurSelectedIndexCoro = -1;
            CurSelectedDistance = -1;
            SearchCoronaCommand = new SearchCoronaCommand(this);
            RemoveSearchCorona = new RemoveSearchCoronaCommand(this);

            // 웹 데이터를 DataFromWebModel로 받음을 명시
            CurMapView.ObjectForScripting = new DataFromWebModel();
            CurMapView.Navigate(new Uri("https://wpprogramming.tiiny.site/"));
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
