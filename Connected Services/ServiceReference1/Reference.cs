﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.VisualStudio.ServiceReference.Platforms, version 15.0.27428.1
// 
namespace WeatherApp.ServiceReference1 {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ImmediateWeather", Namespace="http://schemas.datacontract.org/2004/07/WeatherService")]
    public partial struct ImmediateWeather : System.ComponentModel.INotifyPropertyChanged {
        
        private string cityField;
        
        private string cloudsField;
        
        private string countryField;
        
        private string stateField;
        
        private decimal tempField;
        
        private string windDirField;
        
        private decimal windSpeedField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string city {
            get {
                return this.cityField;
            }
            set {
                if ((object.ReferenceEquals(this.cityField, value) != true)) {
                    this.cityField = value;
                    this.RaisePropertyChanged("city");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string clouds {
            get {
                return this.cloudsField;
            }
            set {
                if ((object.ReferenceEquals(this.cloudsField, value) != true)) {
                    this.cloudsField = value;
                    this.RaisePropertyChanged("clouds");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string country {
            get {
                return this.countryField;
            }
            set {
                if ((object.ReferenceEquals(this.countryField, value) != true)) {
                    this.countryField = value;
                    this.RaisePropertyChanged("country");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string state {
            get {
                return this.stateField;
            }
            set {
                if ((object.ReferenceEquals(this.stateField, value) != true)) {
                    this.stateField = value;
                    this.RaisePropertyChanged("state");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal temp {
            get {
                return this.tempField;
            }
            set {
                if ((this.tempField.Equals(value) != true)) {
                    this.tempField = value;
                    this.RaisePropertyChanged("temp");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string windDir {
            get {
                return this.windDirField;
            }
            set {
                if ((object.ReferenceEquals(this.windDirField, value) != true)) {
                    this.windDirField = value;
                    this.RaisePropertyChanged("windDir");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal windSpeed {
            get {
                return this.windSpeedField;
            }
            set {
                if ((this.windSpeedField.Equals(value) != true)) {
                    this.windSpeedField = value;
                    this.RaisePropertyChanged("windSpeed");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/WeatherService")]
    public partial class CompositeType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private WeatherApp.ServiceReference1.ImmediateWeather WeatherField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WeatherApp.ServiceReference1.ImmediateWeather Weather {
            get {
                return this.WeatherField;
            }
            set {
                if ((this.WeatherField.Equals(value) != true)) {
                    this.WeatherField = value;
                    this.RaisePropertyChanged("Weather");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<WeatherApp.ServiceReference1.ImmediateWeather> GetDataAsync(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<WeatherApp.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(WeatherApp.ServiceReference1.CompositeType composite);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WeatherApp.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WeatherApp.ServiceReference1.IService1>, WeatherApp.ServiceReference1.IService1 {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public Service1Client() : 
                base(Service1Client.GetDefaultBinding(), Service1Client.GetDefaultEndpointAddress()) {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IService1.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1Client(EndpointConfiguration endpointConfiguration) : 
                base(Service1Client.GetBindingForEndpoint(endpointConfiguration), Service1Client.GetEndpointAddress(endpointConfiguration)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1Client(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(Service1Client.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1Client(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(Service1Client.GetBindingForEndpoint(endpointConfiguration), remoteAddress) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Threading.Tasks.Task<WeatherApp.ServiceReference1.ImmediateWeather> GetDataAsync(string value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public System.Threading.Tasks.Task<WeatherApp.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(WeatherApp.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IService1)) {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IService1)) {
                return new System.ServiceModel.EndpointAddress("http://localhost:8733/WeatherService/Service1/");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding() {
            return Service1Client.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IService1);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress() {
            return Service1Client.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IService1);
        }
        
        public enum EndpointConfiguration {
            
            BasicHttpBinding_IService1,
        }
    }
}
