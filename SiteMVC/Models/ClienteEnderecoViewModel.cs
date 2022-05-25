using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SiteMVC.Models
{
    public class ClienteEnderecoViewModel
    {
        public int ClienteId { get; set; }

        [StringLength(maximumLength: 14)]
        [Required(ErrorMessage = "O CPF é um campo obrigatório")]
        [RegularExpression(@"(^\d{3}\.\d{3}\.\d{3}\-\d{2}$)", ErrorMessage = "O CPF informado não é válido")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "O NOME é um campo obrigatório")]
        public string Nome { get; set; }
        public string Rg { get; set; }
        public DateTime? DataExpedicao { get; set; }
        public string OrgaoExpedicao { get; set; }
        public string UfExpedicao { get; set; }

        [Required(ErrorMessage = "O DATA NASCI. é um campo obrigatório")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "O SEXO é um campo obrigatório")]
        public string Sexo { get; set; }

        [Required(ErrorMessage = "O ESTADO CIVIL é um campo obrigatório")]
        public string EstadoCivil { get; set; }

        public int EnderecoId { get; set; }

        [Required(ErrorMessage = "O CEP é um campo obrigatório")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "O LOGRADOURO é um campo obrigatório")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "O NÚMERO é um campo obrigatório")]
        public string Numero { get; set; }

        public string Complemento { get; set; }

        [Required(ErrorMessage = "O BAIRRO é um campo obrigatório")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "O CIDADE é um campo obrigatório")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "O ESTADO é um campo obrigatório")]
        public string Uf { get; set; }
    }
}