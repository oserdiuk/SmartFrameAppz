﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SmartFrame.AuthorizationServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserContract", Namespace="http://schemas.datacontract.org/2004/07/SmartFrame.Services.DataContracts")]
    [System.SerializableAttribute()]
    public partial class UserContract : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CityNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SmartFrame.AuthorizationServiceReference.ImageContract[] ImagesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SmartFrame.AuthorizationServiceReference.MoodContract MoodField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> MoodIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SmartFrame.AuthorizationServiceReference.PhotoModeContract PhotoModeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> PhotoModeIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SmartFrame.AuthorizationServiceReference.WeatherSavedContract[] WeatherField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
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
        public SmartFrame.AuthorizationServiceReference.ImageContract[] Images {
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
        public SmartFrame.AuthorizationServiceReference.MoodContract Mood {
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
        public SmartFrame.AuthorizationServiceReference.PhotoModeContract PhotoMode {
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
        public SmartFrame.AuthorizationServiceReference.WeatherSavedContract[] Weather {
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
    [System.SerializableAttribute()]
    public partial class MoodContract : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SmartFrame.AuthorizationServiceReference.ImageContract[] ImagesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SmartFrame.AuthorizationServiceReference.UserContract[] UsersField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
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
        public SmartFrame.AuthorizationServiceReference.ImageContract[] Images {
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
        public SmartFrame.AuthorizationServiceReference.UserContract[] Users {
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
    [System.Runtime.Serialization.DataContractAttribute(Name="PhotoModeContract", Namespace="http://schemas.datacontract.org/2004/07/SmartFrame.Services.DataContracts")]
    [System.SerializableAttribute()]
    public partial class PhotoModeContract : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SmartFrame.AuthorizationServiceReference.UserContract[] UsersField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
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
        public SmartFrame.AuthorizationServiceReference.UserContract[] Users {
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
    [System.SerializableAttribute()]
    public partial class ImageContract : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
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
    [System.Runtime.Serialization.DataContractAttribute(Name="WeatherSavedContract", Namespace="http://schemas.datacontract.org/2004/07/SmartFrame.Services.DataContracts")]
    [System.SerializableAttribute()]
    public partial class WeatherSavedContract : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TemperatureField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TemperatureFeelsLikeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SmartFrame.AuthorizationServiceReference.UserContract UserField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string WindDirectionTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int WindGustField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int WindSpeedField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
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
        public SmartFrame.AuthorizationServiceReference.UserContract User {
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AuthorizationServiceReference.IAuthService")]
    public interface IAuthService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthService/CreateUser", ReplyAction="http://tempuri.org/IAuthService/CreateUserResponse")]
        SmartFrame.AuthorizationServiceReference.UserContract CreateUser(SmartFrame.AuthorizationServiceReference.UserContract model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthService/CreateUser", ReplyAction="http://tempuri.org/IAuthService/CreateUserResponse")]
        System.Threading.Tasks.Task<SmartFrame.AuthorizationServiceReference.UserContract> CreateUserAsync(SmartFrame.AuthorizationServiceReference.UserContract model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthService/Login", ReplyAction="http://tempuri.org/IAuthService/LoginResponse")]
        SmartFrame.AuthorizationServiceReference.UserContract Login(string userName, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthService/Login", ReplyAction="http://tempuri.org/IAuthService/LoginResponse")]
        System.Threading.Tasks.Task<SmartFrame.AuthorizationServiceReference.UserContract> LoginAsync(string userName, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthService/GetByUserName", ReplyAction="http://tempuri.org/IAuthService/GetByUserNameResponse")]
        SmartFrame.AuthorizationServiceReference.UserContract GetByUserName(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthService/GetByUserName", ReplyAction="http://tempuri.org/IAuthService/GetByUserNameResponse")]
        System.Threading.Tasks.Task<SmartFrame.AuthorizationServiceReference.UserContract> GetByUserNameAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthService/Get", ReplyAction="http://tempuri.org/IAuthService/GetResponse")]
        SmartFrame.AuthorizationServiceReference.UserContract[] Get();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthService/Get", ReplyAction="http://tempuri.org/IAuthService/GetResponse")]
        System.Threading.Tasks.Task<SmartFrame.AuthorizationServiceReference.UserContract[]> GetAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAuthServiceChannel : SmartFrame.AuthorizationServiceReference.IAuthService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AuthServiceClient : System.ServiceModel.ClientBase<SmartFrame.AuthorizationServiceReference.IAuthService>, SmartFrame.AuthorizationServiceReference.IAuthService {
        
        public AuthServiceClient() {
        }
        
        public AuthServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AuthServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SmartFrame.AuthorizationServiceReference.UserContract CreateUser(SmartFrame.AuthorizationServiceReference.UserContract model) {
            return base.Channel.CreateUser(model);
        }
        
        public System.Threading.Tasks.Task<SmartFrame.AuthorizationServiceReference.UserContract> CreateUserAsync(SmartFrame.AuthorizationServiceReference.UserContract model) {
            return base.Channel.CreateUserAsync(model);
        }
        
        public SmartFrame.AuthorizationServiceReference.UserContract Login(string userName, string password) {
            return base.Channel.Login(userName, password);
        }
        
        public System.Threading.Tasks.Task<SmartFrame.AuthorizationServiceReference.UserContract> LoginAsync(string userName, string password) {
            return base.Channel.LoginAsync(userName, password);
        }
        
        public SmartFrame.AuthorizationServiceReference.UserContract GetByUserName(string name) {
            return base.Channel.GetByUserName(name);
        }
        
        public System.Threading.Tasks.Task<SmartFrame.AuthorizationServiceReference.UserContract> GetByUserNameAsync(string name) {
            return base.Channel.GetByUserNameAsync(name);
        }
        
        public SmartFrame.AuthorizationServiceReference.UserContract[] Get() {
            return base.Channel.Get();
        }
        
        public System.Threading.Tasks.Task<SmartFrame.AuthorizationServiceReference.UserContract[]> GetAsync() {
            return base.Channel.GetAsync();
        }
    }
}
