using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiteMVC.Models
{
    public class ClienteViewModel
    {
        public int ClienteId { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Rg { get; set; }
        public DateTime? DataExpedicao { get; set; }
        public string OrgaoExpedicao { get; set; }
        public string UfExpedicao { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set; }
        public string EstadoCivil { get; set; }
        public virtual EnderecoViewModel Endereco { get; set; }
        public virtual int EnderecoId { get; set; }
    }
}