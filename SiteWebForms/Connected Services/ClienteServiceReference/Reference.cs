﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SiteWebForms.ClienteServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Cliente", Namespace="http://schemas.datacontract.org/2004/07/ProjetoWCF")]
    [System.SerializableAttribute()]
    public partial class Cliente : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ClienteIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CpfField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> DataExpedicaoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DataNascimentoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EnderecoIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SiteWebForms.ClienteServiceReference.Endereco EnderecosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EstadoCivilField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OrgaoExpedicaoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RgField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SexoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UfExpedicaoField;
        
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
        public int ClienteId {
            get {
                return this.ClienteIdField;
            }
            set {
                if ((this.ClienteIdField.Equals(value) != true)) {
                    this.ClienteIdField = value;
                    this.RaisePropertyChanged("ClienteId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Cpf {
            get {
                return this.CpfField;
            }
            set {
                if ((object.ReferenceEquals(this.CpfField, value) != true)) {
                    this.CpfField = value;
                    this.RaisePropertyChanged("Cpf");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> DataExpedicao {
            get {
                return this.DataExpedicaoField;
            }
            set {
                if ((this.DataExpedicaoField.Equals(value) != true)) {
                    this.DataExpedicaoField = value;
                    this.RaisePropertyChanged("DataExpedicao");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DataNascimento {
            get {
                return this.DataNascimentoField;
            }
            set {
                if ((this.DataNascimentoField.Equals(value) != true)) {
                    this.DataNascimentoField = value;
                    this.RaisePropertyChanged("DataNascimento");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int EnderecoId {
            get {
                return this.EnderecoIdField;
            }
            set {
                if ((this.EnderecoIdField.Equals(value) != true)) {
                    this.EnderecoIdField = value;
                    this.RaisePropertyChanged("EnderecoId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SiteWebForms.ClienteServiceReference.Endereco Enderecos {
            get {
                return this.EnderecosField;
            }
            set {
                if ((object.ReferenceEquals(this.EnderecosField, value) != true)) {
                    this.EnderecosField = value;
                    this.RaisePropertyChanged("Enderecos");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EstadoCivil {
            get {
                return this.EstadoCivilField;
            }
            set {
                if ((object.ReferenceEquals(this.EstadoCivilField, value) != true)) {
                    this.EstadoCivilField = value;
                    this.RaisePropertyChanged("EstadoCivil");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nome {
            get {
                return this.NomeField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeField, value) != true)) {
                    this.NomeField = value;
                    this.RaisePropertyChanged("Nome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string OrgaoExpedicao {
            get {
                return this.OrgaoExpedicaoField;
            }
            set {
                if ((object.ReferenceEquals(this.OrgaoExpedicaoField, value) != true)) {
                    this.OrgaoExpedicaoField = value;
                    this.RaisePropertyChanged("OrgaoExpedicao");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Rg {
            get {
                return this.RgField;
            }
            set {
                if ((object.ReferenceEquals(this.RgField, value) != true)) {
                    this.RgField = value;
                    this.RaisePropertyChanged("Rg");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Sexo {
            get {
                return this.SexoField;
            }
            set {
                if ((object.ReferenceEquals(this.SexoField, value) != true)) {
                    this.SexoField = value;
                    this.RaisePropertyChanged("Sexo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UfExpedicao {
            get {
                return this.UfExpedicaoField;
            }
            set {
                if ((object.ReferenceEquals(this.UfExpedicaoField, value) != true)) {
                    this.UfExpedicaoField = value;
                    this.RaisePropertyChanged("UfExpedicao");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Endereco", Namespace="http://schemas.datacontract.org/2004/07/ProjetoWCF")]
    [System.SerializableAttribute()]
    public partial class Endereco : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BairroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CepField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CidadeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SiteWebForms.ClienteServiceReference.Cliente[] ClientesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ComplementoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EnderecoIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LogradouroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NumeroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UfField;
        
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
        public string Bairro {
            get {
                return this.BairroField;
            }
            set {
                if ((object.ReferenceEquals(this.BairroField, value) != true)) {
                    this.BairroField = value;
                    this.RaisePropertyChanged("Bairro");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Cep {
            get {
                return this.CepField;
            }
            set {
                if ((object.ReferenceEquals(this.CepField, value) != true)) {
                    this.CepField = value;
                    this.RaisePropertyChanged("Cep");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Cidade {
            get {
                return this.CidadeField;
            }
            set {
                if ((object.ReferenceEquals(this.CidadeField, value) != true)) {
                    this.CidadeField = value;
                    this.RaisePropertyChanged("Cidade");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SiteWebForms.ClienteServiceReference.Cliente[] Clientes {
            get {
                return this.ClientesField;
            }
            set {
                if ((object.ReferenceEquals(this.ClientesField, value) != true)) {
                    this.ClientesField = value;
                    this.RaisePropertyChanged("Clientes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Complemento {
            get {
                return this.ComplementoField;
            }
            set {
                if ((object.ReferenceEquals(this.ComplementoField, value) != true)) {
                    this.ComplementoField = value;
                    this.RaisePropertyChanged("Complemento");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int EnderecoId {
            get {
                return this.EnderecoIdField;
            }
            set {
                if ((this.EnderecoIdField.Equals(value) != true)) {
                    this.EnderecoIdField = value;
                    this.RaisePropertyChanged("EnderecoId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Logradouro {
            get {
                return this.LogradouroField;
            }
            set {
                if ((object.ReferenceEquals(this.LogradouroField, value) != true)) {
                    this.LogradouroField = value;
                    this.RaisePropertyChanged("Logradouro");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Numero {
            get {
                return this.NumeroField;
            }
            set {
                if ((object.ReferenceEquals(this.NumeroField, value) != true)) {
                    this.NumeroField = value;
                    this.RaisePropertyChanged("Numero");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Uf {
            get {
                return this.UfField;
            }
            set {
                if ((object.ReferenceEquals(this.UfField, value) != true)) {
                    this.UfField = value;
                    this.RaisePropertyChanged("Uf");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ClienteServiceReference.IClienteService")]
    public interface IClienteService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/FindAll", ReplyAction="http://tempuri.org/IClienteService/FindAllResponse")]
        SiteWebForms.ClienteServiceReference.Cliente[] FindAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/FindAll", ReplyAction="http://tempuri.org/IClienteService/FindAllResponse")]
        System.Threading.Tasks.Task<SiteWebForms.ClienteServiceReference.Cliente[]> FindAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/Find", ReplyAction="http://tempuri.org/IClienteService/FindResponse")]
        SiteWebForms.ClienteServiceReference.Cliente Find(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/Find", ReplyAction="http://tempuri.org/IClienteService/FindResponse")]
        System.Threading.Tasks.Task<SiteWebForms.ClienteServiceReference.Cliente> FindAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/New", ReplyAction="http://tempuri.org/IClienteService/NewResponse")]
        SiteWebForms.ClienteServiceReference.Cliente New(SiteWebForms.ClienteServiceReference.Cliente cliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/New", ReplyAction="http://tempuri.org/IClienteService/NewResponse")]
        System.Threading.Tasks.Task<SiteWebForms.ClienteServiceReference.Cliente> NewAsync(SiteWebForms.ClienteServiceReference.Cliente cliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/Update", ReplyAction="http://tempuri.org/IClienteService/UpdateResponse")]
        SiteWebForms.ClienteServiceReference.Cliente Update(SiteWebForms.ClienteServiceReference.Cliente cliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/Update", ReplyAction="http://tempuri.org/IClienteService/UpdateResponse")]
        System.Threading.Tasks.Task<SiteWebForms.ClienteServiceReference.Cliente> UpdateAsync(SiteWebForms.ClienteServiceReference.Cliente cliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/DeleteById", ReplyAction="http://tempuri.org/IClienteService/DeleteByIdResponse")]
        SiteWebForms.ClienteServiceReference.Cliente DeleteById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/DeleteById", ReplyAction="http://tempuri.org/IClienteService/DeleteByIdResponse")]
        System.Threading.Tasks.Task<SiteWebForms.ClienteServiceReference.Cliente> DeleteByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/Delete", ReplyAction="http://tempuri.org/IClienteService/DeleteResponse")]
        SiteWebForms.ClienteServiceReference.Cliente Delete(SiteWebForms.ClienteServiceReference.Cliente cliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/Delete", ReplyAction="http://tempuri.org/IClienteService/DeleteResponse")]
        System.Threading.Tasks.Task<SiteWebForms.ClienteServiceReference.Cliente> DeleteAsync(SiteWebForms.ClienteServiceReference.Cliente cliente);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IClienteServiceChannel : SiteWebForms.ClienteServiceReference.IClienteService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ClienteServiceClient : System.ServiceModel.ClientBase<SiteWebForms.ClienteServiceReference.IClienteService>, SiteWebForms.ClienteServiceReference.IClienteService {
        
        public ClienteServiceClient() {
        }
        
        public ClienteServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ClienteServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClienteServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClienteServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SiteWebForms.ClienteServiceReference.Cliente[] FindAll() {
            return base.Channel.FindAll();
        }
        
        public System.Threading.Tasks.Task<SiteWebForms.ClienteServiceReference.Cliente[]> FindAllAsync() {
            return base.Channel.FindAllAsync();
        }
        
        public SiteWebForms.ClienteServiceReference.Cliente Find(int id) {
            return base.Channel.Find(id);
        }
        
        public System.Threading.Tasks.Task<SiteWebForms.ClienteServiceReference.Cliente> FindAsync(int id) {
            return base.Channel.FindAsync(id);
        }
        
        public SiteWebForms.ClienteServiceReference.Cliente New(SiteWebForms.ClienteServiceReference.Cliente cliente) {
            return base.Channel.New(cliente);
        }
        
        public System.Threading.Tasks.Task<SiteWebForms.ClienteServiceReference.Cliente> NewAsync(SiteWebForms.ClienteServiceReference.Cliente cliente) {
            return base.Channel.NewAsync(cliente);
        }
        
        public SiteWebForms.ClienteServiceReference.Cliente Update(SiteWebForms.ClienteServiceReference.Cliente cliente) {
            return base.Channel.Update(cliente);
        }
        
        public System.Threading.Tasks.Task<SiteWebForms.ClienteServiceReference.Cliente> UpdateAsync(SiteWebForms.ClienteServiceReference.Cliente cliente) {
            return base.Channel.UpdateAsync(cliente);
        }
        
        public SiteWebForms.ClienteServiceReference.Cliente DeleteById(int id) {
            return base.Channel.DeleteById(id);
        }
        
        public System.Threading.Tasks.Task<SiteWebForms.ClienteServiceReference.Cliente> DeleteByIdAsync(int id) {
            return base.Channel.DeleteByIdAsync(id);
        }
        
        public SiteWebForms.ClienteServiceReference.Cliente Delete(SiteWebForms.ClienteServiceReference.Cliente cliente) {
            return base.Channel.Delete(cliente);
        }
        
        public System.Threading.Tasks.Task<SiteWebForms.ClienteServiceReference.Cliente> DeleteAsync(SiteWebForms.ClienteServiceReference.Cliente cliente) {
            return base.Channel.DeleteAsync(cliente);
        }
    }
}