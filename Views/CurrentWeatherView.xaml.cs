using System;
using System.Net;
using System.Collections.Generic;
using Windows.Networking;
using WeatherApp.ViewModels;
using Windows.Devices.Geolocation;
using Windows.Networking.Connectivity;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Input;

namespace WeatherApp.Views
{
    public partial class CurrentWeatherView : UserControl
    {
        public CurrentWeatherView()
        {
            this.InitializeComponent();

            this.Loaded += CurrentWeatherView_Loaded;
        }

        public void CurrentWeatherView_Loaded(object sender, RoutedEventArgs e)
        {
            DataContext = new CurrentWeather();

            LoadLocation();
        }

        public async void LoadLocation()
        {
            Geolocator locator = new Geolocator();
            Geoposition position;
            try
            {
                position = await locator.GetGeopositionAsync();
                ((CurrentWeather)DataContext).GetWeather(position.Coordinate.Point.Position.Latitude, position.Coordinate.Point.Position.Longitude);
            }
            catch (Exception e)
            {
                try
                {
                    //string s = string.Empty;
                    //foreach (HostName hn in NetworkInformation.GetHostNames())
                    //    if (hn.IPInformation != null && 
                    //       (hn.Type == HostNameType.Ipv4 || hn.Type == HostNameType.Ipv6) && 
                    //       !(hn.DisplayName.StartsWith("172.") || hn.DisplayName.StartsWith("192.") || hn.DisplayName.StartsWith("10.")))
                    //            s = hn.DisplayName;
                    ((CurrentWeather)DataContext).GetWeather("auto:ip");
                }
                catch
                {

                }
            }
        }

        private void ZipBox_KeyUp(object sender, KeyRoutedEventArgs e)
        {
            if (((TextBox)sender).Text.Length == 5)
            {
                string s = ZipBox.Text;
                ZipBox.Text = "";
                ((CurrentWeather)DataContext).GetWeather(s);
            }
        }
    }
}
