using ApiRequestLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfMetroApi;


namespace WpfMetroApi
{
    public class VMPositionsGPS : INotifyPropertyChanged
    {
       
        public MetroApi metro_api = new MetroApi();


        public double Latitude
        {
            get { return metro_api.Lat; }
            
            
            set { if (metro_api.Lat != value)
                    metro_api.Lat = value;
                OnPropertyChange("Lat");
                OnPropertyChange("Information");
                        } 
        }

        public double Longitude
        {
            get { return metro_api.Lon; }


            set
            {
                if (metro_api.Lon != value)
                    metro_api.Lon = value;
            }
        }

        public double Distance
        {
            get { return metro_api.Distance; }


            set
            {
                if (metro_api.Distance != value)
                    metro_api.Distance = (int) value;
            }
        }

        public List<LineData> GetApiDataString ()
        {
            return metro_api.GetLines();
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChange(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private ICommand _commandStart;
        public ICommand CommandStart
        {
            get => _commandStart ?? (_commandStart = new RelayCommand(o =>
            {

               
                OnPropertyChange("Information");
            },
    o => true));
            set => _commandStart = value;

        }

        public void Start()
        {
            //Do what ever
        }

        public bool CanStart()
        {
            return (DateTime.Now.DayOfWeek == DayOfWeek.Monday); //Can only click that button on mondays.
        }
    }
}
