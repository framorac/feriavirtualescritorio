﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace COMPLETE_FLAT_UI.ServiceVentas {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Ventas", Namespace="http://schemas.datacontract.org/2004/07/FeriaVirtualServices.Structures.Tables")]
    [System.SerializableAttribute()]
    public partial class Ventas : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime fechaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string tipoVentaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string usernameField;
        
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
        public System.DateTime fecha {
            get {
                return this.fechaField;
            }
            set {
                if ((this.fechaField.Equals(value) != true)) {
                    this.fechaField = value;
                    this.RaisePropertyChanged("fecha");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string tipoVenta {
            get {
                return this.tipoVentaField;
            }
            set {
                if ((object.ReferenceEquals(this.tipoVentaField, value) != true)) {
                    this.tipoVentaField = value;
                    this.RaisePropertyChanged("tipoVenta");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string username {
            get {
                return this.usernameField;
            }
            set {
                if ((object.ReferenceEquals(this.usernameField, value) != true)) {
                    this.usernameField = value;
                    this.RaisePropertyChanged("username");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="HistoricoEstadoVentas", Namespace="http://schemas.datacontract.org/2004/07/FeriaVirtualServices.Structures.Tables")]
    [System.SerializableAttribute()]
    public partial class HistoricoEstadoVentas : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool ActivoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FechaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Id_ventaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IslocalField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TipoEstadoField;
        
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
        public bool Activo {
            get {
                return this.ActivoField;
            }
            set {
                if ((this.ActivoField.Equals(value) != true)) {
                    this.ActivoField = value;
                    this.RaisePropertyChanged("Activo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Fecha {
            get {
                return this.FechaField;
            }
            set {
                if ((this.FechaField.Equals(value) != true)) {
                    this.FechaField = value;
                    this.RaisePropertyChanged("Fecha");
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
        public int Id_venta {
            get {
                return this.Id_ventaField;
            }
            set {
                if ((this.Id_ventaField.Equals(value) != true)) {
                    this.Id_ventaField = value;
                    this.RaisePropertyChanged("Id_venta");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Islocal {
            get {
                return this.IslocalField;
            }
            set {
                if ((this.IslocalField.Equals(value) != true)) {
                    this.IslocalField = value;
                    this.RaisePropertyChanged("Islocal");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TipoEstado {
            get {
                return this.TipoEstadoField;
            }
            set {
                if ((object.ReferenceEquals(this.TipoEstadoField, value) != true)) {
                    this.TipoEstadoField = value;
                    this.RaisePropertyChanged("TipoEstado");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="VentaCompleta", Namespace="http://schemas.datacontract.org/2004/07/FeriaVirtualServices.Structures.Tables")]
    [System.SerializableAttribute()]
    public partial class VentaCompleta : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FechaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreApellidoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TipoField;
        
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
        public string Estado {
            get {
                return this.EstadoField;
            }
            set {
                if ((object.ReferenceEquals(this.EstadoField, value) != true)) {
                    this.EstadoField = value;
                    this.RaisePropertyChanged("Estado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Fecha {
            get {
                return this.FechaField;
            }
            set {
                if ((this.FechaField.Equals(value) != true)) {
                    this.FechaField = value;
                    this.RaisePropertyChanged("Fecha");
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
        public string NombreApellido {
            get {
                return this.NombreApellidoField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreApellidoField, value) != true)) {
                    this.NombreApellidoField = value;
                    this.RaisePropertyChanged("NombreApellido");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Tipo {
            get {
                return this.TipoField;
            }
            set {
                if ((object.ReferenceEquals(this.TipoField, value) != true)) {
                    this.TipoField = value;
                    this.RaisePropertyChanged("Tipo");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceVentas.IServiceVentas")]
    public interface IServiceVentas {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceVentas/GetVentas", ReplyAction="http://tempuri.org/IServiceVentas/GetVentasResponse")]
        COMPLETE_FLAT_UI.ServiceVentas.Ventas[] GetVentas();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceVentas/GetVentas", ReplyAction="http://tempuri.org/IServiceVentas/GetVentasResponse")]
        System.Threading.Tasks.Task<COMPLETE_FLAT_UI.ServiceVentas.Ventas[]> GetVentasAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceVentas/InsertVenta", ReplyAction="http://tempuri.org/IServiceVentas/InsertVentaResponse")]
        string InsertVenta(int fk_usuario, System.DateTime fecha, int fk_tipoVenta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceVentas/InsertVenta", ReplyAction="http://tempuri.org/IServiceVentas/InsertVentaResponse")]
        System.Threading.Tasks.Task<string> InsertVentaAsync(int fk_usuario, System.DateTime fecha, int fk_tipoVenta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceVentas/DeleteVenta", ReplyAction="http://tempuri.org/IServiceVentas/DeleteVentaResponse")]
        string DeleteVenta(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceVentas/DeleteVenta", ReplyAction="http://tempuri.org/IServiceVentas/DeleteVentaResponse")]
        System.Threading.Tasks.Task<string> DeleteVentaAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceVentas/UpdateVenta", ReplyAction="http://tempuri.org/IServiceVentas/UpdateVentaResponse")]
        string UpdateVenta(int id_estado, int id_venta, char isLocal);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceVentas/UpdateVenta", ReplyAction="http://tempuri.org/IServiceVentas/UpdateVentaResponse")]
        System.Threading.Tasks.Task<string> UpdateVentaAsync(int id_estado, int id_venta, char isLocal);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceVentas/GetHistóricoEstadoVentas", ReplyAction="http://tempuri.org/IServiceVentas/GetHistóricoEstadoVentasResponse")]
        COMPLETE_FLAT_UI.ServiceVentas.HistoricoEstadoVentas[] GetHistóricoEstadoVentas();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceVentas/GetHistóricoEstadoVentas", ReplyAction="http://tempuri.org/IServiceVentas/GetHistóricoEstadoVentasResponse")]
        System.Threading.Tasks.Task<COMPLETE_FLAT_UI.ServiceVentas.HistoricoEstadoVentas[]> GetHistóricoEstadoVentasAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceVentas/GetVentaCompleta", ReplyAction="http://tempuri.org/IServiceVentas/GetVentaCompletaResponse")]
        COMPLETE_FLAT_UI.ServiceVentas.VentaCompleta[] GetVentaCompleta(int idTipoEstado, int idTipoVenta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceVentas/GetVentaCompleta", ReplyAction="http://tempuri.org/IServiceVentas/GetVentaCompletaResponse")]
        System.Threading.Tasks.Task<COMPLETE_FLAT_UI.ServiceVentas.VentaCompleta[]> GetVentaCompletaAsync(int idTipoEstado, int idTipoVenta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceVentas/GetVentaCompletaFiltradoAbierto", ReplyAction="http://tempuri.org/IServiceVentas/GetVentaCompletaFiltradoAbiertoResponse")]
        COMPLETE_FLAT_UI.ServiceVentas.VentaCompleta[] GetVentaCompletaFiltradoAbierto(int idTipoEstado, int idTipoVenta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceVentas/GetVentaCompletaFiltradoAbierto", ReplyAction="http://tempuri.org/IServiceVentas/GetVentaCompletaFiltradoAbiertoResponse")]
        System.Threading.Tasks.Task<COMPLETE_FLAT_UI.ServiceVentas.VentaCompleta[]> GetVentaCompletaFiltradoAbiertoAsync(int idTipoEstado, int idTipoVenta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceVentas/GetVentaCompletaFiltradoIngresada", ReplyAction="http://tempuri.org/IServiceVentas/GetVentaCompletaFiltradoIngresadaResponse")]
        COMPLETE_FLAT_UI.ServiceVentas.VentaCompleta[] GetVentaCompletaFiltradoIngresada(int idTipoEstado, int idTipoVenta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceVentas/GetVentaCompletaFiltradoIngresada", ReplyAction="http://tempuri.org/IServiceVentas/GetVentaCompletaFiltradoIngresadaResponse")]
        System.Threading.Tasks.Task<COMPLETE_FLAT_UI.ServiceVentas.VentaCompleta[]> GetVentaCompletaFiltradoIngresadaAsync(int idTipoEstado, int idTipoVenta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceVentas/GetVentaCompletaFiltradoEnSubasta", ReplyAction="http://tempuri.org/IServiceVentas/GetVentaCompletaFiltradoEnSubastaResponse")]
        COMPLETE_FLAT_UI.ServiceVentas.VentaCompleta[] GetVentaCompletaFiltradoEnSubasta(int idTipoEstado, int idTipoVenta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceVentas/GetVentaCompletaFiltradoEnSubasta", ReplyAction="http://tempuri.org/IServiceVentas/GetVentaCompletaFiltradoEnSubastaResponse")]
        System.Threading.Tasks.Task<COMPLETE_FLAT_UI.ServiceVentas.VentaCompleta[]> GetVentaCompletaFiltradoEnSubastaAsync(int idTipoEstado, int idTipoVenta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceVentas/GetVentaCompletaFiltradoEnCamino", ReplyAction="http://tempuri.org/IServiceVentas/GetVentaCompletaFiltradoEnCaminoResponse")]
        COMPLETE_FLAT_UI.ServiceVentas.VentaCompleta[] GetVentaCompletaFiltradoEnCamino(int idTipoEstado, int idTipoVenta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceVentas/GetVentaCompletaFiltradoEnCamino", ReplyAction="http://tempuri.org/IServiceVentas/GetVentaCompletaFiltradoEnCaminoResponse")]
        System.Threading.Tasks.Task<COMPLETE_FLAT_UI.ServiceVentas.VentaCompleta[]> GetVentaCompletaFiltradoEnCaminoAsync(int idTipoEstado, int idTipoVenta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceVentas/GetVentaCompletaFiltradoRecepcionado", ReplyAction="http://tempuri.org/IServiceVentas/GetVentaCompletaFiltradoRecepcionadoResponse")]
        COMPLETE_FLAT_UI.ServiceVentas.VentaCompleta[] GetVentaCompletaFiltradoRecepcionado(int idTipoEstado, int idTipoVenta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceVentas/GetVentaCompletaFiltradoRecepcionado", ReplyAction="http://tempuri.org/IServiceVentas/GetVentaCompletaFiltradoRecepcionadoResponse")]
        System.Threading.Tasks.Task<COMPLETE_FLAT_UI.ServiceVentas.VentaCompleta[]> GetVentaCompletaFiltradoRecepcionadoAsync(int idTipoEstado, int idTipoVenta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceVentas/GetVentaCompletaFiltradoFinalizada", ReplyAction="http://tempuri.org/IServiceVentas/GetVentaCompletaFiltradoFinalizadaResponse")]
        COMPLETE_FLAT_UI.ServiceVentas.VentaCompleta[] GetVentaCompletaFiltradoFinalizada(int idTipoEstado, int idTipoVenta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceVentas/GetVentaCompletaFiltradoFinalizada", ReplyAction="http://tempuri.org/IServiceVentas/GetVentaCompletaFiltradoFinalizadaResponse")]
        System.Threading.Tasks.Task<COMPLETE_FLAT_UI.ServiceVentas.VentaCompleta[]> GetVentaCompletaFiltradoFinalizadaAsync(int idTipoEstado, int idTipoVenta);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceVentasChannel : COMPLETE_FLAT_UI.ServiceVentas.IServiceVentas, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceVentasClient : System.ServiceModel.ClientBase<COMPLETE_FLAT_UI.ServiceVentas.IServiceVentas>, COMPLETE_FLAT_UI.ServiceVentas.IServiceVentas {
        
        public ServiceVentasClient() {
        }
        
        public ServiceVentasClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceVentasClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceVentasClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceVentasClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public COMPLETE_FLAT_UI.ServiceVentas.Ventas[] GetVentas() {
            return base.Channel.GetVentas();
        }
        
        public System.Threading.Tasks.Task<COMPLETE_FLAT_UI.ServiceVentas.Ventas[]> GetVentasAsync() {
            return base.Channel.GetVentasAsync();
        }
        
        public string InsertVenta(int fk_usuario, System.DateTime fecha, int fk_tipoVenta) {
            return base.Channel.InsertVenta(fk_usuario, fecha, fk_tipoVenta);
        }
        
        public System.Threading.Tasks.Task<string> InsertVentaAsync(int fk_usuario, System.DateTime fecha, int fk_tipoVenta) {
            return base.Channel.InsertVentaAsync(fk_usuario, fecha, fk_tipoVenta);
        }
        
        public string DeleteVenta(int id) {
            return base.Channel.DeleteVenta(id);
        }
        
        public System.Threading.Tasks.Task<string> DeleteVentaAsync(int id) {
            return base.Channel.DeleteVentaAsync(id);
        }
        
        public string UpdateVenta(int id_estado, int id_venta, char isLocal) {
            return base.Channel.UpdateVenta(id_estado, id_venta, isLocal);
        }
        
        public System.Threading.Tasks.Task<string> UpdateVentaAsync(int id_estado, int id_venta, char isLocal) {
            return base.Channel.UpdateVentaAsync(id_estado, id_venta, isLocal);
        }
        
        public COMPLETE_FLAT_UI.ServiceVentas.HistoricoEstadoVentas[] GetHistóricoEstadoVentas() {
            return base.Channel.GetHistóricoEstadoVentas();
        }
        
        public System.Threading.Tasks.Task<COMPLETE_FLAT_UI.ServiceVentas.HistoricoEstadoVentas[]> GetHistóricoEstadoVentasAsync() {
            return base.Channel.GetHistóricoEstadoVentasAsync();
        }
        
        public COMPLETE_FLAT_UI.ServiceVentas.VentaCompleta[] GetVentaCompleta(int idTipoEstado, int idTipoVenta) {
            return base.Channel.GetVentaCompleta(idTipoEstado, idTipoVenta);
        }
        
        public System.Threading.Tasks.Task<COMPLETE_FLAT_UI.ServiceVentas.VentaCompleta[]> GetVentaCompletaAsync(int idTipoEstado, int idTipoVenta) {
            return base.Channel.GetVentaCompletaAsync(idTipoEstado, idTipoVenta);
        }
        
        public COMPLETE_FLAT_UI.ServiceVentas.VentaCompleta[] GetVentaCompletaFiltradoAbierto(int idTipoEstado, int idTipoVenta) {
            return base.Channel.GetVentaCompletaFiltradoAbierto(idTipoEstado, idTipoVenta);
        }
        
        public System.Threading.Tasks.Task<COMPLETE_FLAT_UI.ServiceVentas.VentaCompleta[]> GetVentaCompletaFiltradoAbiertoAsync(int idTipoEstado, int idTipoVenta) {
            return base.Channel.GetVentaCompletaFiltradoAbiertoAsync(idTipoEstado, idTipoVenta);
        }
        
        public COMPLETE_FLAT_UI.ServiceVentas.VentaCompleta[] GetVentaCompletaFiltradoIngresada(int idTipoEstado, int idTipoVenta) {
            return base.Channel.GetVentaCompletaFiltradoIngresada(idTipoEstado, idTipoVenta);
        }
        
        public System.Threading.Tasks.Task<COMPLETE_FLAT_UI.ServiceVentas.VentaCompleta[]> GetVentaCompletaFiltradoIngresadaAsync(int idTipoEstado, int idTipoVenta) {
            return base.Channel.GetVentaCompletaFiltradoIngresadaAsync(idTipoEstado, idTipoVenta);
        }
        
        public COMPLETE_FLAT_UI.ServiceVentas.VentaCompleta[] GetVentaCompletaFiltradoEnSubasta(int idTipoEstado, int idTipoVenta) {
            return base.Channel.GetVentaCompletaFiltradoEnSubasta(idTipoEstado, idTipoVenta);
        }
        
        public System.Threading.Tasks.Task<COMPLETE_FLAT_UI.ServiceVentas.VentaCompleta[]> GetVentaCompletaFiltradoEnSubastaAsync(int idTipoEstado, int idTipoVenta) {
            return base.Channel.GetVentaCompletaFiltradoEnSubastaAsync(idTipoEstado, idTipoVenta);
        }
        
        public COMPLETE_FLAT_UI.ServiceVentas.VentaCompleta[] GetVentaCompletaFiltradoEnCamino(int idTipoEstado, int idTipoVenta) {
            return base.Channel.GetVentaCompletaFiltradoEnCamino(idTipoEstado, idTipoVenta);
        }
        
        public System.Threading.Tasks.Task<COMPLETE_FLAT_UI.ServiceVentas.VentaCompleta[]> GetVentaCompletaFiltradoEnCaminoAsync(int idTipoEstado, int idTipoVenta) {
            return base.Channel.GetVentaCompletaFiltradoEnCaminoAsync(idTipoEstado, idTipoVenta);
        }
        
        public COMPLETE_FLAT_UI.ServiceVentas.VentaCompleta[] GetVentaCompletaFiltradoRecepcionado(int idTipoEstado, int idTipoVenta) {
            return base.Channel.GetVentaCompletaFiltradoRecepcionado(idTipoEstado, idTipoVenta);
        }
        
        public System.Threading.Tasks.Task<COMPLETE_FLAT_UI.ServiceVentas.VentaCompleta[]> GetVentaCompletaFiltradoRecepcionadoAsync(int idTipoEstado, int idTipoVenta) {
            return base.Channel.GetVentaCompletaFiltradoRecepcionadoAsync(idTipoEstado, idTipoVenta);
        }
        
        public COMPLETE_FLAT_UI.ServiceVentas.VentaCompleta[] GetVentaCompletaFiltradoFinalizada(int idTipoEstado, int idTipoVenta) {
            return base.Channel.GetVentaCompletaFiltradoFinalizada(idTipoEstado, idTipoVenta);
        }
        
        public System.Threading.Tasks.Task<COMPLETE_FLAT_UI.ServiceVentas.VentaCompleta[]> GetVentaCompletaFiltradoFinalizadaAsync(int idTipoEstado, int idTipoVenta) {
            return base.Channel.GetVentaCompletaFiltradoFinalizadaAsync(idTipoEstado, idTipoVenta);
        }
    }
}
