using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;

namespace WeatherApp.Model
{
    class Weather : BindableBase
    {
        private decimal temperature;
        private decimal windSpeed;
        private string windDirection;
        private string clouds;

        public decimal Temperature
        {
            get { return temperature; }
            set {
                temperature = value;
                RaisePropertyChanged("Temperature");
            }
        }

        public decimal WindSpeed
        {
            get { return windSpeed; }
            set
            {
                windSpeed = value;
                RaisePropertyChanged("WindSpeed");
            }
        }

        public string WindDirection
        {
            get { return windDirection; }
            set
            {
                windDirection = value;
                RaisePropertyChanged("WindDirection");
            }
        }
        
        public string Clouds
        {
            get { return clouds; }
            set
            {
                clouds = value;
                RaisePropertyChanged("Clouds");
            }
        }
    }
}
