﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReference1
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview1.20574.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RequestModel", Namespace="http://schemas.datacontract.org/2004/07/MRS.Helper.Models")]
    public partial class RequestModel : object
    {
        
        private string AdditionalDataField;
        
        private long AutoChargeReferenceNumberField;
        
        private System.Nullable<byte> BankIdField;
        
        private string CardNumberField;
        
        private string CellNumberField;
        
        private int ChargeTypeField;
        
        private int DeviceTypeField;
        
        private long ExternalReferenceNumberField;
        
        private System.DateTime LocalDateTimeField;
        
        private string NationalCodeField;
        
        private short OperatorIdField;
        
        private string OtherNumberField;
        
        private string PasswordField;
        
        private long ReferenceNumberField;
        
        private long ReserveNumberField;
        
        private System.Nullable<long> TerminalIdField;
        
        private decimal TotalAmountField;
        
        private string UsernameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AdditionalData
        {
            get
            {
                return this.AdditionalDataField;
            }
            set
            {
                this.AdditionalDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long AutoChargeReferenceNumber
        {
            get
            {
                return this.AutoChargeReferenceNumberField;
            }
            set
            {
                this.AutoChargeReferenceNumberField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<byte> BankId
        {
            get
            {
                return this.BankIdField;
            }
            set
            {
                this.BankIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CardNumber
        {
            get
            {
                return this.CardNumberField;
            }
            set
            {
                this.CardNumberField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CellNumber
        {
            get
            {
                return this.CellNumberField;
            }
            set
            {
                this.CellNumberField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ChargeType
        {
            get
            {
                return this.ChargeTypeField;
            }
            set
            {
                this.ChargeTypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int DeviceType
        {
            get
            {
                return this.DeviceTypeField;
            }
            set
            {
                this.DeviceTypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long ExternalReferenceNumber
        {
            get
            {
                return this.ExternalReferenceNumberField;
            }
            set
            {
                this.ExternalReferenceNumberField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime LocalDateTime
        {
            get
            {
                return this.LocalDateTimeField;
            }
            set
            {
                this.LocalDateTimeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NationalCode
        {
            get
            {
                return this.NationalCodeField;
            }
            set
            {
                this.NationalCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short OperatorId
        {
            get
            {
                return this.OperatorIdField;
            }
            set
            {
                this.OperatorIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string OtherNumber
        {
            get
            {
                return this.OtherNumberField;
            }
            set
            {
                this.OtherNumberField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password
        {
            get
            {
                return this.PasswordField;
            }
            set
            {
                this.PasswordField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long ReferenceNumber
        {
            get
            {
                return this.ReferenceNumberField;
            }
            set
            {
                this.ReferenceNumberField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long ReserveNumber
        {
            get
            {
                return this.ReserveNumberField;
            }
            set
            {
                this.ReserveNumberField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<long> TerminalId
        {
            get
            {
                return this.TerminalIdField;
            }
            set
            {
                this.TerminalIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal TotalAmount
        {
            get
            {
                return this.TotalAmountField;
            }
            set
            {
                this.TotalAmountField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username
        {
            get
            {
                return this.UsernameField;
            }
            set
            {
                this.UsernameField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview1.20574.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ResponseModel", Namespace="http://schemas.datacontract.org/2004/07/MRS.Helper.Models")]
    public partial class ResponseModel : object
    {
        
        private string AdditionalDataField;
        
        private int ChargeTypeField;
        
        private string DescriptionField;
        
        private System.DateTime LocalDateTimeField;
        
        private string OperatorField;
        
        private long ReferenceNumberField;
        
        private long ReserveNumberField;
        
        private int ReturnCodeField;
        
        private string ReturnMsgField;
        
        private bool StatusField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AdditionalData
        {
            get
            {
                return this.AdditionalDataField;
            }
            set
            {
                this.AdditionalDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ChargeType
        {
            get
            {
                return this.ChargeTypeField;
            }
            set
            {
                this.ChargeTypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description
        {
            get
            {
                return this.DescriptionField;
            }
            set
            {
                this.DescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime LocalDateTime
        {
            get
            {
                return this.LocalDateTimeField;
            }
            set
            {
                this.LocalDateTimeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Operator
        {
            get
            {
                return this.OperatorField;
            }
            set
            {
                this.OperatorField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long ReferenceNumber
        {
            get
            {
                return this.ReferenceNumberField;
            }
            set
            {
                this.ReferenceNumberField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long ReserveNumber
        {
            get
            {
                return this.ReserveNumberField;
            }
            set
            {
                this.ReserveNumberField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ReturnCode
        {
            get
            {
                return this.ReturnCodeField;
            }
            set
            {
                this.ReturnCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ReturnMsg
        {
            get
            {
                return this.ReturnMsgField;
            }
            set
            {
                this.ReturnMsgField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Status
        {
            get
            {
                return this.StatusField;
            }
            set
            {
                this.StatusField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview1.20574.1")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IPackageInq")]
    public interface IPackageInq
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPackageInq/MCIPackageInquiry", ReplyAction="http://tempuri.org/IPackageInq/MCIPackageInquiryResponse")]
        System.Threading.Tasks.Task<ServiceReference1.ResponseModel> MCIPackageInquiryAsync(ServiceReference1.RequestModel req);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPackageInq/MTNPackageInquiry", ReplyAction="http://tempuri.org/IPackageInq/MTNPackageInquiryResponse")]
        System.Threading.Tasks.Task<ServiceReference1.ResponseModel> MTNPackageInquiryAsync(ServiceReference1.RequestModel req);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPackageInq/RightelPackageInquiry", ReplyAction="http://tempuri.org/IPackageInq/RightelPackageInquiryResponse")]
        System.Threading.Tasks.Task<ServiceReference1.ResponseModel> RightelPackageInquiryAsync(ServiceReference1.RequestModel req);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPackageInq/ShatelPackageInquiry", ReplyAction="http://tempuri.org/IPackageInq/ShatelPackageInquiryResponse")]
        System.Threading.Tasks.Task<ServiceReference1.ResponseModel> ShatelPackageInquiryAsync(ServiceReference1.RequestModel req);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview1.20574.1")]
    public interface IPackageInqChannel : ServiceReference1.IPackageInq, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview1.20574.1")]
    public partial class PackageInqClient : System.ServiceModel.ClientBase<ServiceReference1.IPackageInq>, ServiceReference1.IPackageInq
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public PackageInqClient() : 
                base(PackageInqClient.GetDefaultBinding(), PackageInqClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpsBinding_IPackageInq.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PackageInqClient(EndpointConfiguration endpointConfiguration) : 
                base(PackageInqClient.GetBindingForEndpoint(endpointConfiguration), PackageInqClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PackageInqClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(PackageInqClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PackageInqClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(PackageInqClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PackageInqClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.ResponseModel> MCIPackageInquiryAsync(ServiceReference1.RequestModel req)
        {
            return base.Channel.MCIPackageInquiryAsync(req);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.ResponseModel> MTNPackageInquiryAsync(ServiceReference1.RequestModel req)
        {
            return base.Channel.MTNPackageInquiryAsync(req);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.ResponseModel> RightelPackageInquiryAsync(ServiceReference1.RequestModel req)
        {
            return base.Channel.RightelPackageInquiryAsync(req);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.ResponseModel> ShatelPackageInquiryAsync(ServiceReference1.RequestModel req)
        {
            return base.Channel.ShatelPackageInquiryAsync(req);
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpsBinding_IPackageInq))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpsBinding_IPackageInq))
            {
                return new System.ServiceModel.EndpointAddress("https://echarge.mobtakerancell.com/TopUp/PackageInq.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return PackageInqClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpsBinding_IPackageInq);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return PackageInqClient.GetEndpointAddress(EndpointConfiguration.BasicHttpsBinding_IPackageInq);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpsBinding_IPackageInq,
        }
    }
}
