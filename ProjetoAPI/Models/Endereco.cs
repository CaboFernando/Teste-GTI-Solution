using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjetoAPI.Models
{
    [Table("Enderecos")]
    public class Endereco
    {
        [Key]
        public int EnderecoId { get; set; }

        [Required, StringLength(150)]
        public string Logradouro { get; set; }

        [Required, StringLength(100)]
        public string Numero { get; set; }

        [StringLength(100)]
        public string Complemento { get; set; }

        [Required, StringLength(100)]
        public string Bairro { get; set; }

        [Required, StringLength(100)]
        public string Cidade { get; set; }

        [Required, StringLength(100)]
        public string Uf { get; set; }
    }
}