﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SAT_Service
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Acuse", Namespace="http://schemas.datacontract.org/2004/07/Sat.Cfdi.Negocio.ConsultaCfdi.Servicio")]
    internal partial class Acuse : object
    {
        
        private string CodigoEstatusField;
        
        private string EsCancelableField;
        
        private string EstadoField;
        
        private string EstatusCancelacionField;
        
        private string ValidacionEFOSField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal string CodigoEstatus
        {
            get
            {
                return this.CodigoEstatusField;
            }
            set
            {
                this.CodigoEstatusField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal string EsCancelable
        {
            get
            {
                return this.EsCancelableField;
            }
            set
            {
                this.EsCancelableField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal string Estado
        {
            get
            {
                return this.EstadoField;
            }
            set
            {
                this.EstadoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal string EstatusCancelacion
        {
            get
            {
                return this.EstatusCancelacionField;
            }
            set
            {
                this.EstatusCancelacionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal string ValidacionEFOS
        {
            get
            {
                return this.ValidacionEFOSField;
            }
            set
            {
                this.ValidacionEFOSField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SAT_Service.IConsultaCFDIService")]
    internal interface IConsultaCFDIService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConsultaCFDIService/Consulta", ReplyAction="http://tempuri.org/IConsultaCFDIService/ConsultaResponse")]
        SAT_Service.Acuse Consulta(string expresionImpresa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConsultaCFDIService/Consulta", ReplyAction="http://tempuri.org/IConsultaCFDIService/ConsultaResponse")]
        System.Threading.Tasks.Task<SAT_Service.Acuse> ConsultaAsync(string expresionImpresa);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    internal interface IConsultaCFDIServiceChannel : SAT_Service.IConsultaCFDIService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    internal partial class ConsultaCFDIServiceClient : System.ServiceModel.ClientBase<SAT_Service.IConsultaCFDIService>, SAT_Service.IConsultaCFDIService
    {
        
        /// <summary>
        /// Implemente este método parcial para configurar el punto de conexión de servicio.
        /// </summary>
        /// <param name="serviceEndpoint">El punto de conexión para configurar</param>
        /// <param name="clientCredentials">Credenciales de cliente</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public ConsultaCFDIServiceClient() : 
                base(ConsultaCFDIServiceClient.GetDefaultBinding(), ConsultaCFDIServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IConsultaCFDIService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ConsultaCFDIServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(ConsultaCFDIServiceClient.GetBindingForEndpoint(endpointConfiguration), ConsultaCFDIServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ConsultaCFDIServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(ConsultaCFDIServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ConsultaCFDIServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(ConsultaCFDIServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ConsultaCFDIServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public SAT_Service.Acuse Consulta(string expresionImpresa)
        {
            return base.Channel.Consulta(expresionImpresa);
        }
        
        public System.Threading.Tasks.Task<SAT_Service.Acuse> ConsultaAsync(string expresionImpresa)
        {
            return base.Channel.ConsultaAsync(expresionImpresa);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IConsultaCFDIService))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IConsultaCFDIService))
            {
                return new System.ServiceModel.EndpointAddress("https://consultaqr.facturaelectronica.sat.gob.mx/ConsultaCFDIService.svc");
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return ConsultaCFDIServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IConsultaCFDIService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return ConsultaCFDIServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IConsultaCFDIService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IConsultaCFDIService,
        }
    }
}
