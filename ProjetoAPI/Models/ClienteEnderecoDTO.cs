using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoAPI.Models
{
    public class ClienteEnderecoDTO
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

        public int EnderecoId { get; set; }
        public string Logradouro { get; set; }
        public string Cep { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
    }
}