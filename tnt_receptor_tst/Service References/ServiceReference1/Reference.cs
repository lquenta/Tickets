﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.18408
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace tnt_receptor_tst.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="WsTransaccion", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class WsTransaccion : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int CodigoEmpresaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodigoRecaudacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodigoProductoField;
        
        private int NumeroPagoField;
        
        private int FechaField;
        
        private int SecuencialField;
        
        private int HoraField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OrigenTransaccionField;
        
        private int PaisField;
        
        private int DepartamentoField;
        
        private int CiudadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EntidadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AgenciaField;
        
        private int OperadorField;
        
        private double MontoField;
        
        private int LoteDosificacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NroRentaReciboField;
        
        private double MontoCreditoFiscalField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodigoAutorizacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodigoControlField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NitFacturarField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreFacturarField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TransaccionField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int CodigoEmpresa {
            get {
                return this.CodigoEmpresaField;
            }
            set {
                if ((this.CodigoEmpresaField.Equals(value) != true)) {
                    this.CodigoEmpresaField = value;
                    this.RaisePropertyChanged("CodigoEmpresa");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string CodigoRecaudacion {
            get {
                return this.CodigoRecaudacionField;
            }
            set {
                if ((object.ReferenceEquals(this.CodigoRecaudacionField, value) != true)) {
                    this.CodigoRecaudacionField = value;
                    this.RaisePropertyChanged("CodigoRecaudacion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string CodigoProducto {
            get {
                return this.CodigoProductoField;
            }
            set {
                if ((object.ReferenceEquals(this.CodigoProductoField, value) != true)) {
                    this.CodigoProductoField = value;
                    this.RaisePropertyChanged("CodigoProducto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public int NumeroPago {
            get {
                return this.NumeroPagoField;
            }
            set {
                if ((this.NumeroPagoField.Equals(value) != true)) {
                    this.NumeroPagoField = value;
                    this.RaisePropertyChanged("NumeroPago");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public int Fecha {
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
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=5)]
        public int Secuencial {
            get {
                return this.SecuencialField;
            }
            set {
                if ((this.SecuencialField.Equals(value) != true)) {
                    this.SecuencialField = value;
                    this.RaisePropertyChanged("Secuencial");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=6)]
        public int Hora {
            get {
                return this.HoraField;
            }
            set {
                if ((this.HoraField.Equals(value) != true)) {
                    this.HoraField = value;
                    this.RaisePropertyChanged("Hora");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string OrigenTransaccion {
            get {
                return this.OrigenTransaccionField;
            }
            set {
                if ((object.ReferenceEquals(this.OrigenTransaccionField, value) != true)) {
                    this.OrigenTransaccionField = value;
                    this.RaisePropertyChanged("OrigenTransaccion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=8)]
        public int Pais {
            get {
                return this.PaisField;
            }
            set {
                if ((this.PaisField.Equals(value) != true)) {
                    this.PaisField = value;
                    this.RaisePropertyChanged("Pais");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=9)]
        public int Departamento {
            get {
                return this.DepartamentoField;
            }
            set {
                if ((this.DepartamentoField.Equals(value) != true)) {
                    this.DepartamentoField = value;
                    this.RaisePropertyChanged("Departamento");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=10)]
        public int Ciudad {
            get {
                return this.CiudadField;
            }
            set {
                if ((this.CiudadField.Equals(value) != true)) {
                    this.CiudadField = value;
                    this.RaisePropertyChanged("Ciudad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=11)]
        public string Entidad {
            get {
                return this.EntidadField;
            }
            set {
                if ((object.ReferenceEquals(this.EntidadField, value) != true)) {
                    this.EntidadField = value;
                    this.RaisePropertyChanged("Entidad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=12)]
        public string Agencia {
            get {
                return this.AgenciaField;
            }
            set {
                if ((object.ReferenceEquals(this.AgenciaField, value) != true)) {
                    this.AgenciaField = value;
                    this.RaisePropertyChanged("Agencia");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=13)]
        public int Operador {
            get {
                return this.OperadorField;
            }
            set {
                if ((this.OperadorField.Equals(value) != true)) {
                    this.OperadorField = value;
                    this.RaisePropertyChanged("Operador");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=14)]
        public double Monto {
            get {
                return this.MontoField;
            }
            set {
                if ((this.MontoField.Equals(value) != true)) {
                    this.MontoField = value;
                    this.RaisePropertyChanged("Monto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=15)]
        public int LoteDosificacion {
            get {
                return this.LoteDosificacionField;
            }
            set {
                if ((this.LoteDosificacionField.Equals(value) != true)) {
                    this.LoteDosificacionField = value;
                    this.RaisePropertyChanged("LoteDosificacion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=16)]
        public string NroRentaRecibo {
            get {
                return this.NroRentaReciboField;
            }
            set {
                if ((object.ReferenceEquals(this.NroRentaReciboField, value) != true)) {
                    this.NroRentaReciboField = value;
                    this.RaisePropertyChanged("NroRentaRecibo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=17)]
        public double MontoCreditoFiscal {
            get {
                return this.MontoCreditoFiscalField;
            }
            set {
                if ((this.MontoCreditoFiscalField.Equals(value) != true)) {
                    this.MontoCreditoFiscalField = value;
                    this.RaisePropertyChanged("MontoCreditoFiscal");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=18)]
        public string CodigoAutorizacion {
            get {
                return this.CodigoAutorizacionField;
            }
            set {
                if ((object.ReferenceEquals(this.CodigoAutorizacionField, value) != true)) {
                    this.CodigoAutorizacionField = value;
                    this.RaisePropertyChanged("CodigoAutorizacion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=19)]
        public string CodigoControl {
            get {
                return this.CodigoControlField;
            }
            set {
                if ((object.ReferenceEquals(this.CodigoControlField, value) != true)) {
                    this.CodigoControlField = value;
                    this.RaisePropertyChanged("CodigoControl");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=20)]
        public string NitFacturar {
            get {
                return this.NitFacturarField;
            }
            set {
                if ((object.ReferenceEquals(this.NitFacturarField, value) != true)) {
                    this.NitFacturarField = value;
                    this.RaisePropertyChanged("NitFacturar");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=21)]
        public string NombreFacturar {
            get {
                return this.NombreFacturarField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreFacturarField, value) != true)) {
                    this.NombreFacturarField = value;
                    this.RaisePropertyChanged("NombreFacturar");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=22)]
        public string Transaccion {
            get {
                return this.TransaccionField;
            }
            set {
                if ((object.ReferenceEquals(this.TransaccionField, value) != true)) {
                    this.TransaccionField = value;
                    this.RaisePropertyChanged("Transaccion");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="RespTransaccion", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class RespTransaccion : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int CodErrorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescripcionField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int CodError {
            get {
                return this.CodErrorField;
            }
            set {
                if ((this.CodErrorField.Equals(value) != true)) {
                    this.CodErrorField = value;
                    this.RaisePropertyChanged("CodError");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Descripcion {
            get {
                return this.DescripcionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescripcionField, value) != true)) {
                    this.DescripcionField = value;
                    this.RaisePropertyChanged("Descripcion");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ws_tnt_receptorSoap")]
    public interface ws_tnt_receptorSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento datos del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/datosTransaccion", ReplyAction="*")]
        tnt_receptor_tst.ServiceReference1.datosTransaccionResponse datosTransaccion(tnt_receptor_tst.ServiceReference1.datosTransaccionRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class datosTransaccionRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="datosTransaccion", Namespace="http://tempuri.org/", Order=0)]
        public tnt_receptor_tst.ServiceReference1.datosTransaccionRequestBody Body;
        
        public datosTransaccionRequest() {
        }
        
        public datosTransaccionRequest(tnt_receptor_tst.ServiceReference1.datosTransaccionRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class datosTransaccionRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public tnt_receptor_tst.ServiceReference1.WsTransaccion datos;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string user;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string password;
        
        public datosTransaccionRequestBody() {
        }
        
        public datosTransaccionRequestBody(tnt_receptor_tst.ServiceReference1.WsTransaccion datos, string user, string password) {
            this.datos = datos;
            this.user = user;
            this.password = password;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class datosTransaccionResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="datosTransaccionResponse", Namespace="http://tempuri.org/", Order=0)]
        public tnt_receptor_tst.ServiceReference1.datosTransaccionResponseBody Body;
        
        public datosTransaccionResponse() {
        }
        
        public datosTransaccionResponse(tnt_receptor_tst.ServiceReference1.datosTransaccionResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class datosTransaccionResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public tnt_receptor_tst.ServiceReference1.RespTransaccion datosTransaccionResult;
        
        public datosTransaccionResponseBody() {
        }
        
        public datosTransaccionResponseBody(tnt_receptor_tst.ServiceReference1.RespTransaccion datosTransaccionResult) {
            this.datosTransaccionResult = datosTransaccionResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ws_tnt_receptorSoapChannel : tnt_receptor_tst.ServiceReference1.ws_tnt_receptorSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ws_tnt_receptorSoapClient : System.ServiceModel.ClientBase<tnt_receptor_tst.ServiceReference1.ws_tnt_receptorSoap>, tnt_receptor_tst.ServiceReference1.ws_tnt_receptorSoap {
        
        public ws_tnt_receptorSoapClient() {
        }
        
        public ws_tnt_receptorSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ws_tnt_receptorSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ws_tnt_receptorSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ws_tnt_receptorSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        tnt_receptor_tst.ServiceReference1.datosTransaccionResponse tnt_receptor_tst.ServiceReference1.ws_tnt_receptorSoap.datosTransaccion(tnt_receptor_tst.ServiceReference1.datosTransaccionRequest request) {
            return base.Channel.datosTransaccion(request);
        }
        
        public tnt_receptor_tst.ServiceReference1.RespTransaccion datosTransaccion(tnt_receptor_tst.ServiceReference1.WsTransaccion datos, string user, string password) {
            tnt_receptor_tst.ServiceReference1.datosTransaccionRequest inValue = new tnt_receptor_tst.ServiceReference1.datosTransaccionRequest();
            inValue.Body = new tnt_receptor_tst.ServiceReference1.datosTransaccionRequestBody();
            inValue.Body.datos = datos;
            inValue.Body.user = user;
            inValue.Body.password = password;
            tnt_receptor_tst.ServiceReference1.datosTransaccionResponse retVal = ((tnt_receptor_tst.ServiceReference1.ws_tnt_receptorSoap)(this)).datosTransaccion(inValue);
            return retVal.Body.datosTransaccionResult;
        }
    }
}
