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

namespace WeatherApp.ViewModels
{
    class CurrentWeather : BindableBase
    {
        private string currentLocation;
        private WebRequest request;
        private Weather immediateWeather = new Weather();
        private static readonly string URL_START = "https://api.apixu.com/v1/current.xml";
        private static readonly string URL_KEY = "ff436f1b91a7474aab4223122170710";
        private static readonly string URL = URL_START + "?q={0}&key=" + URL_KEY;
        private string url;

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
            url = URL;
            //request = WebRequest.Create(string.Format(url, this.currentLocation));
            immediateWeather.PropertyChanged += ImmediateWeather_PropertyChanged;
        }

        protected void SetRequest(string val)
        {
            request = WebRequest.Create(string.Format(url, val));
        }

        //public void GetWeather()
        //{
            
        //    request.BeginGetResponse(new AsyncCallback(SetWeather), null);
        //}

        public void GetWeather(string zip)
        {
            SetRequest(zip);
            Task<WebResponse> response = request.GetResponseAsync();
            response.Wait();
            SetWeather(response.Result);
        }

        public void GetWeather(double lat, double lon)
        {
            SetRequest(lat.ToString() + "," + lon.ToString());
            Task<WebResponse> response = request.GetResponseAsync();
            response.Wait();
            SetWeather(response.Result);
        }

        public void GetWeather(IPAddress ip)
        {
            SetRequest(ip.ToString());
            Task<WebResponse> response = request.GetResponseAsync();
            response.Wait();
            SetWeather(response.Result);
        }

        private string Parse(string s, string name)
        {
            XMLDocument doc = new XMLDocument();
            doc.LoadXml(s);
            IXmlNode node = doc.SelectSingleNode(name);
            return node.InnerText;
        }

        public void SetWeather(IAsyncResult result)
        {
            SetWeather(request.EndGetResponse(result));
        }

        public void SetWeather(WebResponse response)
        {
            Stream s = response.GetResponseStream();
            StreamReader sr = new StreamReader(s);
            string r = sr.ReadToEnd();

            immediateWeather.Temperature = decimal.Parse(Parse(r, "/root/current/temp_f"));
            immediateWeather.WindSpeed = decimal.Parse(Parse(r, "/root/current/wind_mph"));
            immediateWeather.WindDirection = Parse(r, "/root/current/wind_dir");
            immediateWeather.Clouds = Parse(r, "/root/current/condition/text");
            CurrentLocation = Parse(r, "/root/location/name") + ", " + Parse(r, "/root/location/region") + ", " + Parse(r, "/root/location/country");
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
