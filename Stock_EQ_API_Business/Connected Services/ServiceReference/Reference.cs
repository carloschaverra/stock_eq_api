//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReference
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IClientes")]
    public interface IClientes
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientes/CrearCLientePOS", ReplyAction="http://tempuri.org/IClientes/CrearCLientePOSResponse")]
        System.Threading.Tasks.Task<int> CrearCLientePOSAsync(int tipoPersona, string tipoDocumento, string documento, string nombres, string apellido1, string apellido2, string razonSocial, string direccion, string telefono, string pais, string departamento, string ciudad, string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientes/CrearCLientePOS_N", ReplyAction="http://tempuri.org/IClientes/CrearCLientePOS_NResponse")]
        System.Threading.Tasks.Task<int> CrearCLientePOS_NAsync(int tipoPersona, string tipoDocumento, string documento, string nombres, string apellido1, string apellido2, string razonSocial, string direccion, string telefono, string pais, string departamento, string ciudad, string email);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface IClientesChannel : ServiceReference.IClientes, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class ClientesClient : System.ServiceModel.ClientBase<ServiceReference.IClientes>, ServiceReference.IClientes
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public ClientesClient() : 
                base(ClientesClient.GetDefaultBinding(), ClientesClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IClientes.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ClientesClient(EndpointConfiguration endpointConfiguration) : 
                base(ClientesClient.GetBindingForEndpoint(endpointConfiguration), ClientesClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ClientesClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(ClientesClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ClientesClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(ClientesClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ClientesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<int> CrearCLientePOSAsync(int tipoPersona, string tipoDocumento, string documento, string nombres, string apellido1, string apellido2, string razonSocial, string direccion, string telefono, string pais, string departamento, string ciudad, string email)
        {
            return base.Channel.CrearCLientePOSAsync(tipoPersona, tipoDocumento, documento, nombres, apellido1, apellido2, razonSocial, direccion, telefono, pais, departamento, ciudad, email);
        }
        
        public System.Threading.Tasks.Task<int> CrearCLientePOS_NAsync(int tipoPersona, string tipoDocumento, string documento, string nombres, string apellido1, string apellido2, string razonSocial, string direccion, string telefono, string pais, string departamento, string ciudad, string email)
        {
            return base.Channel.CrearCLientePOS_NAsync(tipoPersona, tipoDocumento, documento, nombres, apellido1, apellido2, razonSocial, direccion, telefono, pais, departamento, ciudad, email);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IClientes))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IClientes))
            {
                return new System.ServiceModel.EndpointAddress("http://172.16.100.45/SiesaLabroides/CrearClientePos.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return ClientesClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IClientes);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return ClientesClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IClientes);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IClientes,
        }
    }
}
