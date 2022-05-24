using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjetoAPI.Models
{
    [Table("Clientes")]
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }

        [Required, StringLength(14)]
        public string Cpf { get; set; }

        [Required, StringLength(100)]
        public string Nome { get; set; }

        [StringLength(14)]
        public string Rg { get; set; }

        public DateTime DataExpedicao { get; set; }

        public string OrgaoExpedicao { get; set; }

        public string UfExpedicao { get; set; }

        [Required]
        public DateTime DataNascimento { get; set; }

        [Required]
        public string Sexo { get; set; }

        [Required]
        public string EstadoCivial { get; set; }

        [Required]
        public virtual Endereco Endereco { get; set; }

        public virtual int EnderecoId { get; set; }
    }
}