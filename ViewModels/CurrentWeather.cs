using System;
using System.Net;
using WeatherApp.Model;
using System.IO;
using Windows.UI.Core;
using System.Threading.Tasks;
using Windows.Data.Xml.Dom;
using XMLDocument = Windows.Data.Xml.Dom.XmlDocument;
using System.ComponentModel;
using Prism.Mvvm;
using WeatherApp.ServiceReference1;

namespace WeatherApp.ViewModels
{
    class CurrentWeather : BindableBase
    {
        private string currentLocation;
        private string request;
        private Weather immediateWeather = new Weather();

        public CurrentWeather(string location)
        {
            this.CurrentLocation = location;
            Load();
        }

        public CurrentWeather()
        {
            Load();
        }

        public Weather ImmediateWeather
        {
            get { return immediateWeather; }
            set { }
        }

        public void ImmediateWeather_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
                 RaisePropertyChanged(e.PropertyName);
        }

        protected void Load()
        {
            immediateWeather.PropertyChanged += ImmediateWeather_PropertyChanged;
        }

        public void GetWeather(string zip)
        {
            request = zip;
            GetWeather();
        }

        public void GetWeather(double lat, double lon)
        {
            request = lat.ToString() + "," + lon.ToString();
            GetWeather();
        }

        public void GetWeather(IPAddress ip)
        {
            request = ip.ToString();
            GetWeather();
        }

        private void GetWeather()
        {
            Task<ImmediateWeather> task = new Service1Client().GetDataAsync(request);
            task.Wait();
            SetWeather(task.Result);
        }

        private void SetWeather(ImmediateWeather weather)
        {
            this.Clouds = weather.clouds;
            this.Temperature = weather.temp;
            this.WindDirection = weather.windDir;
            this.WindSpeed = weather.windSpeed;
            this.CurrentLocation = weather.city + ", " + weather.state + ", " + weather.country;
        }

        public string CurrentLocation
        {
            get { return currentLocation; }
            set
            {
                    currentLocation = value;
                    RaisePropertyChanged("CurrentLocation");
            }
        }

        public decimal Temperature
        {
            get { return immediateWeather.Temperature; }
            set
            {
                    immediateWeather.Temperature = value;
                    RaisePropertyChanged("Temperature");
            }
        }

        public decimal WindSpeed
        {
            get { return immediateWeather.WindSpeed; }
            set
            {
                    immediateWeather.WindSpeed = value;
                    RaisePropertyChanged("WindSpeed");
            }
        }

        public string WindDirection
        {
            get { return immediateWeather.WindDirection; }
            set
            {
                    immediateWeather.WindDirection = value;
                    RaisePropertyChanged("WindSpeed");
            }
        }

        public string Clouds
        {
            get { return immediateWeather.Clouds; }
            set
            {
                    immediateWeather.Clouds = value;
                    RaisePropertyChanged("Clouds");
            }
        }
    }
}
