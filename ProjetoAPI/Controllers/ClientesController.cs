using ProjetoAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjetoAPI.Controllers
{
    public class ClientesController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetClientes(bool incluirEndereco = false)
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
                            Cep = s.Endereco.Cep,
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
                            Cep = c.Endereco.Cep,
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

        [HttpPost]
        public IHttpActionResult PostCliente(ClienteEnderecoDTO cliente)
        {
            if (!ModelState.IsValid || cliente == null)
                return BadRequest("Dados de cliente inválidos");

            using (var context = new AppDbContext())
            {
                context.Clientes.Add(new Cliente()
                {
                    Cpf = cliente.Cpf,
                    Nome = cliente.Nome,
                    Rg = cliente.Rg,
                    DataExpedicao = cliente.DataExpedicao,
                    OrgaoExpedicao = cliente.OrgaoExpedicao,
                    UfExpedicao = cliente.UfExpedicao,
                    DataNascimento = cliente.DataNascimento,
                    Sexo = cliente.Sexo,
                    EstadoCivil = cliente.EstadoCivil,
                    Endereco = new Endereco()
                    {
                        Logradouro = cliente.Logradouro,
                        Cep = cliente.Cep,
                        Numero = cliente.Numero,
                        Complemento = cliente.Complemento,
                        Bairro = cliente.Bairro,
                        Cidade = cliente.Cidade,
                        Uf = cliente.Uf
                    }
                });

                context.SaveChanges();
            }
            return Ok(cliente);
        }

        [HttpPut]
        public IHttpActionResult PutCliente(Cliente cliente)
        {
            if (!ModelState.IsValid || cliente == null)
                return BadRequest("Dados de cliente inválidos");

            using (var context = new AppDbContext())
            {
                var clienteSelecionado = context.Clientes.Where(c => c.ClienteId == cliente.ClienteId).FirstOrDefault<Cliente>();

                if (clienteSelecionado != null)
                {
                    clienteSelecionado.Cpf = cliente.Cpf;
                    clienteSelecionado.Nome = cliente.Nome;
                    clienteSelecionado.Rg = cliente.Rg;
                    clienteSelecionado.DataExpedicao = cliente.DataExpedicao;
                    clienteSelecionado.OrgaoExpedicao = cliente.OrgaoExpedicao;
                    clienteSelecionado.UfExpedicao = cliente.UfExpedicao;
                    clienteSelecionado.DataNascimento = cliente.DataNascimento;
                    clienteSelecionado.Sexo = cliente.Sexo;
                    clienteSelecionado.EstadoCivil = cliente.EstadoCivil;

                    context.Entry(clienteSelecionado).State = EntityState.Modified;

                    var enderecoSelecionado = context.Enderecos.Where(c => c.EnderecoId == clienteSelecionado.EnderecoId).FirstOrDefault<Endereco>();

                    if (enderecoSelecionado != null)
                    {
                        enderecoSelecionado.Logradouro = cliente.Endereco.Logradouro;
                        enderecoSelecionado.Cep = cliente.Endereco.Cep;
                        enderecoSelecionado.Numero = cliente.Endereco.Numero;
                        enderecoSelecionado.Complemento = cliente.Endereco.Complemento;
                        enderecoSelecionado.Bairro = cliente.Endereco.Bairro;
                        enderecoSelecionado.Cidade = cliente.Endereco.Cidade;
                        enderecoSelecionado.Uf = cliente.Endereco.Uf;

                        context.Entry(enderecoSelecionado).State = EntityState.Modified;
                    }
                    context.SaveChanges();
                }
                else
                    return NotFound();
            }
            return Ok($"Cliente {cliente.Nome} atualizado com sucesso!");
        }

        public IHttpActionResult DeleteCliente(int? id)
        {
            if (id == null)
                return BadRequest("Dados inválidos");

            var nomeCliente = "";

            using (var context = new AppDbContext())
            {
                var clienteSelecionado = context.Clientes.Where(c => c.ClienteId == id).FirstOrDefault<Cliente>();

                if (clienteSelecionado != null)
                {
                    nomeCliente = clienteSelecionado.Nome;

                    context.Entry(clienteSelecionado).State = EntityState.Deleted;

                    var enderecoSelecionado = context.Enderecos.Where(c => c.EnderecoId == clienteSelecionado.EnderecoId).FirstOrDefault<Endereco>();

                    if (enderecoSelecionado != null)
                        context.Entry(enderecoSelecionado).State = EntityState.Deleted;

                    context.SaveChanges();
                }
                else
                    return NotFound();
            }
            return Ok($"Cliente {nomeCliente} foi excluído com sucesso!");
        }

    }
}
