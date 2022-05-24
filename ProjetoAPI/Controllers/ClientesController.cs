using ProjetoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjetoAPI.Controllers
{
    public class ClientesController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetTodosClientes(bool incluirEndereco = false)
        {
            IList<Cliente> clientes = null;

            using (var context = new AppDbContext())
            {
                clientes = context.Clientes.Include("Endereco").ToList()
                    .Select(s => new Cliente()
                    {
                        ClienteId = s.ClienteId,
                        Cpf = s.Cpf,
                        Nome = s.Nome,
                        Rg = s.Rg,
                        DataExpedicao = s.DataExpedicao,
                        OrgaoExpedicao = s.OrgaoExpedicao,
                        UfExpedicao = s.UfExpedicao,
                        DataNascimento = s.DataNascimento,
                        Sexo = s.Sexo,
                        EstadoCivil = s.EstadoCivil,
                        Endereco = s.Endereco == null || incluirEndereco == false ? null : new Endereco()
                        {
                            EnderecoId = s.Endereco.EnderecoId,
                            Logradouro = s.Endereco.Logradouro,
                            Numero = s.Endereco.Numero,
                            Complemento = s.Endereco.Complemento,
                            Bairro = s.Endereco.Bairro,
                            Cidade = s.Endereco.Cidade,
                            Uf = s.Endereco.Uf
                        }
                    }).ToList();
            }

            if (clientes.Count == 0)
                return NotFound();

            return Ok(clientes);
        }

        [HttpGet]
        public IHttpActionResult GetClienteById(int? id)
        {
            if (id == null)
                return BadRequest("O Id do contato é inválido");

            Cliente cliente = null;

            using (var context = new AppDbContext())
            {
                cliente = context.Clientes.Include("Endereco").ToList()
                    .Where(c => c.ClienteId == id)
                    .Select(c => new Cliente()
                    {
                        ClienteId = c.ClienteId,
                        Cpf = c.Cpf,
                        Nome = c.Nome,
                        Rg = c.Rg,
                        DataExpedicao = c.DataExpedicao,
                        OrgaoExpedicao = c.OrgaoExpedicao,
                        UfExpedicao = c.UfExpedicao,
                        DataNascimento = c.DataNascimento,
                        Sexo = c.Sexo,
                        EstadoCivil = c.EstadoCivil,
                        Endereco = c.Endereco == null ? null : new Endereco()
                        {
                            EnderecoId = c.Endereco.EnderecoId,
                            Logradouro = c.Endereco.Logradouro,
                            Numero = c.Endereco.Numero,
                            Complemento = c.Endereco.Complemento,
                            Bairro = c.Endereco.Bairro,
                            Cidade = c.Endereco.Cidade,
                            Uf = c.Endereco.Uf
                        }
                    }).FirstOrDefault<Cliente>();

                if (cliente == null)
                    return NotFound();

                return Ok(cliente);
            }
        }
    }
}
