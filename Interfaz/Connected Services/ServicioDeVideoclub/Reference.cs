﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Interfaz.ServicioDeVideoclub {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Cliente", Namespace="http://schemas.datacontract.org/2004/07/ServicioVideoClub")]
    [System.SerializableAttribute()]
    public partial class Cliente : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApellidoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DireccionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DniField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
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
        public string Apellido {
            get {
                return this.ApellidoField;
            }
            set {
                if ((object.ReferenceEquals(this.ApellidoField, value) != true)) {
                    this.ApellidoField = value;
                    this.RaisePropertyChanged("Apellido");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Direccion {
            get {
                return this.DireccionField;
            }
            set {
                if ((object.ReferenceEquals(this.DireccionField, value) != true)) {
                    this.DireccionField = value;
                    this.RaisePropertyChanged("Direccion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Dni {
            get {
                return this.DniField;
            }
            set {
                if ((object.ReferenceEquals(this.DniField, value) != true)) {
                    this.DniField = value;
                    this.RaisePropertyChanged("Dni");
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
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Pelicula", Namespace="http://schemas.datacontract.org/2004/07/ServicioVideoClub")]
    [System.SerializableAttribute()]
    public partial class Pelicula : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FechaInsercionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GeneroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TituloField;
        
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
        public System.DateTime FechaInsercion {
            get {
                return this.FechaInsercionField;
            }
            set {
                if ((this.FechaInsercionField.Equals(value) != true)) {
                    this.FechaInsercionField = value;
                    this.RaisePropertyChanged("FechaInsercion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Genero {
            get {
                return this.GeneroField;
            }
            set {
                if ((object.ReferenceEquals(this.GeneroField, value) != true)) {
                    this.GeneroField = value;
                    this.RaisePropertyChanged("Genero");
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
        public string Titulo {
            get {
                return this.TituloField;
            }
            set {
                if ((object.ReferenceEquals(this.TituloField, value) != true)) {
                    this.TituloField = value;
                    this.RaisePropertyChanged("Titulo");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicioDeVideoclub.IVideoclubServicio")]
    public interface IVideoclubServicio {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVideoclubServicio/AnadeCliente", ReplyAction="http://tempuri.org/IVideoclubServicio/AnadeClienteResponse")]
        bool AnadeCliente(string nombre, string apellido, string direccion, string dni);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVideoclubServicio/AnadeCliente", ReplyAction="http://tempuri.org/IVideoclubServicio/AnadeClienteResponse")]
        System.Threading.Tasks.Task<bool> AnadeClienteAsync(string nombre, string apellido, string direccion, string dni);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVideoclubServicio/AnadePelicula", ReplyAction="http://tempuri.org/IVideoclubServicio/AnadePeliculaResponse")]
        bool AnadePelicula(string nombre, string genero, System.DateTime fecha);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVideoclubServicio/AnadePelicula", ReplyAction="http://tempuri.org/IVideoclubServicio/AnadePeliculaResponse")]
        System.Threading.Tasks.Task<bool> AnadePeliculaAsync(string nombre, string genero, System.DateTime fecha);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVideoclubServicio/EliminarCliente", ReplyAction="http://tempuri.org/IVideoclubServicio/EliminarClienteResponse")]
        bool EliminarCliente(Interfaz.ServicioDeVideoclub.Cliente cliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVideoclubServicio/EliminarCliente", ReplyAction="http://tempuri.org/IVideoclubServicio/EliminarClienteResponse")]
        System.Threading.Tasks.Task<bool> EliminarClienteAsync(Interfaz.ServicioDeVideoclub.Cliente cliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVideoclubServicio/EliminarPelicula", ReplyAction="http://tempuri.org/IVideoclubServicio/EliminarPeliculaResponse")]
        bool EliminarPelicula(Interfaz.ServicioDeVideoclub.Pelicula pelicula);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVideoclubServicio/EliminarPelicula", ReplyAction="http://tempuri.org/IVideoclubServicio/EliminarPeliculaResponse")]
        System.Threading.Tasks.Task<bool> EliminarPeliculaAsync(Interfaz.ServicioDeVideoclub.Pelicula pelicula);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVideoclubServicio/DevuelveClientes", ReplyAction="http://tempuri.org/IVideoclubServicio/DevuelveClientesResponse")]
        Interfaz.ServicioDeVideoclub.Cliente[] DevuelveClientes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVideoclubServicio/DevuelveClientes", ReplyAction="http://tempuri.org/IVideoclubServicio/DevuelveClientesResponse")]
        System.Threading.Tasks.Task<Interfaz.ServicioDeVideoclub.Cliente[]> DevuelveClientesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVideoclubServicio/DevuelvePeliculas", ReplyAction="http://tempuri.org/IVideoclubServicio/DevuelvePeliculasResponse")]
        Interfaz.ServicioDeVideoclub.Pelicula[] DevuelvePeliculas();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVideoclubServicio/DevuelvePeliculas", ReplyAction="http://tempuri.org/IVideoclubServicio/DevuelvePeliculasResponse")]
        System.Threading.Tasks.Task<Interfaz.ServicioDeVideoclub.Pelicula[]> DevuelvePeliculasAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVideoclubServicio/DevuelvePeliculasPorDias", ReplyAction="http://tempuri.org/IVideoclubServicio/DevuelvePeliculasPorDiasResponse")]
        Interfaz.ServicioDeVideoclub.Pelicula[] DevuelvePeliculasPorDias(int dias);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVideoclubServicio/DevuelvePeliculasPorDias", ReplyAction="http://tempuri.org/IVideoclubServicio/DevuelvePeliculasPorDiasResponse")]
        System.Threading.Tasks.Task<Interfaz.ServicioDeVideoclub.Pelicula[]> DevuelvePeliculasPorDiasAsync(int dias);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVideoclubServicio/DevuelvePeliculasPorGenero", ReplyAction="http://tempuri.org/IVideoclubServicio/DevuelvePeliculasPorGeneroResponse")]
        Interfaz.ServicioDeVideoclub.Pelicula[] DevuelvePeliculasPorGenero(string genero);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVideoclubServicio/DevuelvePeliculasPorGenero", ReplyAction="http://tempuri.org/IVideoclubServicio/DevuelvePeliculasPorGeneroResponse")]
        System.Threading.Tasks.Task<Interfaz.ServicioDeVideoclub.Pelicula[]> DevuelvePeliculasPorGeneroAsync(string genero);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVideoclubServicio/DevuelvePeliculasPorNombre", ReplyAction="http://tempuri.org/IVideoclubServicio/DevuelvePeliculasPorNombreResponse")]
        Interfaz.ServicioDeVideoclub.Pelicula[] DevuelvePeliculasPorNombre(string nombre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVideoclubServicio/DevuelvePeliculasPorNombre", ReplyAction="http://tempuri.org/IVideoclubServicio/DevuelvePeliculasPorNombreResponse")]
        System.Threading.Tasks.Task<Interfaz.ServicioDeVideoclub.Pelicula[]> DevuelvePeliculasPorNombreAsync(string nombre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVideoclubServicio/DevuelveTiposPeliculas", ReplyAction="http://tempuri.org/IVideoclubServicio/DevuelveTiposPeliculasResponse")]
        string[] DevuelveTiposPeliculas();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVideoclubServicio/DevuelveTiposPeliculas", ReplyAction="http://tempuri.org/IVideoclubServicio/DevuelveTiposPeliculasResponse")]
        System.Threading.Tasks.Task<string[]> DevuelveTiposPeliculasAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IVideoclubServicioChannel : Interfaz.ServicioDeVideoclub.IVideoclubServicio, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class VideoclubServicioClient : System.ServiceModel.ClientBase<Interfaz.ServicioDeVideoclub.IVideoclubServicio>, Interfaz.ServicioDeVideoclub.IVideoclubServicio {
        
        public VideoclubServicioClient() {
        }
        
        public VideoclubServicioClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public VideoclubServicioClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public VideoclubServicioClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public VideoclubServicioClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool AnadeCliente(string nombre, string apellido, string direccion, string dni) {
            return base.Channel.AnadeCliente(nombre, apellido, direccion, dni);
        }
        
        public System.Threading.Tasks.Task<bool> AnadeClienteAsync(string nombre, string apellido, string direccion, string dni) {
            return base.Channel.AnadeClienteAsync(nombre, apellido, direccion, dni);
        }
        
        public bool AnadePelicula(string nombre, string genero, System.DateTime fecha) {
            return base.Channel.AnadePelicula(nombre, genero, fecha);
        }
        
        public System.Threading.Tasks.Task<bool> AnadePeliculaAsync(string nombre, string genero, System.DateTime fecha) {
            return base.Channel.AnadePeliculaAsync(nombre, genero, fecha);
        }
        
        public bool EliminarCliente(Interfaz.ServicioDeVideoclub.Cliente cliente) {
            return base.Channel.EliminarCliente(cliente);
        }
        
        public System.Threading.Tasks.Task<bool> EliminarClienteAsync(Interfaz.ServicioDeVideoclub.Cliente cliente) {
            return base.Channel.EliminarClienteAsync(cliente);
        }
        
        public bool EliminarPelicula(Interfaz.ServicioDeVideoclub.Pelicula pelicula) {
            return base.Channel.EliminarPelicula(pelicula);
        }
        
        public System.Threading.Tasks.Task<bool> EliminarPeliculaAsync(Interfaz.ServicioDeVideoclub.Pelicula pelicula) {
            return base.Channel.EliminarPeliculaAsync(pelicula);
        }
        
        public Interfaz.ServicioDeVideoclub.Cliente[] DevuelveClientes() {
            return base.Channel.DevuelveClientes();
        }
        
        public System.Threading.Tasks.Task<Interfaz.ServicioDeVideoclub.Cliente[]> DevuelveClientesAsync() {
            return base.Channel.DevuelveClientesAsync();
        }
        
        public Interfaz.ServicioDeVideoclub.Pelicula[] DevuelvePeliculas() {
            return base.Channel.DevuelvePeliculas();
        }
        
        public System.Threading.Tasks.Task<Interfaz.ServicioDeVideoclub.Pelicula[]> DevuelvePeliculasAsync() {
            return base.Channel.DevuelvePeliculasAsync();
        }
        
        public Interfaz.ServicioDeVideoclub.Pelicula[] DevuelvePeliculasPorDias(int dias) {
            return base.Channel.DevuelvePeliculasPorDias(dias);
        }
        
        public System.Threading.Tasks.Task<Interfaz.ServicioDeVideoclub.Pelicula[]> DevuelvePeliculasPorDiasAsync(int dias) {
            return base.Channel.DevuelvePeliculasPorDiasAsync(dias);
        }
        
        public Interfaz.ServicioDeVideoclub.Pelicula[] DevuelvePeliculasPorGenero(string genero) {
            return base.Channel.DevuelvePeliculasPorGenero(genero);
        }
        
        public System.Threading.Tasks.Task<Interfaz.ServicioDeVideoclub.Pelicula[]> DevuelvePeliculasPorGeneroAsync(string genero) {
            return base.Channel.DevuelvePeliculasPorGeneroAsync(genero);
        }
        
        public Interfaz.ServicioDeVideoclub.Pelicula[] DevuelvePeliculasPorNombre(string nombre) {
            return base.Channel.DevuelvePeliculasPorNombre(nombre);
        }
        
        public System.Threading.Tasks.Task<Interfaz.ServicioDeVideoclub.Pelicula[]> DevuelvePeliculasPorNombreAsync(string nombre) {
            return base.Channel.DevuelvePeliculasPorNombreAsync(nombre);
        }
        
        public string[] DevuelveTiposPeliculas() {
            return base.Channel.DevuelveTiposPeliculas();
        }
        
        public System.Threading.Tasks.Task<string[]> DevuelveTiposPeliculasAsync() {
            return base.Channel.DevuelveTiposPeliculasAsync();
        }
    }
}
