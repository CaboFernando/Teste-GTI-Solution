//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjetoWCF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cliente
    {
        public int ClienteId { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Rg { get; set; }
        public Nullable<System.DateTime> DataExpedicao { get; set; }
        public string OrgaoExpedicao { get; set; }
        public string UfExpedicao { get; set; }
        public System.DateTime DataNascimento { get; set; }
        public string Sexo { get; set; }
        public int EnderecoId { get; set; }
        public string EstadoCivil { get; set; }
    
        public virtual Endereco Enderecos { get; set; }
    }
}