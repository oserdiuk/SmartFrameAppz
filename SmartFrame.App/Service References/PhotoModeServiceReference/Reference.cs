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
// This code was auto-generated by Microsoft.VisualStudio.ServiceReference.Platforms, version 14.0.23107.0
// 
namespace SmartFrame.App.PhotoModeServiceReference {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PhotoModeContract", Namespace="http://schemas.datacontract.org/2004/07/SmartFrame.Services.DataContracts")]
    public partial class PhotoModeContract : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int IdField;
        
        private string NameField;
        
        private System.Collections.ObjectModel.ObservableCollection<SmartFrame.App.PhotoModeServiceReference.UserContract> UsersField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.ObjectModel.ObservableCollection<SmartFrame.App.PhotoModeServiceReference.UserContract> Users {
            get {
                return this.UsersField;
            }
            set {
                if ((object.ReferenceEquals(this.UsersField, value) != true)) {
                    this.UsersField = value;
                    this.RaisePropertyChanged("Users");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserContract", Namespace="http://schemas.datacontract.org/2004/07/SmartFrame.Services.DataContracts")]
    public partial class UserContract : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string CityNameField;
        
        private string EmailField;
        
        private int IdField;
        
        private System.Collections.ObjectModel.ObservableCollection<SmartFrame.App.PhotoModeServiceReference.ImageContract> ImagesField;
        
        private SmartFrame.App.PhotoModeServiceReference.MoodContract MoodField;
        
        private System.Nullable<int> MoodIdField;
        
        private string PasswordField;
        
        private SmartFrame.App.PhotoModeServiceReference.PhotoModeContract PhotoModeField;
        
        private System.Nullable<int> PhotoModeIdField;
        
        private string UserNameField;
        
        private System.Collections.ObjectModel.ObservableCollection<SmartFrame.App.PhotoModeServiceReference.WeatherSavedContract> WeatherField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CityName {
            get {
                return this.CityNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CityNameField, value) != true)) {
                    this.CityNameField = value;
                    this.RaisePropertyChanged("CityName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.ObjectModel.ObservableCollection<SmartFrame.App.PhotoModeServiceReference.ImageContract> Images {
            get {
                return this.ImagesField;
            }
            set {
                if ((object.ReferenceEquals(this.ImagesField, value) != true)) {
                    this.ImagesField = value;
                    this.RaisePropertyChanged("Images");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SmartFrame.App.PhotoModeServiceReference.MoodContract Mood {
            get {
                return this.MoodField;
            }
            set {
                if ((object.ReferenceEquals(this.MoodField, value) != true)) {
                    this.MoodField = value;
                    this.RaisePropertyChanged("Mood");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> MoodId {
            get {
                return this.MoodIdField;
            }
            set {
                if ((this.MoodIdField.Equals(value) != true)) {
                    this.MoodIdField = value;
                    this.RaisePropertyChanged("MoodId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SmartFrame.App.PhotoModeServiceReference.PhotoModeContract PhotoMode {
            get {
                return this.PhotoModeField;
            }
            set {
                if ((object.ReferenceEquals(this.PhotoModeField, value) != true)) {
                    this.PhotoModeField = value;
                    this.RaisePropertyChanged("PhotoMode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> PhotoModeId {
            get {
                return this.PhotoModeIdField;
            }
            set {
                if ((this.PhotoModeIdField.Equals(value) != true)) {
                    this.PhotoModeIdField = value;
                    this.RaisePropertyChanged("PhotoModeId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.ObjectModel.ObservableCollection<SmartFrame.App.PhotoModeServiceReference.WeatherSavedContract> Weather {
            get {
                return this.WeatherField;
            }
            set {
                if ((object.ReferenceEquals(this.WeatherField, value) != true)) {
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MoodContract", Namespace="http://schemas.datacontract.org/2004/07/SmartFrame.Services.DataContracts")]
    public partial class MoodContract : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int IdField;
        
        private System.Collections.ObjectModel.ObservableCollection<SmartFrame.App.PhotoModeServiceReference.ImageContract> ImagesField;
        
        private string NameField;
        
        private System.Collections.ObjectModel.ObservableCollection<SmartFrame.App.PhotoModeServiceReference.UserContract> UsersField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.ObjectModel.ObservableCollection<SmartFrame.App.PhotoModeServiceReference.ImageContract> Images {
            get {
                return this.ImagesField;
            }
            set {
                if ((object.ReferenceEquals(this.ImagesField, value) != true)) {
                    this.ImagesField = value;
                    this.RaisePropertyChanged("Images");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.ObjectModel.ObservableCollection<SmartFrame.App.PhotoModeServiceReference.UserContract> Users {
            get {
                return this.UsersField;
            }
            set {
                if ((object.ReferenceEquals(this.UsersField, value) != true)) {
                    this.UsersField = value;
                    this.RaisePropertyChanged("Users");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ImageContract", Namespace="http://schemas.datacontract.org/2004/07/SmartFrame.Services.DataContracts")]
    public partial class ImageContract : object, System.ComponentModel.INotifyPropertyChanged {
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="WeatherSavedContract", Namespace="http://schemas.datacontract.org/2004/07/SmartFrame.Services.DataContracts")]
    public partial class WeatherSavedContract : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int IdField;
        
        private int TemperatureField;
        
        private int TemperatureFeelsLikeField;
        
        private SmartFrame.App.PhotoModeServiceReference.UserContract UserField;
        
        private string WindDirectionTypeField;
        
        private int WindGustField;
        
        private int WindSpeedField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Temperature {
            get {
                return this.TemperatureField;
            }
            set {
                if ((this.TemperatureField.Equals(value) != true)) {
                    this.TemperatureField = value;
                    this.RaisePropertyChanged("Temperature");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TemperatureFeelsLike {
            get {
                return this.TemperatureFeelsLikeField;
            }
            set {
                if ((this.TemperatureFeelsLikeField.Equals(value) != true)) {
                    this.TemperatureFeelsLikeField = value;
                    this.RaisePropertyChanged("TemperatureFeelsLike");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SmartFrame.App.PhotoModeServiceReference.UserContract User {
            get {
                return this.UserField;
            }
            set {
                if ((object.ReferenceEquals(this.UserField, value) != true)) {
                    this.UserField = value;
                    this.RaisePropertyChanged("User");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string WindDirectionType {
            get {
                return this.WindDirectionTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.WindDirectionTypeField, value) != true)) {
                    this.WindDirectionTypeField = value;
                    this.RaisePropertyChanged("WindDirectionType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int WindGust {
            get {
                return this.WindGustField;
            }
            set {
                if ((this.WindGustField.Equals(value) != true)) {
                    this.WindGustField = value;
                    this.RaisePropertyChanged("WindGust");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int WindSpeed {
            get {
                return this.WindSpeedField;
            }
            set {
                if ((this.WindSpeedField.Equals(value) != true)) {
                    this.WindSpeedField = value;
                    this.RaisePropertyChanged("WindSpeed");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PhotoModeServiceReference.IPhotoModeService")]
    public interface IPhotoModeService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPhotoModeService/GetAll", ReplyAction="http://tempuri.org/IPhotoModeService/GetAllResponse")]
        System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<SmartFrame.App.PhotoModeServiceReference.PhotoModeContract>> GetAllAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPhotoModeServiceChannel : SmartFrame.App.PhotoModeServiceReference.IPhotoModeService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PhotoModeServiceClient : System.ServiceModel.ClientBase<SmartFrame.App.PhotoModeServiceReference.IPhotoModeService>, SmartFrame.App.PhotoModeServiceReference.IPhotoModeService {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public PhotoModeServiceClient() : 
                base(PhotoModeServiceClient.GetDefaultBinding(), PhotoModeServiceClient.GetDefaultEndpointAddress()) {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IPhotoModeService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PhotoModeServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(PhotoModeServiceClient.GetBindingForEndpoint(endpointConfiguration), PhotoModeServiceClient.GetEndpointAddress(endpointConfiguration)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PhotoModeServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(PhotoModeServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PhotoModeServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(PhotoModeServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PhotoModeServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<SmartFrame.App.PhotoModeServiceReference.PhotoModeContract>> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IPhotoModeService)) {
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IPhotoModeService)) {
                return new System.ServiceModel.EndpointAddress("http://localhost:8733/api/photomodes");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding() {
            return PhotoModeServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IPhotoModeService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress() {
            return PhotoModeServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IPhotoModeService);
        }
        
        public enum EndpointConfiguration {
            
            BasicHttpBinding_IPhotoModeService,
        }
    }
}
