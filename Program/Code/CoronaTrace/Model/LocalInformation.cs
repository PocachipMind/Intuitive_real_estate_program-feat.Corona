using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaTrace.Model
{
    public class LocalInformation : INotifyPropertyChanged
    {

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged("Name"); }
        }

        private double lat;

        public double Lat
        {
            get { return lat; }
            set { lat = value; OnPropertyChanged("Lat"); }
        }

        private double lng;

        public double Lng
        {
            get { return lng; }
            set { lng = value; OnPropertyChanged("Lng"); }
        }

        public LocalInformation(string name, double lat, double lng) 
        { 
            Name = name; Lat = lat; Lng = lng; 
        }

        public override string ToString() { return Name; }


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
