﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Generacion_Hash.ServiceBata {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceBata.ws_bataSoap")]
    public interface ws_bataSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento _archivo_xml del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ws_envio_xml_desarrollo", ReplyAction="*")]
        Generacion_Hash.ServiceBata.ws_envio_xml_desarrolloResponse ws_envio_xml_desarrollo(Generacion_Hash.ServiceBata.ws_envio_xml_desarrolloRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento _archivo_xml del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ws_envio_xml_tropi", ReplyAction="*")]
        Generacion_Hash.ServiceBata.ws_envio_xml_tropiResponse ws_envio_xml_tropi(Generacion_Hash.ServiceBata.ws_envio_xml_tropiRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento _archivo_xml del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ws_envio_xml", ReplyAction="*")]
        Generacion_Hash.ServiceBata.ws_envio_xmlResponse ws_envio_xml(Generacion_Hash.ServiceBata.ws_envio_xmlRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento _archivo del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ws_control_error", ReplyAction="*")]
        Generacion_Hash.ServiceBata.ws_control_errorResponse ws_control_error(Generacion_Hash.ServiceBata.ws_control_errorRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ws_envio_xml_desarrolloRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ws_envio_xml_desarrollo", Namespace="http://tempuri.org/", Order=0)]
        public Generacion_Hash.ServiceBata.ws_envio_xml_desarrolloRequestBody Body;
        
        public ws_envio_xml_desarrolloRequest() {
        }
        
        public ws_envio_xml_desarrolloRequest(Generacion_Hash.ServiceBata.ws_envio_xml_desarrolloRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ws_envio_xml_desarrolloRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public byte[] _archivo_xml;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string _name;
        
        public ws_envio_xml_desarrolloRequestBody() {
        }
        
        public ws_envio_xml_desarrolloRequestBody(byte[] _archivo_xml, string _name) {
            this._archivo_xml = _archivo_xml;
            this._name = _name;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ws_envio_xml_desarrolloResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ws_envio_xml_desarrolloResponse", Namespace="http://tempuri.org/", Order=0)]
        public Generacion_Hash.ServiceBata.ws_envio_xml_desarrolloResponseBody Body;
        
        public ws_envio_xml_desarrolloResponse() {
        }
        
        public ws_envio_xml_desarrolloResponse(Generacion_Hash.ServiceBata.ws_envio_xml_desarrolloResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ws_envio_xml_desarrolloResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string ws_envio_xml_desarrolloResult;
        
        public ws_envio_xml_desarrolloResponseBody() {
        }
        
        public ws_envio_xml_desarrolloResponseBody(string ws_envio_xml_desarrolloResult) {
            this.ws_envio_xml_desarrolloResult = ws_envio_xml_desarrolloResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ws_envio_xml_tropiRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ws_envio_xml_tropi", Namespace="http://tempuri.org/", Order=0)]
        public Generacion_Hash.ServiceBata.ws_envio_xml_tropiRequestBody Body;
        
        public ws_envio_xml_tropiRequest() {
        }
        
        public ws_envio_xml_tropiRequest(Generacion_Hash.ServiceBata.ws_envio_xml_tropiRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ws_envio_xml_tropiRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public byte[] _archivo_xml;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string _name;
        
        public ws_envio_xml_tropiRequestBody() {
        }
        
        public ws_envio_xml_tropiRequestBody(byte[] _archivo_xml, string _name) {
            this._archivo_xml = _archivo_xml;
            this._name = _name;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ws_envio_xml_tropiResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ws_envio_xml_tropiResponse", Namespace="http://tempuri.org/", Order=0)]
        public Generacion_Hash.ServiceBata.ws_envio_xml_tropiResponseBody Body;
        
        public ws_envio_xml_tropiResponse() {
        }
        
        public ws_envio_xml_tropiResponse(Generacion_Hash.ServiceBata.ws_envio_xml_tropiResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ws_envio_xml_tropiResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string ws_envio_xml_tropiResult;
        
        public ws_envio_xml_tropiResponseBody() {
        }
        
        public ws_envio_xml_tropiResponseBody(string ws_envio_xml_tropiResult) {
            this.ws_envio_xml_tropiResult = ws_envio_xml_tropiResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ws_envio_xmlRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ws_envio_xml", Namespace="http://tempuri.org/", Order=0)]
        public Generacion_Hash.ServiceBata.ws_envio_xmlRequestBody Body;
        
        public ws_envio_xmlRequest() {
        }
        
        public ws_envio_xmlRequest(Generacion_Hash.ServiceBata.ws_envio_xmlRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ws_envio_xmlRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public byte[] _archivo_xml;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string _name;
        
        public ws_envio_xmlRequestBody() {
        }
        
        public ws_envio_xmlRequestBody(byte[] _archivo_xml, string _name) {
            this._archivo_xml = _archivo_xml;
            this._name = _name;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ws_envio_xmlResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ws_envio_xmlResponse", Namespace="http://tempuri.org/", Order=0)]
        public Generacion_Hash.ServiceBata.ws_envio_xmlResponseBody Body;
        
        public ws_envio_xmlResponse() {
        }
        
        public ws_envio_xmlResponse(Generacion_Hash.ServiceBata.ws_envio_xmlResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ws_envio_xmlResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string ws_envio_xmlResult;
        
        public ws_envio_xmlResponseBody() {
        }
        
        public ws_envio_xmlResponseBody(string ws_envio_xmlResult) {
            this.ws_envio_xmlResult = ws_envio_xmlResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ws_control_errorRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ws_control_error", Namespace="http://tempuri.org/", Order=0)]
        public Generacion_Hash.ServiceBata.ws_control_errorRequestBody Body;
        
        public ws_control_errorRequest() {
        }
        
        public ws_control_errorRequest(Generacion_Hash.ServiceBata.ws_control_errorRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ws_control_errorRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public byte[] _archivo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string _cod_tda;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string _nom_archivo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string _error;
        
        public ws_control_errorRequestBody() {
        }
        
        public ws_control_errorRequestBody(byte[] _archivo, string _cod_tda, string _nom_archivo, string _error) {
            this._archivo = _archivo;
            this._cod_tda = _cod_tda;
            this._nom_archivo = _nom_archivo;
            this._error = _error;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ws_control_errorResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ws_control_errorResponse", Namespace="http://tempuri.org/", Order=0)]
        public Generacion_Hash.ServiceBata.ws_control_errorResponseBody Body;
        
        public ws_control_errorResponse() {
        }
        
        public ws_control_errorResponse(Generacion_Hash.ServiceBata.ws_control_errorResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ws_control_errorResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string ws_control_errorResult;
        
        public ws_control_errorResponseBody() {
        }
        
        public ws_control_errorResponseBody(string ws_control_errorResult) {
            this.ws_control_errorResult = ws_control_errorResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ws_bataSoapChannel : Generacion_Hash.ServiceBata.ws_bataSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ws_bataSoapClient : System.ServiceModel.ClientBase<Generacion_Hash.ServiceBata.ws_bataSoap>, Generacion_Hash.ServiceBata.ws_bataSoap {
        
        public ws_bataSoapClient() {
        }
        
        public ws_bataSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ws_bataSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ws_bataSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ws_bataSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Generacion_Hash.ServiceBata.ws_envio_xml_desarrolloResponse Generacion_Hash.ServiceBata.ws_bataSoap.ws_envio_xml_desarrollo(Generacion_Hash.ServiceBata.ws_envio_xml_desarrolloRequest request) {
            return base.Channel.ws_envio_xml_desarrollo(request);
        }
        
        public string ws_envio_xml_desarrollo(byte[] _archivo_xml, string _name) {
            Generacion_Hash.ServiceBata.ws_envio_xml_desarrolloRequest inValue = new Generacion_Hash.ServiceBata.ws_envio_xml_desarrolloRequest();
            inValue.Body = new Generacion_Hash.ServiceBata.ws_envio_xml_desarrolloRequestBody();
            inValue.Body._archivo_xml = _archivo_xml;
            inValue.Body._name = _name;
            Generacion_Hash.ServiceBata.ws_envio_xml_desarrolloResponse retVal = ((Generacion_Hash.ServiceBata.ws_bataSoap)(this)).ws_envio_xml_desarrollo(inValue);
            return retVal.Body.ws_envio_xml_desarrolloResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Generacion_Hash.ServiceBata.ws_envio_xml_tropiResponse Generacion_Hash.ServiceBata.ws_bataSoap.ws_envio_xml_tropi(Generacion_Hash.ServiceBata.ws_envio_xml_tropiRequest request) {
            return base.Channel.ws_envio_xml_tropi(request);
        }
        
        public string ws_envio_xml_tropi(byte[] _archivo_xml, string _name) {
            Generacion_Hash.ServiceBata.ws_envio_xml_tropiRequest inValue = new Generacion_Hash.ServiceBata.ws_envio_xml_tropiRequest();
            inValue.Body = new Generacion_Hash.ServiceBata.ws_envio_xml_tropiRequestBody();
            inValue.Body._archivo_xml = _archivo_xml;
            inValue.Body._name = _name;
            Generacion_Hash.ServiceBata.ws_envio_xml_tropiResponse retVal = ((Generacion_Hash.ServiceBata.ws_bataSoap)(this)).ws_envio_xml_tropi(inValue);
            return retVal.Body.ws_envio_xml_tropiResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Generacion_Hash.ServiceBata.ws_envio_xmlResponse Generacion_Hash.ServiceBata.ws_bataSoap.ws_envio_xml(Generacion_Hash.ServiceBata.ws_envio_xmlRequest request) {
            return base.Channel.ws_envio_xml(request);
        }
        
        public string ws_envio_xml(byte[] _archivo_xml, string _name) {
            Generacion_Hash.ServiceBata.ws_envio_xmlRequest inValue = new Generacion_Hash.ServiceBata.ws_envio_xmlRequest();
            inValue.Body = new Generacion_Hash.ServiceBata.ws_envio_xmlRequestBody();
            inValue.Body._archivo_xml = _archivo_xml;
            inValue.Body._name = _name;
            Generacion_Hash.ServiceBata.ws_envio_xmlResponse retVal = ((Generacion_Hash.ServiceBata.ws_bataSoap)(this)).ws_envio_xml(inValue);
            return retVal.Body.ws_envio_xmlResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Generacion_Hash.ServiceBata.ws_control_errorResponse Generacion_Hash.ServiceBata.ws_bataSoap.ws_control_error(Generacion_Hash.ServiceBata.ws_control_errorRequest request) {
            return base.Channel.ws_control_error(request);
        }
        
        public string ws_control_error(byte[] _archivo, string _cod_tda, string _nom_archivo, string _error) {
            Generacion_Hash.ServiceBata.ws_control_errorRequest inValue = new Generacion_Hash.ServiceBata.ws_control_errorRequest();
            inValue.Body = new Generacion_Hash.ServiceBata.ws_control_errorRequestBody();
            inValue.Body._archivo = _archivo;
            inValue.Body._cod_tda = _cod_tda;
            inValue.Body._nom_archivo = _nom_archivo;
            inValue.Body._error = _error;
            Generacion_Hash.ServiceBata.ws_control_errorResponse retVal = ((Generacion_Hash.ServiceBata.ws_bataSoap)(this)).ws_control_error(inValue);
            return retVal.Body.ws_control_errorResult;
        }
    }
}
