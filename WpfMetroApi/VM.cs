using ApiRequestLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfMetroApi
{
    public class VM()
    {
        public MetroApi metro_api = new MetroApi();
        

        public double latitude {
            get { return metro_api.Lat; }
            
            
            set { if (metro_api.Lat != value)
                    metro_api.Lat = value;
                        } 
        }

        public double longitude
        {
            get { return metro_api.Lon; }


            set
            {
                if (metro_api.Lon != value)
                    metro_api.Lon = value;
            }
        }

        public double distance
        {
            get { return metro_api.Distance; }


            set
            {
                if (metro_api.Distance != value)
                    metro_api.Distance = (int) value;
            }
        }

        public List<LineData> getApiDataString ()
        {
            return metro_api.jsonFormatServerResponse();
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChange(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
